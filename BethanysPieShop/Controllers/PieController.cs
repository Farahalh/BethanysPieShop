using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepositroy;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepositroy)
        {
            _pieRepository = pieRepository;
            _categoryRepositroy = categoryRepositroy;
        }

        public IActionResult List() 
        {
        return View(_pieRepository.AllPies);
        }
    }
}
