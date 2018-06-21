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
            getEnumerable();
            return View();
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