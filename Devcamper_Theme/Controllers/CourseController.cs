using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Devcamper_Theme.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult ManageCourses()
        {
            return View();
        }
        public ActionResult AddCourses()
        {
            return View();
        }
        public ActionResult ManageCoursesNone()
        {
            return View();
        }
    }
}