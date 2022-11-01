using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

namespace mvc_project.Controllers;

public class UserController : Controller
{

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger) 
    {
        _logger = logger;
    }    
    
    public IActionResult Index() 
    {
        return View();
    }

}
