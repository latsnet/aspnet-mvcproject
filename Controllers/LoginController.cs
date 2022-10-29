using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

namespace mvc_project.Controllers;

public class LoginController : Controller
{

    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger) 
    {
        _logger = logger;
    }    
    
    public IActionResult Index() 
    {
        return View();
    }

}