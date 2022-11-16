using mvc_project.Models;

namespace mvc_project.Repositories.Interfaces;

public interface ICategoryRepository
{
    IEnumerable<Category> Categories { get; }
}
