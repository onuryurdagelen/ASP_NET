using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Devcamper_Theme.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        public ActionResult Reviews()
        {
            return View();
        }
        public ActionResult AddReview()
        {
            return View();
        }
    }
}