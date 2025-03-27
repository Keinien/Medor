using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Medor.Models;
using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore;
using Medor.Models.Entities;
using Medor.Models.API.Coinbase_API;
using Medor.Models.Dto.Requests;

namespace Medor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly HttpClient _httpClient;
    private readonly IMemoryCache _cache;
    private readonly ApplicationDbContext _context;
    private readonly IConfiguration _configuration;

    public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory, IMemoryCache cache, ApplicationDbContext context, IConfiguration configuration)
    {
        _logger = logger;
        _httpClient = httpClientFactory.CreateClient();
        _cache = cache;
        _context = context;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        return View();
    }

    //public IActionResult Privacy()
    //{
    //    return View();
    //}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<decimal> GetEurCzeData()
    {
        string url = _configuration.GetValue<string>("ApiSettings:CnbUrl");
        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();

            var parser = new Parser();
            DataFile dataFile = parser.ParseData(content);

            var eurRate = dataFile.Rates.FirstOrDefault(r => r.Code == "EUR");
            if (eurRate != null)
            {
                return eurRate.Rate;
            }
            else
            {
                return 0.0M;
            }
        }
        else
        {
            throw new Exception($"Chyba při načítání dat z {url}: {response.StatusCode}");
        }
    }

    private async Task<decimal> GetEurCzeDataCached()
    {
        const string cacheKey = "EurCzeData";
        if (!_cache.TryGetValue(cacheKey, out decimal eurCze))
        {
            eurCze = await GetEurCzeData();
            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(24)
            };
            _cache.Set(cacheKey, eurCze, cacheEntryOptions);
        }
        return eurCze;
    }

    public async Task<IActionResult> GetBtcEurData()
    {
        string url = _configuration.GetValue<string>("ApiSettings:CoindeskUrl");
        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            var btcEurData = JsonSerializer.Deserialize<Root>(json);
            var eurCze = await GetEurCzeDataCached();
            btcEurData.EURCZE = btcEurData.Data.BTCEUR.PRICE * eurCze;
            return Json(btcEurData);
        }
        else
        {
            return StatusCode((int)response.StatusCode);
        }
    }

    [HttpPost]
    public async Task<IActionResult> SaveData([FromBody] SavedData model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var record = new SavedData
        {
            BtcEur = model.BtcEur,
            BtcCze = model.BtcCze,
            Date = model.Date,
            DateCreated = DateTime.Now
        };

        try
        {
            _context.SavedData.Add(record);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        { }

        return Json(new { success = true });
    }

    public IActionResult GetSavedData()
    {
        var record = _context.SavedData.Select(x => new {
            id = x.Id,
            datum = x.Date.ToString("yyyy-MM-dd HH:mm:ss"),
            btceur = x.BtcEur,
            btccze = x.BtcCze,
            note = x.Note
        }).ToList();

        return Json(record);
    }

    [HttpPut("UpdateSavedData")]
    public async Task<IActionResult> UpdateSavedData([FromBody] UpdateNoteRequest model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var record = await _context.SavedData.FindAsync(model.Id);
        if (record == null)
            return NotFound();

        record.Note = model.Note ?? "";
        record.DateModified = DateTime.Now;

        try
        {
            await _context.SaveChangesAsync();
            return Ok(new { success = true });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Chyba při aktualizaci záznamu: {ex.Message}");
        }
    }

    [HttpDelete("DeleteSavedData")]
    public async Task<IActionResult> DeleteSavedData([FromBody] DeleteRecordsRequest model)
    {
        if (model?.Ids == null || !model.Ids.Any())
        {
            return BadRequest("Žádná ID k odstranění nebyla zadána.");
        }

        var record = await _context.SavedData
            .Where(x => model.Ids.Contains(x.Id))
            .ToListAsync();

        if (!record.Any())
        {
            return NotFound("Žádné záznamy k odstranění nebyly nalezeny.");
        }

        _context.SavedData.RemoveRange(record);

        try
        {
            await _context.SaveChangesAsync();
            return Ok(new { message = "Záznamy byly úspěšně smazány." });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Chyba při mazání záznamů: {ex.Message}");
        }
    }
}
