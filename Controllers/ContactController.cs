using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers;

public class ContactController : Controller
{
    
    private readonly ILogger<ContactController> _logger;

    public ContactController(ILogger<ContactController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}