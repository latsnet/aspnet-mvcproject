using mvc_project.Models;

namespace mvc_project.ViewModels;

public class SnackListViewModel
{

    public IEnumerable<Snack> Snacks { get; set; }
    public string Category { get; set; }
}