using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a15gusbe.Models;

namespace a15gusbe.Controllers
{
    public class Page2Controller : Controller
    {
        private AlienModel alienModel = new AlienModel("wwwlab.iki.his.se-dbsk");

        public ActionResult Index2()
        {
            
            ViewBag.AllAliensTable = alienModel.GetAllAliens();

            return View();
        }

        [HttpPost]
        public ActionResult InsertAlien(string namn,int? farlighetsgrad, string rasnamn, string pnr)
        {
            alienModel.InsertAlien(namn,farlighetsgrad, rasnamn,pnr);

            return RedirectToAction("Index", "Home");
        }
    }
}