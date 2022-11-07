namespace mvc_project.Models;

public class OrderItem
{
    public int OrderItemId { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int SnackId { get; set; }
    public Snack Snack { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    
}
