using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using mvc_project.Repositories.Interfaces;
using mvc_project.ViewModels;

namespace mvc_project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ISnackRepository _snackRepository;

    public HomeController(ILogger<HomeController> logger, ISnackRepository snackRepository)
    {
        _logger = logger;
        _snackRepository = snackRepository;
    }

    public IActionResult Index()
    {
        var homeViewModel = new HomeViewModel() 
        {
            FavoriteSnacks = _snackRepository.FavoriteSnacks
        };
        
        return View(homeViewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
