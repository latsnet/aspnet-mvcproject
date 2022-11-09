using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models;

[Table("OrderItem")]
public class OrderItem
{
    [Key]
    public int OrderItemId { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int ItemNumber { get; set; }
    public int SnackId { get; set; }
    public Snack Snack { get; set; }
    public int Quantity { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
    public decimal Price { get; set; }
    
}
