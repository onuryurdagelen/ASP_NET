using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
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


            //var categories = CategoryRepository.Categories;

            //ViewBag.Category = category;

            var productCategory = new ProductViewModel()
            {
                Products = ProductRepository.Products,
              
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
