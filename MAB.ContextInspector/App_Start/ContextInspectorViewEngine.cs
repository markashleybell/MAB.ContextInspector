using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using RazorGenerator.Mvc;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(MAB.ContextInspector.ContextInspectorViewEngine), "Start")]

namespace MAB.ContextInspector 
{
    public static class ContextInspectorViewEngine 
    {
        public static void Start() 
        {
            var engine = new PrecompiledMvcEngine(typeof(ContextInspectorViewEngine).Assembly) {
                UsePhysicalViewsIfNewer = HttpContext.Current.Request.IsLocal
            };

            ViewEngines.Engines.Insert(0, engine);
            VirtualPathFactoryManager.RegisterVirtualPathFactory(engine);
        }
    }
}
