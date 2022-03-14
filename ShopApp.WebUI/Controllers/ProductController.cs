using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            /* VERI AKTARIM YONTEMLERI:
             *ViewBag
             *Model
             *ViewData 
             */
            var product = new Product() { Name = "Iphone X", Price = 6000, Description = "Good Model" };
            //ViewData["Category"] = "Phones";
            //ViewData["Product"] = product;

            ViewBag.Category = "Phones";
            //ViewBag.Product = product;

            return View(product);
        }
        //localhost:5000/product/list
        public IActionResult List()
        {
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
           

            //ViewBag.Category = category;

            var productCategory = new ProductViewModel()
            {
                Products = products
               
            };
            return View(productCategory);
        }
        //localhost:5000/product/details
        public IActionResult Details(int id)
        {
            // name: "Samsung S6"
            // price: 3000
            // description: "Good one"

            //ViewBag.Name = "Samsung S6";
            //ViewBag.Price = 3000;
            //ViewBag.Description = "Good One";

            var p = new Product()
            {
                Name = "Samsung S6",
                Price = 3000,
                Description = "Good One"
            };
            return View(p);
        }
    }
}
