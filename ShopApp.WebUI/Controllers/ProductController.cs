using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ShopApp.WebUI.Data;
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
        //product/list => tum urunleri (sayfalama)
        //product/list/2 => 2 numarali kategoriye ait urunler
        public IActionResult List(int? id)
        {
            //ViewBag.Category = category;

            //product/list/3
            //Route.Values["controller"] =>product
            //Route.Values["action"] =>list
            //Route.Value["id"] => 3

            Console.WriteLine(RouteData.Values["controller"]);
            Console.WriteLine(RouteData.Values["action"]);
            Console.WriteLine(RouteData.Values["id"]);

            var products = ProductRepository.Products;

            if (id !=null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

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
            //ViewBag.Description = "Good One
            return View(ProductRepository.GetProductById(id));
        }
    }
}
