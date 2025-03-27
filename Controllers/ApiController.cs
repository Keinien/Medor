using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    private readonly BtcEurService _btcEurService;

    public ApiController(BtcEurService btcEurService)
    {
        _btcEurService = btcEurService;
    }

    [HttpGet("GetBtcEurData")]
    public async Task<IActionResult> GetBtcEurData()
    {
        var btcData = await _btcEurService.GetBtcEurDataAsync();
        return Ok(btcData);
    }
}