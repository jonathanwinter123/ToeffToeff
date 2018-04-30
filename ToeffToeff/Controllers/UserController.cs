using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
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

        [HttpPost]
        public ActionResult Save(Person person)
        {
            const string SecretKey = "6Ld6P1QUAAAAAO_mfeLQ92DlyKWc75WLVDrk3l9e";
            var response = this.Request["g-recaptcha-response"];
            var client = new WebClient();
            var downloadString = $"https://www.google.com/recaptcha/api/siteverify?secret={SecretKey}&response={response}";
            var result = client.DownloadString(downloadString);
            var obj = JObject.Parse(result);
            var status = (bool)obj.SelectToken("success");

            if (person.Id == 0 && person.Birthdate > new DateTime(1753, 1, 1) && person.Birthdate < DateTime.MaxValue && person.FirstName.IsNullOrWhiteSpace() == false && person.LastName.IsNullOrWhiteSpace() == false && status)
            {
                var persistedPerson = new PersistedPersons { Id = person.Id, FirstName = person.FirstName, LastName = person.LastName, Birthdate = person.Birthdate };
                var motorCycleDb = new MotorcycleDb();
                motorCycleDb.PersistedPersons.Add(persistedPerson);
                motorCycleDb.SaveChanges();
                return RedirectToAction("Success");

            }

            TempData["error"] = "<script>alert('Falsche Angaben! Bitte überprüfen Sie nochmals Ihre Angaben.')</script>";

            return RedirectToAction("Create");
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult List()
        {
            var motorcycleDb = new MotorcycleDb();
            var persistedPersons = motorcycleDb.PersistedPersons.ToList();
            return View(persistedPersons);
        }

        public ActionResult Delete()
        {
            var motorcycleDb = new MotorcycleDb();
            var personToDelete = motorcycleDb.PersistedPersons.Find(Convert.ToInt32(RouteData.Values["id"] + Request.Url?.Query));
            motorcycleDb.PersistedPersons.Remove(personToDelete ?? throw new NullReferenceException());
            motorcycleDb.SaveChanges();
            return RedirectToAction("List");
        }
    }
}




