using System.ComponentModel.DataAnnotations;
namespace gunpla.Models;

public class GunplaModel
{
    public GunplaModel()
    {
        IsGift = false;
        Tools = new List<string>();
    }
    // Properties

    [Required(ErrorMessage = "Ange modelens nummer")]
    [Display(Name = "Modellnummer:")]
    public string? Code { get; set; }

    [Required(ErrorMessage = "Ange modelens namn")]
    [Display(Name = "Namn:")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Ange modelens typ")]
    [MaxLength(2)]
    [Display(Name = "Typ (HG/RG/EG):")]
    public string? Type { get; set; }

    [Required(ErrorMessage = "Ange series namn")]
    [Display(Name = "Serienamn:")]
    public string? Serie { get; set; }

    [Display(Name = "Är det en present?")]
    public bool IsGift { get; set; }

    [Display(Name = "Extra verktyg:")]
    public List<string> Tools { get; set; }
}