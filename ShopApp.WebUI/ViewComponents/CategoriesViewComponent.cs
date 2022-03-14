using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category() { Name = "Phones", Description = "The Category of Phone" },
                new Category() { Name = "PC", Description = "The Category of PC" },
                new Category() { Name = "Laptop", Description = "The Category of Laptop" },
                new Category() { Name = "Electronic", Description = "The Category of Electronic" },
        };

            return View(categories);
        }
    }
}
