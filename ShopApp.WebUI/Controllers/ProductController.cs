using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using shopapp.data_access.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public IActionResult Index()
        {
            /* VERI AKTARIM YONTEMLERI:
             *ViewBag
             *Model
             *ViewData 
             */
            var product = new Product() { Name = "Iphone X", Price = 6000, Description = "Good Model",ImageUrl="1.png" };
            //ViewData["Category"] = "Phones";
            //ViewData["Product"] = product;

            ViewBag.Category = "Phones";
            //ViewBag.Product = product;

            return View(product);
        }
        //localhost:5000/product/list
        //product/list => tum urunleri (sayfalama)
        //product/list/2 => 2 numarali kategoriye ait urunler
        public IActionResult List(int? id,string q,double? min_price,double? max_price)
        {
            ////ViewBag.Category = category;
            ///


            ////product/list/3
            ////Route.Values["controller"] =>product
            ////Route.Values["action"] =>list
            ////Route.Value["id"] => 3

            //Console.WriteLine(RouteData.Values["controller"]);
            //Console.WriteLine(RouteData.Values["action"]);
            //Console.WriteLine(RouteData.Values["id"]);
            ////Console.WriteLine(RouteData.Values["q"]);

            ////QueryString
            ////1.Yontem ==> q parametresini alma
            ////Console.WriteLine(q);

            ////2.Yontem ==> q parametresini alma
            //Console.WriteLine(HttpContext.Request.Query["q"].ToString());
            //var products = ProductRepository.Products;

            //if (id != null)
            //{
            //    products = products.Where(p => p.CategoryId == id).ToList();
            //}
            //if (!string.IsNullOrEmpty(q))
            //{
            //    products = products.Where(p => p.Name.ToLower().Contains(q.ToLower()) | p.Description.ToLower().Contains(q.ToLower())).ToList();
            //}
            //var productCategory = new ProductViewModel()
            //{
            //    Products = products

            //};
            var productCategory = new ProductViewModel()
            {
                Products = _productRepository.GetAll(),

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
            return View();
        }
        public IActionResult Create(string name,double price)
        {
            ViewBag.Title = "Create A Product";
            Console.WriteLine(name);
            Console.WriteLine(price);
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "Add A Product";
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");

            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            //Procut class'inda tanimladimiz sekilde islem gerceklestiginde ise calisir.
            //if (ModelState.IsValid)
            //{
            //    ProductRepository.AddProduct(p);

            //    return RedirectToAction("list");
            //}
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View();
           
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //ViewBag.Title = "Update A Product";
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            //if (id == null || id<=0)
            //{
            //    return NotFound();
            //}
            //Console.WriteLine("girdi!");
            

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product p)
        {
            //ProductRepository.EditProduct(p);

            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            //ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("List");
        }
    }
}
