using MAB.ContextInspector.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace MAB.ContextInspector.Controllers
{
    public class ContextInspectorController : Controller
    {
        public ActionResult Index()
        {
            var session = this.HttpContext.Session;
            var sessionVariables = new Dictionary<string, Tuple<string, string>>();

            foreach(string key in session.Keys)
            {
                var obj = JsonConvert.SerializeObject(session[key]);
                var type = session[key].GetType().ToString().ToLowerInvariant();
                sessionVariables.Add(key.ToString(), new Tuple<string, string>((type.IndexOf("anonymous") != -1) ? "object" : type.Substring(type.IndexOf('.') + 1), obj));
            }

            var application = this.HttpContext.Application;
            var applicationVariables = new Dictionary<string, Tuple<string, string>>();

            foreach (string key in application.Keys)
            {
                var obj = JsonConvert.SerializeObject(application[key]);
                var type = application[key].GetType().ToString().ToLowerInvariant();
                applicationVariables.Add(key.ToString(), new Tuple<string, string>((type.IndexOf("anonymous") != -1) ? "object" : type.Substring(type.IndexOf('.') + 1), obj));
            }

            return View(new ContextInspectorViewModel {
                SessionVariables = sessionVariables,
                ApplicationVariables = applicationVariables
            });
        }
	}
}