﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using MAB.ContextInspector;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ContextInspector/Index.cshtml")]
    public partial class _Views_ContextInspector_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_ContextInspector_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\ContextInspector\Index.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n    <head>\r\n        <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width\"");

WriteLiteral(" />\r\n        <title>Index</title>\r\n        <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(@">
            
            *, *:before, *:after {
                -moz-box-sizing: border-box;
                -webkit-box-sizing: border-box;
                box-sizing: border-box;
            }

            body {
                margin: 0;
                padding: 0;
                font-family: Helvetica, Arial, 'DejaVu Sans', 'Liberation Sans', Freesans, sans-serif;
                font-size: 12px;
            }

        </style>
");

WriteLiteral("        ");

            
            #line 27 "..\..\Views\ContextInspector\Index.cshtml"
   Write(Styles.Render("~/bundles/mab.contextinspector.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </head>\r\n<body>\r\n");

            
            #line 30 "..\..\Views\ContextInspector\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\ContextInspector\Index.cshtml"
       Html.RenderAction("Data"); 
            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var _CI_STANDALONE = true;\r\n    </script>\r\n");

WriteLiteral("    ");

            
            #line 34 "..\..\Views\ContextInspector\Index.cshtml"
Write(Scripts.Render("~/bundles/mab.contextinspector.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
