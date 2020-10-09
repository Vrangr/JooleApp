using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JooleApp.Services.Services;
using JooleApp.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JooleApp.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices categoryServices;

        public CategoryController(ICategoryServices categoryServices)
        {
            this.categoryServices = categoryServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<CategoryViewModel> model = new List<CategoryViewModel>();
            categoryServices.GetCategories().ToList().ForEach(u =>
            {
                CategoryViewModel category = new CategoryViewModel
                {
                    Id = u.Id,
                    CategoryID = u.categoryID,
                    CategoryName = u.categoryName

                };
                model.Add(category);
            });

            return View(model);
        }
    }
}
