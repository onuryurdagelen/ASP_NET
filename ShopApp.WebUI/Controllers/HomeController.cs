using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{ 
    //localhost:5000
    public class HomeController:Controller
    {
        //localhost:5000/home/index
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            string message = hour < 12 ? "Good Morning!" : "Have a good day!";
            ViewBag.Greeting = message;
            ViewBag.UserName = "Onur";

            var products = new List<Product>(){
                new Product()
                {
                    Name = "Iphone 8",
                    Price = 3500,
                    Description = "Good One"
                },
                 new Product()
                {
                    Name = "Iphone 10",
                    Price = 3800,
                    Description = "Really Good One",
                    //IsApproved = true
                },
                  new Product()
                {
                    Name = "Iphone 7",
                    Price = 3200,
                    Description = "Really Good One"
                },
                   new Product()
                {
                    Name = "Iphone 9",
                    Price = 5800,
                    Description = "Really Good One",
                    //IsApproved = true
                },

            };
            var categories = new List<Category>()
            {
                new Category() { Name = "Phones", Description = "The Category of Phone" },
                new Category() { Name = "PC", Description = "The Category of PC" },
                new Category() { Name = "Laptop", Description = "The Category of Laptop" },
                new Category() { Name = "Electronic", Description = "The Category of Electronic" },
        };

            //ViewBag.Category = category;

            var productCategory = new ProductViewModel()
            {
                Products = products,
                Categories = categories
            };
            return View(productCategory);

           
        }
        //localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
