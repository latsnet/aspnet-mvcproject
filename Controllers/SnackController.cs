using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using mvc_project.ViewModels;
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
    
    public IActionResult List(string category) 
    {
        IEnumerable<Snack> snacks;
        string actualCategory = string.Empty;

        if (string.IsNullOrEmpty(category)) 
        {
            snacks = _snackRepository.Snacks.OrderBy(l => l.SnackId);
            actualCategory = "All Snacks";
        }
        else
        {
            if (string.Equals("Normal", category, StringComparison.OrdinalIgnoreCase)) 
            {
                snacks = _snackRepository.Snacks
                    .Where(l => l.Category.CategoryName.Equals("Normal"))
                    .OrderBy(l => l.SnackName);
            }
            else
            {
                snacks = _snackRepository.Snacks
                    .Where(l => l.Category.CategoryName.Equals("Normal"))
                    .OrderBy(l => l.SnackName);
            }
            actualCategory = category;
        }

        var snackListViewModel = new SnackListViewModel()
        {
            Snacks = snacks,
            Category = actualCategory
        };

        return View(snackListViewModel);
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