using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

namespace mvc_project.Controllers;

public class ClientController : Controller
{

    private readonly ILogger<ClientController> _logger;

    public ClientController(ILogger<ClientController> logger) 
    {
        _logger = logger;
    }    
    
    public IActionResult Index() 
    {
        return View();
    }

}
