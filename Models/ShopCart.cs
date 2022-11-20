using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using mvc_project.Context;

namespace mvc_project.Models;

[Table("ShopCart")]
public class ShopCart
{
    [Key]
    [StringLength(200)]
    public string ShopCartId { get; set; }
    
    public List<ShopCartItem> ShopCartItems { get; set; }

    private readonly AppDbContext _context;

    public ShopCart(AppDbContext context) 
    { 
        this._context = context;
    }

    public static ShopCart GetShopCart(IServiceProvider services) 
    { 
        ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

        var context = services.GetService<AppDbContext>();

        string shopCartId = session.GetString("ShopCartId")??Guid.NewGuid().ToString();

        session.SetString("ShopCartId", shopCartId);

        return new ShopCart(context) 
        { 
            ShopCartId = shopCartId
        };
    }

}