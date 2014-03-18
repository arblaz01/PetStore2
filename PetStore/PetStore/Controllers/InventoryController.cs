using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class InventoryController : Controller
    {
        private PetDBContext db = new PetDBContext();
        //
        // GET: /Inventory/
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }

        public ActionResult Details(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
	}
}