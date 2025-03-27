using System.Text.Json.Serialization;

namespace Medor.Models.Dto.Responses;

public class SavedDataResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("btcEur")]
    public decimal BtcEur { get; set; }

    [JsonPropertyName("btcCze")]
    public decimal BtcCze { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("dateCreated")]
    public DateTime DateCreated { get; set; }

    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }
}