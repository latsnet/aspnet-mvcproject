using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models;

[Table("ShopCart")]
public class ShopCart
{
    [Key]
    [StringLength(200)]
    public string ShopCartId { get; set; }
    
    public List<ShopCartItem> ShopCartItems { get; set; }

    private readonly AppDbContext _context;

    public ShopCart(IAppDbContext context) 
    { 
        this._context = context;
    }

}