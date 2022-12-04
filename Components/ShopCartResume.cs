using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using mvc_project.ViewModels;

namespace mvc_project.Components;

public class ShopCartResume : ViewComponent
{

    private readonly ShopCart _shopCart;

    public ShopCartResume(ShopCart shopCart)
    {
        _shopCart = shopCart;
    }

    public IViewComponentResult Invoke()
    {
        var itens = _shopCart.GetShopCartItems();

        _shopCart.ShopCartItems = itens;

        var shopCartVM = new ShopCartViewModel() 
        {
            ShopCart = _shopCart,
            TotalShopCart = _shopCart.GetTotalShopCart()
        };

        return View(shopCartVM);        
    }

}

