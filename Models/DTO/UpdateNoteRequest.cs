using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Medor.Models.Dto.Requests;

public class UpdateNoteRequest
{
    [Required(ErrorMessage = "Id je povinné.")]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [StringLength(100, ErrorMessage = "Poznámka nesmí překročit 100 znaků.")]
    [JsonPropertyName("note")]
    public string Note { get; set; }
}