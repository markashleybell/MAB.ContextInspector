using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAB.ContextInspector.TestHarness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpContext.Application["String_Application_Variable"] = "APP";

            HttpContext.Application["Integer_Application_Variable"] = 143430;

            HttpContext.Application["Boolean_Application_Variable"] = false;

            HttpContext.Application["Decimal_Application_Variable"] = 22.44;

            HttpContext.Application["Object_Application_Variable"] = new
            {
                TestNumber = 24,
                TestBoolean = true,
                TestString = "Here's an application value!",
                TestObject = new { 
                    ID = 26,
                    Name = "Child object"
                }
            };

            Session["String_Session_Variable"] = "HELLO";

            Session["Integer_Session_Variable"] = 100;

            Session["Boolean_Session_Variable"] = true;

            Session["Decimal_Session_Variable"] = 45.05;

            Session["Object_Session_Variable"] = new
            {
                TestNumber = 1,
                TestBoolean = false,
                TestString = "Here's a session value!",
                TestObject = new { 
                    ID = 33,
                    Name = "Child object"
                }
            };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}