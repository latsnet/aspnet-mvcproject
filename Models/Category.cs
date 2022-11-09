using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models;

[Table("Categories")]
public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
    [Required(ErrorMessage = "Informe o nome da Categoria")]
    [Display(Name = "Nome")]
    public string CategoryName { get; set; }

    [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
    [Required(ErrorMessage = "Informe a Descrição da Categoria")]
    [Display(Name = "Descrição")]
    public string Description { get; set; }

    public List<Snack> Snacks { get; set; }
    
}
