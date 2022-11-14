using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using mvc_project.Repositories.Interfaces;

namespace mvc_project.Controllers;

public class SnackController : Controller
{

    private readonly ILogger<SnackController> _logger;
    private readonly ISnackRepository _snackRepository;

    public SnackController(ILogger<SnackController> logger, ISnackRepository snackRepository) 
    {
        _logger = logger;
        _snackRepository = snackRepository;
    }    
    
    public IActionResult List() 
    {
        var snacks = _snackRepository.Snacks;
        return View(snacks);
    }

    public IActionResult Add() 
    {
        return View();
    }

    public IActionResult Update() 
    {
        return View();
    }

}