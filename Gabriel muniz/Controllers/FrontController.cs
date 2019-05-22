using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gabriel_muniz.Controllers
{
    public class FrontController : Controller
    {
        // GET: Front
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult Default()
        {
            return View();
        }
        public ActionResult pg2()
        {
            return View();
        }
        public ActionResult p3()
        {
            return View();
        }
    }
}