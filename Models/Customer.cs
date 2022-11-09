using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models;

[Table("Customer")]
public class Customer
{

    [Key]
    public int CustomerId { get; set; }

    [StringLength(200, ErrorMessage = "O nome do cliente deve ter no máximo {0} caracteres")]
    [Display(Name = "Nome do Cliente")]
    public string Name { get; set; }
    
}
