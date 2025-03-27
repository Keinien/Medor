using System.ComponentModel.DataAnnotations;

namespace Medor.Models.Dto.Requests;

public class DeleteRecordsRequest
{
    [Required(ErrorMessage = "Musíš zadat alespoň jedno Id.")]
    [MinLength(1)]
    public List<int> Ids { get; set; }
}