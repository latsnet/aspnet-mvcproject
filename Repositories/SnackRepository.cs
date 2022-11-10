using mvc_project.Models;
using mvc_project.Repositories.Interfaces;
using mvc_project.Context;
using Microsoft.EntityFrameworkCore;

namespace mvc_project.Repositories;

public class SnackRepository : ISnackRepository
{

    private readonly AppDbContext _context;

    public SnackRepository(AppDbContext context) 
    {
        this._context = context;
    }

    public IEnumerable<Snack> Snacks => this._context.Snacks.Include(c => c.Category);

    public IEnumerable<Snack> FavoriteSnacks => this._context.Snacks.Where(p => p.FavoriteSnack).Include(c => c.Category);

    public Snack GetSnackById(int snackId) => this._context.Snacks.FirstOrDefault(p => p.SnackId == snackId);

}
