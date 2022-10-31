using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

namespace mvc_project.Controllers;

public class ConfigController : Controller
{

    private readonly ILogger<HomeController> _logger;

    public ConfigController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() 
    {
        return View();
    }
    
}