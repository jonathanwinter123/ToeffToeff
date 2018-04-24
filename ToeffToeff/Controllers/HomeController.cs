﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ToeffToeff.Persistence;

namespace ToeffToeff.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var motorcycleDb = new MotorcycleDb();
            var persistedBrands = motorcycleDb.PersistedBrands.Include(pb => pb.PersistedModels).ToList();
            return View(persistedBrands);
        }

        public ActionResult Model(string id)
        {
            return RedirectToAction("Index", "Model", id);
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }

        public ActionResult CreateUser()
        {
            return this.View(new PersistedPersons());
        }

        public ActionResult CreateUser(FormCollection collection)
        {
            return this.RedirectToAction("Home");
        }
    }
}