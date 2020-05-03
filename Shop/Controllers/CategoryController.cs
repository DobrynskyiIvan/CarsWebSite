using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CategoryController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCat;
        public CategoryController(IAllCars iallCars, ICarsCategory iCategory)
        {
            _allCars = iallCars;
            _carsCat = iCategory;

        }
        public ViewResult Sorted()
        { 
            ViewBag.Category = "That I sent Category";
            var category = _carsCat.AllCategories;
            return View(category);
        }
    }
}
