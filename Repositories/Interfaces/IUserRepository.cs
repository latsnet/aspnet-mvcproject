using mvc_project.Models;

namespace mvc_project.Repositories.Interfaces;

public class IUserRepository
{
    IEnumerable<User> Users { get; }
}
