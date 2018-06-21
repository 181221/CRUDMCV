using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
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
        [HttpPost]
        public ActionResult Create(Person data)
        {
            using (DbMvc db = new DbMvc())
            {
                try
                {
                    db.People.Add(data);
                    db.SaveChanges();
                    return Json(new { success = "success", message = "Successfully added to db", }, JsonRequestBehavior.DenyGet);
                }
                catch (Exception e)
                {
                    
                    return Json(new { error = "Error", message = e.Data.ToString() + " Error While posting to Db " } , JsonRequestBehavior.DenyGet);
                }
            }
            //return Json(data, JsonRequestBehavior.DenyGet);
        }

        IEnumerable<Person> getEnumerable()
        {

            using (DbMvc db = new DbMvc())
            {
                return db.People.ToList();
            }
        }
    }
}