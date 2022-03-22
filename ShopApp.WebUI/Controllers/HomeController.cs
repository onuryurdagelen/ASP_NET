using Microsoft.AspNetCore.Mvc;
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
        private IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productRepository.GetAll()
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
