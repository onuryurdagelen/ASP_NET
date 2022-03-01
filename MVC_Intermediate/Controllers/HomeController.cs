using MVC_Intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intermediate.Controllers
{
    public class HomeController : Controller
    {
        //GET : Home
        public ActionResult Index()
        {
            //Veritabanin baglanir ve bilgileri getirir.
            //Getirilen bilgiler bir model icerisine yani bir icerisine aktarilir ve bu model view'a gonderilir.

            List<Product> products = new List<Product>()
            {
               new Product(){ProductId = 1,ProductName="Samsung S6",Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",Price = 1000,isInStock=true},
               new Product(){ProductId = 2,ProductName="Iphone 6",Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",Price = 1200,isInStock=true},
               new Product(){ProductId = 3,ProductName="Iphone 6s",Description = "Very Good!",Price = 1300,isInStock=false},
               new Product(){ProductId = 4,ProductName="Samsung S7",Description = "Fantastic!",Price = 1500,isInStock=true},
            };

            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryId = 1,CategoryName = "Samsung"},
                new Category(){CategoryId = 2,CategoryName = "Apple"},
                new Category(){CategoryId = 3,CategoryName = "Asus"},
                new Category(){CategoryId = 4,CategoryName = "HP"},
            };

            ViewBag.categories = categories;
            //Ilgili html view'ina deger gondermek icin kullanilir.
            ViewBag.ProductCount = products.Count;

            

            return View(products);
        } 

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult CategoryList()
        {

           

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}