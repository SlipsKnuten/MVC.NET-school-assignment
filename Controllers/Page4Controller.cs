using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a15gusbe.Models;

namespace a15gusbe.Controllers
{
    public class Page4Controller : Controller
    {
        private AlienModel alienModel = new AlienModel("wwwlab.iki.his.se-dbsk");
        private AlienModel sm = new AlienModel("wwwlab.iki.his.se-dbsk");
        public ActionResult Index4()
        {
            ViewBag.AllAliensTable = alienModel.GetAllAliens();
            return View();
        }

        [HttpPost]
        public ActionResult SearchAlien(string namn)
        {
            ViewBag.SearchResults = sm.SearchAlien(namn);
            return View("Index5");
        }
    }
}