using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GearMaiden.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GearMaiden.Controllers
{
    public class GearController : Controller
    {

        private readonly IGearItemRepository _gearItemRepository;

        public GearController(IGearItemRepository gearItemRepository)
        {
            _gearItemRepository = gearItemRepository;
        }

        public IActionResult Index(string categoryName, string categoryDesc, int id)
        {
            var gearitem = _gearItemRepository.GearItemsByCategoryId(id).OrderBy(g => g.Name);


            var gearItemViewModel = new GearItemViewModel()
            {
                GearItems = gearitem.ToList(),
                CategoryName = categoryName,
                CategoryDescription = categoryDesc
            };

            return View(gearItemViewModel);
        }

        public IActionResult Details(int gearItemId)
        {
            return View();
        }
    }
}