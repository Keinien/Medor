namespace Medor.Models.API.CNB_API;

public class DataFile
{
    public DateTime Date { get; set; }
    public int RecordNumber { get; set; }
    public List<CurrencyRate> Rates { get; set; }
}