using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDMCV.Models;

namespace CRUDMCV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult viewAll()
        {
            return View(getEnumerable());
        }

        public ActionResult Test(Person data)
        {
            using (DbMvc db = new DbMvc())
            {
                db.People.Add(data);
                db.SaveChanges();
            }
            return Json(data.Name, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Edit(Person data)
        {
            var dataten = data;
            using (DbMvc db = new DbMvc())
            {
                db.People.Add(data);
                db.SaveChanges();
            }

            return Json(data.Name, JsonRequestBehavior.DenyGet);
        }


        IEnumerable<Person> getEnumerable()
        {

            using (DbMvc db = new DbMvc())
            {
                var test = db.People.ToList();
                return db.People.ToList();
            }
        }
    }
}