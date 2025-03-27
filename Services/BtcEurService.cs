using Medor.Models.API.Coinbase_API;
using System.Text.Json;

public class BtcEurService
{
    private readonly HttpClient _httpClient;
    private readonly CnbEurCzeService _cnbEurCzeService;
    private readonly IConfiguration _configuration;

    public BtcEurService(IHttpClientFactory clientFactory, CnbEurCzeService exchangeRatesService, IConfiguration configuration)
    {
        _httpClient = clientFactory.CreateClient();
        _cnbEurCzeService = exchangeRatesService;
        _configuration = configuration;
    }

    public async Task<object> GetBtcEurDataAsync()
    {
        var json = await _httpClient.GetStringAsync(_configuration["ApiSettings:CoindeskUrl"]);
        var btcEurData = JsonSerializer.Deserialize<Root>(json);
        var eurCze = await _cnbEurCzeService.GetEurCzkRateAsync();

        return new
        {
            btcEurPrice = btcEurData.Data.BTCEUR.PRICE,
            btcCzkPrice = btcEurData.Data.BTCEUR.PRICE * eurCze
        };
    }
}