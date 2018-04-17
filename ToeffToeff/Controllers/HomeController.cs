using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ToeffToeff.Persistence;

namespace ToeffToeff.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            MotorcycleDb motorcycleDb = new MotorcycleDb();
            List<PersistedBrands> persistedBrands = motorcycleDb.PersistedBrands.Include(pb => pb.PersistedModels).ToList();
            return View(persistedBrands);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}