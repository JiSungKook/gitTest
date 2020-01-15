using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class RintController : Controller
    {

        // GET: Rint
        public ActionResult Index()
        {
            return View();
        }


        public class Person16
        {
            public string Name;
            public string Age;
            public string Region;
        }


        public ActionResult Index16()
        {
            return View();
        }

        public JsonResult GetJsonPerson16()
        {
            List<Person16> listOfperson = new List<Person16>()
            {
                  new Person16() { Name = "지성국1", Age="19", Region="한국"},
                  new Person16() { Name = "지성국2", Age="20", Region="Japan"},
                  new Person16() { Name = "지성국3", Age="21", Region="Korea"},
            };
            return Json(listOfperson, JsonRequestBehavior.AllowGet);
        }

        public class Person17
        {
            public string Name;
            public string Age;
            public string Region;
        }


        public ActionResult Index17()
        {
            return View();
        }

        public JsonResult GetJsonPerson17()
        {
            List<Person17> listOfperson = new List<Person17>()
            {
                  new Person17() { Name = "지성국1", Age="19", Region="한국"},
                  new Person17() { Name = "지성국2", Age="20", Region="Japan"},
                  new Person17() { Name = "지성국3", Age="21", Region="Korea"},
            };
            return Json(listOfperson);
        }

        public ActionResult Index19()
        {
            //ProductDataContext dataContext = new ProductDataContext();
            
            //List<Rint>
            return View();
        }
    }
}