using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a15gusbe.Models;

namespace a15gusbe.Controllers
{
    public class Page3Controller : Controller
    {
        private AlienModel alienModel = new AlienModel("wwwlab.iki.his.se-dbsk");

        public ActionResult Index3()
        {

            ViewBag.AllAliensTable = alienModel.GetAllAliens();

            return View();
        }

        [HttpPost]
        public ActionResult UpdateAlien(string namn, int? farlighetsgrad, string rasnamn, string pnr, int? id)
        {
            alienModel.UpdateAlien(namn,farlighetsgrad, rasnamn, pnr, id);

            return RedirectToAction("Index", "Home");
        }
    }
}

    