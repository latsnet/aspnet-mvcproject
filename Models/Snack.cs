using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models;

[Table("Lanches")]
public class Snack
{

    public int SnackId { get; set; }

    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Nome do Lanche")]
    public string SnackName { get; set; }

    [Required]
    [Display(Name = "Descrição do Lanche")]
    [MinLength(20)]
    [MaxLength(200)]
    public string ShortDescription { get; set; }

    [Required(ErrorMessage = "A descrição completa deve ser informada")]
    [Display(Name = "Descrição Completa")]
    public string DetailDescription { get; set; }


    public decimal Price { get; set; }

    public string ImageUrl { get; set; }

    public string ImageThumbnailUrl { get; set; }

    public bool FavoriteSnack { get; set; }

    public bool InStock { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; }

    [NotMapped]
    public DateTime CreatedDate { get; set; }

}
