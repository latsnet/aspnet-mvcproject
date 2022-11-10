using mvc_project.Models;

namespace mvc_project.Repositories.Interfaces;

public class ICategoryRepository
{
    IEnumerable<Category> Categories { get; }
}
