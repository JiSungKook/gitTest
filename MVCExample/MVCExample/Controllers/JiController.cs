using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class JiController : Controller
    {
        //생성시 아래와 같이 선언된다.
        //// GET: Ji
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index() {
            return "Hello, ASP.NET MVC..!";
        }

        public string Test1()
        {
            return "<h1>Test1 Page</h1>";
        }

        public string Test2()
        {
            return "<h1>Test2 Page</h1>";
        }
    }
}