using mvc_project.Models;
using mvc_project.Repositories.Interfaces;
using mvc_project.Context;

namespace mvc_project.Repositories;

public class UserRepository : IUserRepository
{

    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context) 
    {
        this._context = context;
    }

    public IEnumerable<User> Users => this._context.Users;

}
