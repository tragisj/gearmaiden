using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using GearMaiden.Models;
using GearMaiden.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GearMaiden.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICategoryRepository _categoryRespository;

        public HomeController(ICategoryRepository categoryRepository)
        {
            _categoryRespository = categoryRepository;
        }

        public IActionResult Index()
        {

            ViewBag.Title = "Category Overview";
            var categories = _categoryRespository.GetAllCategories().OrderBy(c => c.Name);

            var catViewModel = new HomeViewModel()
            {
                Categories = categories.ToList(),
                Title = "My Gear Categories"
            };

            return View(catViewModel);
        }

        public IActionResult Details(int id)
        {

            ViewBag.Title = "Category Detail";
            var category = _categoryRespository.GetCategoryById(id);
            if (category == null)
                return NotFound();

            return View(category);
        }
    }
}