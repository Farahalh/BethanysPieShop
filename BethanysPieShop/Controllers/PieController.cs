using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    // Define a controller class for handling pie-related requests.
    public class PieController : Controller
    {
        // Declare private fields to store instances of the pie repository and category repository.
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepositroy;

        // Constructor that takes pie and category repositories as dependencies.
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepositroy)
        {
            // Assign the provided repositories to the corresponding private fields.
            _pieRepository = pieRepository;
            _categoryRepositroy = categoryRepositroy;
        }

        // Action method for displaying a list of pies.
        public IActionResult List() 
        {
			// Set a value in the ViewBag to provide the current category (in this case, "Cheese cakes") to the view.
			ViewBag.CurrentCategory = "Cheese cakes";
            // Retrieve a list of all pies from the pie repository and pass it to the view.
            return View(_pieRepository.AllPies);
        }
    }
}
