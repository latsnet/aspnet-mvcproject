using mvc_project.Models;

namespace mvc_project.Repositories.Interfaces;

public interface ISnackRepository
{
    IEnumerable<Snack> Snacks { get; }
    IEnumerable<Snack> FavoriteSnacks { get; }
    Snack GetSnackById(int snackId);
}
