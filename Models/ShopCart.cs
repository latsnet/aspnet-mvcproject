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

    public void AddShopCart(Snack snack) 
    {
        var shopCartItem = _context.ShopCartItems.SingleOrDefault(s => s.Snack.SnackId == snack.SnackId && s.OrderId == ShopCartId);
        if (shopCartItem == null) 
        {
            shopCartItem = new ShopCartItem() 
            {
                OrderId = ShopCartId,
                Snack = snack, 
                Quantity = 1
            };
            _context.ShopCartItems.Add(shopCartItem);
        }
        else
        { 
            shopCartItem.Quantity++;
        }
        _context.SaveChanges();
    }

    public int RemoveShopCart(Snack snack)
    {
        var shopCartItem = _context.ShopCartItems.SingleOrDefault(s => s.Snack.SnackId == snack.SnackId && s.OrderId == ShopCartId);
        
        if (shopCartItem != null)
        { 
            int quantity = shopCartItem.Quantity - 1;
            if (shopCartItem.Quantity > 1)
            {
                shopCartItem.Quantity--;
            }
            else
            { 
                _context.ShopCartItems.Remove(shopCartItem);
            }
            _context.SaveChanges();
            return quantity;
        }

        return 0;
    }

}