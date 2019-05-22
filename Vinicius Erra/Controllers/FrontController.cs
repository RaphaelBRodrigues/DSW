using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vinicius_Erra.Controllers
{
    public class FrontController : Controller
    {
        // GET: Front
        public ActionResult Default()
        {
            return View();
        }

        public ActionResult pagina2()
        {
            return View();
        }

        public ActionResult pagina3()
        {
            return View();
        }

        public ActionResult pagina4()
        {
            return View();
        }
    }
}