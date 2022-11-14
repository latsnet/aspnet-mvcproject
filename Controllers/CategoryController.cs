using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using mvc_project.Repositories.Interfaces;

namespace mvc_project.Controllers;

public class CategoryController : Controller
{

    private readonly ILogger<CategoryController> _logger;
    private readonly ICategoryRepository _CategoryRepository;

    public CategoryController(ILogger<CategoryController> logger, ICategoryRepository CategoryRepository) 
    {
        _logger = logger;
        _CategoryRepository = CategoryRepository;
    }    
    
    public IActionResult List() 
    {
        var categories = _CategoryRepository.Categories;
        return View(categories);
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