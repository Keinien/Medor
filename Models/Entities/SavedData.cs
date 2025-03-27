using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medor.Models.Entities;

[Table("MedorData")]
public class SavedData
{
    [Key]
    public int Id { get; set; }

    [Required, Column(TypeName = "decimal(18,8)")]
    public decimal BtcEur { get; set; }

    [Required, Column(TypeName = "decimal(18,8)")]
    public decimal BtcCze { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [StringLength(100)]
    public string? Note { get; set; }

    [Required]
    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
}