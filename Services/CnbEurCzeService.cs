using Medor.Models;
using Microsoft.Extensions.Caching.Memory;

public class CnbEurCzeService
{
    private readonly HttpClient _httpClient;
    private readonly IMemoryCache _cache;
    private readonly IConfiguration _configuration;

    public CnbEurCzeService(IHttpClientFactory clientFactory, IMemoryCache cache, IConfiguration configuration)
    {
        _httpClient = clientFactory.CreateClient();
        _cache = cache;
        _configuration = configuration;
    }

    public async Task<decimal> GetEurCzkRateAsync()
    {
        const string cacheKey = "EurCzkRate";
        if (!_cache.TryGetValue(cacheKey, out decimal eurCzk))
        {
            var response = await _httpClient.GetStringAsync(_configuration["ApiSettings:CnbUrl"]);
            var parser = new Parser();
            var dataFile = parser.ParseData(response);
            eurCzk = dataFile.Rates.FirstOrDefault(x => x.Code == "EUR")?.Rate ?? 0.0M;

            _cache.Set(cacheKey, eurCzk, TimeSpan.FromHours(24));
        }
        return eurCzk;
    }
}