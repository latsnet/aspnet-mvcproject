using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models;

[Table("ShopCartItem")]
public class ShopCartItem
{
    [Key]
    public int ShopCartItemId { get; set; }
    public Snack Snack { get; set; }
    public int Quantity { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
    public decimal Price { get; set; }

    [StringLength(200)]
    public string OrderId { get; set; }
    
}
