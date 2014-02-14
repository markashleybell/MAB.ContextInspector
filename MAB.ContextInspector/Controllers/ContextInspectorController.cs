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
using System.Runtime.Caching;

namespace MAB.ContextInspector.Controllers
{
    public static class ContextInspectorExtensions
    {
        public static void AddVariable(this Dictionary<string, Tuple<string, string>> collection, string key, object item)
        {
            var obj = JsonConvert.SerializeObject(item);
            var type = item.GetType().ToString().ToLowerInvariant();
            collection.Add(key, new Tuple<string, string>((type.IndexOf("anonymous") != -1) ? "object" : (type.StartsWith("system")) ? type.Substring(type.IndexOf('.') + 1) : type, obj));
        }
    }

    public class ContextInspectorController : Controller
    {
        public ActionResult Index()
        {
            var cache = MemoryCache.Default;
            var cacheVariables = new Dictionary<string, Tuple<string, string>>();

            foreach (var item in cache)
                cacheVariables.AddVariable(item.Key, item.Value);

            var session = this.HttpContext.Session;
            var sessionVariables = new Dictionary<string, Tuple<string, string>>();

            foreach (string key in session.Keys)
                sessionVariables.AddVariable(key, session[key]);

            var application = this.HttpContext.Application;
            var applicationVariables = new Dictionary<string, Tuple<string, string>>();

            foreach (string key in application.Keys)
                applicationVariables.AddVariable(key, application[key]);

            return View(new ContextInspectorViewModel {
                CacheVariables = cacheVariables,
                SessionVariables = sessionVariables,
                ApplicationVariables = applicationVariables
            });
        }
	}
}