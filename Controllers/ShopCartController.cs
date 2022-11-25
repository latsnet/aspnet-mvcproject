using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using mvc_project.Repositories.Interfaces;
using mvc_project.ViewModels;

namespace mvc_project.Controllers;

public class ShopCartController : Controller
{


    private readonly ILogger<ShopCartController> _logger;
    private readonly ISnackRepository _snackRepository;
    private readonly ShopCart _shopCart;

    public ShopCartController(ILogger<ShopCartController> logger,
                 ISnackRepository snackRepository,
                 ShopCart shopCart)
    {
        _logger = logger;
        _snackRepository = snackRepository;
        _shopCart = shopCart;
    }

    public IActionResult Index()
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

    public IActionResult AddItemToShopCart(int snackId)
    {
        var selectedSnack = _snackRepository.Snacks.FirstOrDefault(s => s.SnackId == snackId);

        if (selectedSnack == null)
        {
            _shopCart.AddShopCart(selectedSnack);
        }

        return RedirectToAction("Index");
    }

    public IActionResult RemoveItemFromShopCart(int snackId)
    {
        var selectedSnack = _snackRepository.Snacks.FirstOrDefault(s => s.SnackId == snackId);

        if (selectedSnack != null)
        {
            _shopCart.RemoveShopCart(selectedSnack);
        }

        return RedirectToAction("Index");
    }

}