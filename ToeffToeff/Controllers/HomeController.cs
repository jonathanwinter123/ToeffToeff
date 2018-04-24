namespace ToeffToeff.Controllers
{
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using Persistence;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var motorcycleDb = new MotorcycleDb();
            var persistedBrands = motorcycleDb.PersistedBrands.Include(pb => pb.PersistedModels).ToList();
            return this.View(persistedBrands);
        }

        public ActionResult Model(string id)
        {
            return this.RedirectToAction("Index", "Model", id);
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
    }
}