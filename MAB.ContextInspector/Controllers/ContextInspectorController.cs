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
        public static void AddVariable(this Dictionary<string, ContextInspectorItemInfo> collection, string key, object item)
        {
            var typeName = item.GetType().ToString();
            var shortTypeName = "";

            // If it's an anonymous type, just refer to it as object
            if (typeName.ToLowerInvariant().IndexOf("anonymous") != -1)
            {
                typeName = "System.Object";
                shortTypeName = "Object";
            }
            else // Remove all the namespacing for the short version of the type name
            {
                shortTypeName = typeName.Substring(typeName.LastIndexOf('.') + 1);
            }

            try
            {
                var obj = JsonConvert.SerializeObject(item);

                collection.Add(key, new ContextInspectorItemInfo {
                    FullTypeName = typeName,
                    ShortTypeName = shortTypeName,
                    Item = obj
                });
            }
            catch(Exception ex)
            {
                collection.Add(key, new ContextInspectorItemInfo {
                    FullTypeName = typeName,
                    ShortTypeName = shortTypeName,
                    Item = "COULD NOT SERIALIZE: " + ex.Message
                });
            }
        }
    }

    public class ContextInspectorController : Controller
    {
        public ActionResult Index()
        {
            // Add cache contents
            var cache = MemoryCache.Default;
            var cacheVariables = new Dictionary<string, ContextInspectorItemInfo>();

            // Cached EF metadata causes a StackOverFlowException when serializing to JSON,
            // plus we don't care about it anyway so just filter it out
            foreach (var item in cache.Where(x => !x.Key.StartsWith("MetadataPrototypes::")))
                cacheVariables.AddVariable(item.Key, item.Value);

            // Add session variables
            var session = this.HttpContext.Session;
            var sessionVariables = new Dictionary<string, ContextInspectorItemInfo>();

            foreach (string key in session.Keys)
                sessionVariables.AddVariable(key, session[key]);

            // Add application variables
            var application = this.HttpContext.Application;
            var applicationVariables = new Dictionary<string, ContextInspectorItemInfo>();

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