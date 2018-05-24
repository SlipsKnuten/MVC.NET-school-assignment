using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using a15gusbe.Models;

namespace a15gusbe.Controllers
{
    public class HomeController : Controller
    {
        private AlienModel alienModel = new AlienModel("wwwlab.iki.his.se-dbsk");

        public ActionResult Index()
        {
            ViewBag.AllAliensTable = alienModel.GetAllAliens();
            return View();
        }

        public ActionResult DeleteAlien(int? id)
        {

            if(id == null)
            {
                return HttpNotFound();
            }

            alienModel.DeleteAlien(id);

            return RedirectToAction("Index");
        }



    }
}