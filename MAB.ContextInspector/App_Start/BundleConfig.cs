using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace MAB.ContextInspector
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/mab.contextinspector.js").Include(
                        "~/Scripts/mab.contextinspector.js"));

            bundles.Add(new StyleBundle("~/bundles/mab.contextinspector.css").Include(
                      "~/Content/mab.contextinspector.css"));
        }
    }
}
