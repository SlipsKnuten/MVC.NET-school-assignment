using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a15gusbe.Models;

namespace a15gusbe.Controllers
{
    public class Page5Controller : Controller
    {
        // GET: Page5
        private AlienModel alienModel = new AlienModel("wwwlab.iki.his.se-dbsk");
        private AlienModel sm = new AlienModel("wwwlab.iki.his.se-dbsk");
        public ActionResult Index6()
        {
            ViewBag.AllAliensTable = alienModel.GetAllAliens();
            return View();
        }

        [HttpPost]
        public ActionResult LoggAlien(int? id)
        {
            ViewBag.SearchResults = sm.LoggAlien(id);
            return RedirectToAction("Index", "Home");
        }
    }
}