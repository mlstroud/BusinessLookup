using System.ComponentModel.DataAnnotations;

namespace BusinessLookup.Models
{
  public class Business
  {
    public int BusinessId { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [Required]
    public string Category { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [StringLength(7, ErrorMessage = "Time format must be HH:MMam / pm or H:MMam / pm.")]
    public string OpeningTime { get; set; }

    [Required]
    [StringLength(7, ErrorMessage = "Time format must be HH:MMam/pm or H:MMam/pm.")]
    public string ClosingTime { get; set; }
  }
}