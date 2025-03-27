using Medor.Models.Dto.Requests;
using Medor.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class SavedDataController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SavedDataController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("SaveData")]
    public async Task<IActionResult> SaveData([FromBody] SavedData model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        model.DateCreated = DateTime.UtcNow;
        _context.SavedData.Add(model);
        await _context.SaveChangesAsync();

        return Ok(new { success = true });
    }

    [HttpPut("UpdateSavedData")]
    public async Task<IActionResult> UpdateSavedData([FromBody] UpdateNoteRequest model)
    {
        var record = await _context.SavedData.FindAsync(model.Id);
        if (record == null)
            return NotFound();

        record.Note = model.Note;
        record.DateModified = DateTime.Now;

        await _context.SaveChangesAsync();

        return Ok(new { success = true });
    }

    [HttpDelete("DeleteSavedData")]
    public async Task<IActionResult> DeleteSavedData([FromBody] DeleteRecordsRequest model)
    {
        var records = await _context.SavedData.Where(x => model.Ids.Contains(x.Id)).ToListAsync();
        if (!records.Any())
            return NotFound();

        _context.SavedData.RemoveRange(records);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Záznamy byly úspěšně smazány." });
    }

    [HttpGet("GetSavedData")]
    public IActionResult GetSavedData()
    {
        var data = _context.SavedData.Select(x => new {
            x.Id,
            Date = x.Date.ToString("yyyy-MM-dd HH:mm:ss"),
            x.BtcEur,
            x.BtcCze,
            x.Note
        }).ToList();

        return Ok(data);
    }
}