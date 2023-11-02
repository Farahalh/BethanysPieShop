using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
	// Define a controller class for handling pie-related requests.
	public class PieController : Controller
	{
		// Declare private fields to store instances of the pie repository and category repository.
		private readonly IPieRepository _pieRepository;
		private readonly ICategoryRepository _categoryRepository;

		// Constructor that takes pie and category repositories as dependencies.
		public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
		{
			// Assign the provided repositories to the corresponding private fields.
			_pieRepository = pieRepository;
			_categoryRepository = categoryRepository;
		}

		// Action method for displaying a list of pies.
		public IActionResult List()
		{
			//// Set a value in the ViewBag to provide the current category (in this case, "Cheese cakes") to the view.
			// ViewBag.CurrentCategory = "Cheese cakes";

			//// Retrieve a list of all pies from the pie repository and pass it to the view.
			// return View(_pieRepository.AllPies);

			// Create a view model that combines pie data and the current category.
			PieListViewModel pieListViewModel = new PieListViewModel
				(_pieRepository.AllPies, "Cheese cakes");

			// Return the view with the view model as its data source.
			return View(pieListViewModel);
		}
	}
}
