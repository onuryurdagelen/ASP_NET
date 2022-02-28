using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Devcamper_Theme.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult ManageBootcamp()
        {
            return View();
        }
        public ActionResult ManageReviews()
        {
            return View();
        }
        public ActionResult ManageAccount()
        {
            return View();
        }
    }
}