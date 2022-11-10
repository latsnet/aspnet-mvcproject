using mvc_project.Models;
using mvc_project.Repositories.Interfaces;
using mvc_project.Context;

namespace mvc_project.Repositories;

public class CategoryRepository : ICategoryRepository
{

    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context) 
    {
        this._context = context;
    }

    public IEnumerable<Category> Categories => this._context.Categories;

}
