using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Devcamper_Theme.Controllers
{
    public class BootcampsController : Controller
    {
        // GET: BootcampList
        public ActionResult Index()
        {
            //Veritabanindan butun bootcam bilgielrini al ve View uzerine gonder.
            //kendisine gelen bootcamp bilgileri dinamik icerik ureten View yapisi bunu statik HTML'e cevirir.
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult AddBootcamp()
        {
            return View();
        }
        public ActionResult ManageBootcampNone()
        {
            return View();
        }
    }
}