using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenTruongQuy_KtFE1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult MasterLayout()
        {
            return View();
        }
        public ActionResult TrangChu()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}