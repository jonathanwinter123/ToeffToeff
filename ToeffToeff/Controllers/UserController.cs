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
            return this.View();
        }

        [HttpPost]
        public ActionResult Save(Person person)
        {
            string response = this.Request["g-recaptcha-response"];
            string secretKey = "6Ld6P1QUAAAAAO_mfeLQ92DlyKWc75WLVDrk3l9e";
            WebClient client = new WebClient();
            string downloadString = $"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={response}";
            string result = client.DownloadString(downloadString);
            JObject obj = JObject.Parse(result);
            bool status = (bool)obj.SelectToken("success");

            if (person.Id == 0 && person.Birthdate > new DateTime(1753, 1, 1) && person.Birthdate < DateTime.MaxValue && person.FirstName.IsNullOrWhiteSpace() == false && person.LastName.IsNullOrWhiteSpace() == false && status)
            {
                PersistedPersons persistedPerson = new PersistedPersons { Id = person.Id, FirstName = person.FirstName, LastName = person.LastName, Birthdate = person.Birthdate };
                var motorCycleDb = new MotorcycleDb();
                motorCycleDb.PersistedPersons.Add(persistedPerson);
                motorCycleDb.SaveChanges();
                return this.RedirectToAction("Success");

            }

            this.TempData["error"] = "<script>alert('Falsche Angaben! Bitte überprüfen Sie nochmals Ihre Angaben.')</script>";

            return this.RedirectToAction("Create");
        }

        public ActionResult Success()
        {
            return this.View();
        }
    }
}




