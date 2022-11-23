using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using mvc_project.Repositories.Interfaces;

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
        return View();
    }

    public IActionResult AddItemToShopCart()
    {
        return View();
    }

    public IActionResult RemoveItemFromShopCart()
    {
        return View();
    }



}