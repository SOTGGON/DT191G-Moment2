using System.ComponentModel.DataAnnotations;
namespace gunpla.Models;

public class GunplaModel {
    // Properties

    [Required(ErrorMessage = "Ange modelens nummer")]
    [Display(Name = "Modellnummer:")]
    public string? Code {get; set;}

    [Required (ErrorMessage = "Ange modelens namn")]
    [Display(Name = "Namn:")]
    public string? Name {get; set;}

    [Required (ErrorMessage = "Ange modelens typ")]
    [MaxLength(2)]
    [Display(Name = "Typ (HG/RG/EG):")]
    public string? Type {get; set;}

    [Required (ErrorMessage = "Ange series namn")]
    [Display(Name = "Serienamn:")]
    public string? Serie {get; set;}

}