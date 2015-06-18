using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.Caching;
using MAB.ContextInspector.TestHarness.Models;

namespace MAB.ContextInspector.TestHarness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MemoryCache.Default.Add("CachedItem", new {
                TestNumber = 24,
                TestBoolean = true,
                TestString = "Here's an application value!",
                TestObject = new {
                    ID = 26,
                    Name = "Child object"
                }
            }, new CacheItemPolicy {
                AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(60)
            });

            HttpContext.Application["String_Application_Variable"] = "APP";
            HttpContext.Application["Integer_Application_Variable"] = 143430;
            HttpContext.Application["Boolean_Application_Variable"] = false;
            HttpContext.Application["Decimal_Application_Variable"] = 22.44;
            HttpContext.Application["Object_Application_Variable"] = new {
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
            Session["Object_Session_Variable"] = new {
                TestNumber = 1,
                TestBoolean = false,
                TestString = "Here's a session value!",
                TestObject = new { 
                    ID = 33,
                    Name = "Child object"
                }
            };
            Session["Typed_Session_Variable"] = new TestModel {
                ID = 4042,
                Title = "Typed object"
            };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            HttpContext.Application["String_Application_Variable"] = "APP2";
            HttpContext.Application["Integer_Application_Variable"] = 3323;
            HttpContext.Application["Boolean_Application_Variable"] = true;
            HttpContext.Application["Decimal_Application_Variable"] = 19.20;
            HttpContext.Application["Object_Application_Variable"] = new {
                TestNumber = 77,
                TestBoolean = false,
                TestString = "Here's another application value!",
                TestObject = new {
                    ID = 99,
                    Name = "Child object again"
                }
            };

            Session["String_Session_Variable"] = "This is a string";
            Session["Integer_Session_Variable"] = 6545;
            Session["Boolean_Session_Variable"] = true;
            Session["Decimal_Session_Variable"] = 29.999;
            Session["Object_Session_Variable"] = new {
                TestNumber = 32,
                TestBoolean = true,
                TestString = "Another session value...",
                TestObject = new {
                    ID = 9085,
                    Name = "Session child object"
                }
            };

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            HttpContext.Application["String_Application_Variable"] = "APP3";
            HttpContext.Application["Integer_Application_Variable"] = 99;
            HttpContext.Application["Boolean_Application_Variable"] = true;
            HttpContext.Application["Decimal_Application_Variable"] = 1215.323;
            HttpContext.Application["Object_Application_Variable"] = new {
                TestNumber = 5656,
                TestBoolean = false,
                TestString = "An application value again...",
                TestObject = new {
                    ID = 1033,
                    Name = "Child object 3"
                }
            };

            Session["String_Session_Variable"] = "HELLO";
            Session["Integer_Session_Variable"] = 100;
            Session["Boolean_Session_Variable"] = true;
            Session["Decimal_Session_Variable"] = 552.001;
            Session["Object_Session_Variable"] = new {
                TestNumber = 45,
                TestBoolean = true,
                TestString = "Yet another session value",
                TestObject = new {
                    ID = 574,
                    Name = "Another child object!"
                }
            };

            return View();
        }
    }
}