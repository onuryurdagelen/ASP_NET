using Microsoft.AspNetCore.Mvc;
using shopapp.business.Concrete;
using shopapp.data_access.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{ 
    //localhost:5000
    public class HomeController:Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetAll()
            };

            return View(productViewModel);
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
