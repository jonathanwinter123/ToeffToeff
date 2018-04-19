namespace ToeffToeff.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using Persistence;

    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult Index(int brandId)
        {
            var motorcycleDb = new MotorcycleDb();
            var persistedModels = motorcycleDb.PersistedModels.Where(x => x.PersistedBrands.Id == brandId).Include(x => x.PersistedBrands).Include(x => x.PersistedPersons).ToList();
            return View(persistedModels);
        }
    }
}