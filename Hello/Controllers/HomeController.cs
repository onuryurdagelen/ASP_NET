﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            
            return View();
        }
        public ViewResult Contact()
        {

            return View();
        }
        public ViewResult About()
        {

            return View();
        }
       
    }
}