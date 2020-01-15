using MVCExample.Common;
using MVCExample.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class HomeController : Controller
    {
        List<Person> ListOfPerson = new List<Person>()
        {
            new Person() { Name = "a", Age="1", Sex="M", Region="한국"},
            new Person() { Name = "b", Age="2", Sex="W", Region="한국"},
            new Person() { Name = "c", Age="3", Sex="W", Region="한국"}

        };
        
        public ActionResult Index()
        {
            //ViewBag.ListOfPerson = ListOfPerson;

            return View();
        }

        public ActionResult Index11()
        {
            return View(ListOfPerson);
        }

        public string Example12(string ID, string Alpha, string Beta)
        {
            string WillOut = "This is page" + ID + "<br />";
            WillOut += "Alpha : " + Alpha + "<br />";
            WillOut += "Beta : " + Beta + "<br />";
            return WillOut;
        }

        // GET : /Home/
        [HttpGet]
        public ActionResult Index13()
        {
            return View();
        }

        [HttpPost]
        public string Index13(Person person)
        {
            string willOut = "<h1>";
            willOut += " " + person.Name;
            willOut += " " + person.Age;
            willOut += " " + person.Region;
            willOut += " " + person.Sex;

            return willOut + "</hl>";
        }

        [HttpGet]
        public ActionResult Index14()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index14(Person person)
        {
            return View("PostIndex14",person);
        }

        public ActionResult Index15()
        {
            return View();
        }

        public JsonResult GetJsonPerson15()
        {
            List<Person> listOfperson = new List<Person>()
            {
                  new Person() { Name = "지성국", Age="19", Sex="M", Region="한국"},
                  new Person() { Name = "지성국2", Age="20", Sex="M", Region="한국"},
                  new Person() { Name = "지성국3", Age="21", Sex="W", Region="Korea"},
            };
            return Json(listOfperson,JsonRequestBehavior.AllowGet);

        }





        [NonAction] // [NonAction]이 붙으면 액션이 아니기에 페이지를 찾을수가 없다.
        public string JustPublic()
        {
            return "JustPublic Page";
        }

        // private이기 때문에 페이지를 찾을수가 없다고 뜬다.
        private string JustPrivate()
        {
            return "JustPrivate Page";
        }


        [AuthorizeFilter]
        public ActionResult About()
        {
//            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Example(int id)
        {
            ViewBag.Id = id;
            return View();

        }

        public ActionResult ExampleTest2(Node node)
        {
            node.Data = node.Idx + "Hello world";
            ViewBag.Data = "ViewBag Test";
            return View();
        }

    }
}