using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuanaINF22B.Controllers
{
    public class FrontController : Controller
    {
        // GET: Front
        public ActionResult Default()
        {
            return View();
        }
    }
}