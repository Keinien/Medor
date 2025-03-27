namespace Medor.Models.API.CNB_API;

public class CurrencyRate
{
    public string Country { get; set; }
    public string Currency { get; set; }
    public int Quantity { get; set; }
    public string Code { get; set; }
    public decimal Rate { get; set; }
}