using mvc_project.Models;

namespace mvc_project.ViewModels;

public class HomeViewModel
{

    public IEnumerable<Snack> FavoriteSnacks { get; set; }

}