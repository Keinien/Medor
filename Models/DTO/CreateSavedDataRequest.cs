using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Medor.Models.Dto.Requests;

public class CreateSavedDataRequest
{
    [Required]
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [Required]
    [JsonPropertyName("btcEur")]
    public decimal BtcEur { get; set; }

    [Required]
    [JsonPropertyName("btcCze")]
    public decimal BtcCze { get; set; }

    [JsonPropertyName("note")]
    [StringLength(100)]
    public string? Note { get; set; }
}