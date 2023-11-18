using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    // Define a view model class named PieListViewModel.
    public class PieListViewModel
    {
        // Public property representing a collection of Pie objects.
        public IEnumerable<Pie> Pies { get; }

        // Public property representing the current category (nullable string).
        public string? CurrentCategory { get; }

        // Constructor for PieListViewModel that takes a collection of pies and a current category as parameters.
        public PieListViewModel(IEnumerable<Pie> pies, string? currentCategory)
        {
            // Assign the passed collection of pies to the Pies property.
            Pies = pies;

            // Assign the passed current category to the CurrentCategory property.
            CurrentCategory = currentCategory;
        }
    }
}
