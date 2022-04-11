using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TuDien.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult TuDaLuu()
        {
            ViewBag.Title = "Danh sách từ đã lưu";
            return View();
        }
    }
}
