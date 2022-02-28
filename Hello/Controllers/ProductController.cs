using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ViewResult Index()
        {
            return View();
        }

        //Product//ProductList
        public ViewResult ProductList()
        {

            return View();
        }
        public ViewResult ProductDetail()
        {

            return View();
        }
    }
}