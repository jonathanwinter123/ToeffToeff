using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToeffToeff.Persistence;

namespace ToeffToeff.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Create()
        {
            return View();
        }

        public virtual ActionResult Save(Persistence.PersistedPersons person)
        {
            var motorCycleDb = new MotorcycleDb();
            motorCycleDb.PersistedPersons.Add(person);
            motorCycleDb.SaveChanges();

            return RedirectToAction("Sucess");
        }

        public ActionResult Sucess()
        {
            return View();
        }
    }
}




