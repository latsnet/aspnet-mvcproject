using Microsoft.EntityFrameworkCore;
using mvc_project.Models;

namespace mvc_project.Context;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Snack> Snacks { get; set; }

} 