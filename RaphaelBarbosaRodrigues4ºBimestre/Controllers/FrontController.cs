using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaphaelBarbosaRodrigues4ºBimestre.Controllers
{
    public class FrontController : Controller
    {
        // GET: Front
        public ActionResult Default()
        {
            return View();
        }
       public ActionResult Features()
        {
            return View();
        }
        public ActionResult Pages()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Port()
        {
            return View();
        }
      
    }
}