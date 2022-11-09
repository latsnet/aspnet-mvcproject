using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models;

[Table("Order")]
public class Order
{
    [Key]
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    
}
