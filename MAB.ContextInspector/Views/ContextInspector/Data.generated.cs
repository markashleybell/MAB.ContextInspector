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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ContextInspector/Data.cshtml")]
    public partial class _Views_ContextInspector_Data_cshtml : System.Web.Mvc.WebViewPage<MAB.ContextInspector.Models.ContextInspectorViewModel>
    {
        public _Views_ContextInspector_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\ContextInspector\Data.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");

            
            #line 8 "..\..\Views\ContextInspector\Data.cshtml"
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\ContextInspector\Data.cshtml"
     if (Model.CacheVariables.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <table>\r\n            <colgroup>\r\n                <col");

WriteLiteral(" id=\"col-key\"");

WriteLiteral(" />\r\n                <col");

WriteLiteral(" id=\"col-type\"");

WriteLiteral(" />\r\n                <col");

WriteLiteral(" id=\"col-contents\"");

WriteLiteral(" />\r\n            </colgroup>\r\n            <tr");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n                <th");

WriteLiteral(" colspan=\"3\"");

WriteLiteral(">Cache</th>\r\n            </tr>\r\n            ");

WriteLiteral("\r\n");

            
            #line 24 "..\..\Views\ContextInspector\Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\ContextInspector\Data.cshtml"
             foreach (var variable in Model.CacheVariables)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr");

WriteLiteral(" class=\"data\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" class=\"varkey\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\ContextInspector\Data.cshtml"
                                  Write(variable.Key);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    <td");

WriteLiteral(" class=\"vartype\"");

WriteLiteral("><a");

WriteAttribute("title", Tuple.Create(" title=\"", 773), Tuple.Create("\"", 809)
            
            #line 28 "..\..\Views\ContextInspector\Data.cshtml"
, Tuple.Create(Tuple.Create("", 781), Tuple.Create<System.Object, System.Int32>(variable.Value.FullTypeName
            
            #line default
            #line hidden
, 781), false)
);

WriteLiteral(">");

            
            #line 28 "..\..\Views\ContextInspector\Data.cshtml"
                                                                           Write(variable.Value.ShortTypeName);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                    <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\ContextInspector\Data.cshtml"
                                 Write(variable.Value.Item);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");

            
            #line 31 "..\..\Views\ContextInspector\Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 33 "..\..\Views\ContextInspector\Data.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 34 "..\..\Views\ContextInspector\Data.cshtml"
     if (Model.ApplicationVariables.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <table>\r\n            <colgroup>\r\n                <col");

WriteLiteral(" id=\"col-key\"");

WriteLiteral(" />\r\n                <col");

WriteLiteral(" id=\"col-type\"");

WriteLiteral(" />\r\n                <col");

WriteLiteral(" id=\"col-contents\"");

WriteLiteral(" />\r\n            </colgroup>\r\n            <tr");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n                <th");

WriteLiteral(" colspan=\"3\"");

WriteLiteral(">Application</th>\r\n            </tr>\r\n            ");

WriteLiteral("\r\n");

            
            #line 50 "..\..\Views\ContextInspector\Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\ContextInspector\Data.cshtml"
             foreach (var variable in Model.ApplicationVariables)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr");

WriteLiteral(" class=\"data\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" class=\"varkey\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\ContextInspector\Data.cshtml"
                                  Write(variable.Key);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    <td");

WriteLiteral(" class=\"vartype\"");

WriteLiteral("><a");

WriteAttribute("title", Tuple.Create(" title=\"", 1675), Tuple.Create("\"", 1711)
            
            #line 54 "..\..\Views\ContextInspector\Data.cshtml"
, Tuple.Create(Tuple.Create("", 1683), Tuple.Create<System.Object, System.Int32>(variable.Value.FullTypeName
            
            #line default
            #line hidden
, 1683), false)
);

WriteLiteral(">");

            
            #line 54 "..\..\Views\ContextInspector\Data.cshtml"
                                                                           Write(variable.Value.ShortTypeName);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                    <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\ContextInspector\Data.cshtml"
                                 Write(variable.Value.Item);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");

            
            #line 57 "..\..\Views\ContextInspector\Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 59 "..\..\Views\ContextInspector\Data.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 60 "..\..\Views\ContextInspector\Data.cshtml"
     if (Model.SessionVariables.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <table>\r\n            <colgroup>\r\n                <col");

WriteLiteral(" id=\"col-key\"");

WriteLiteral(" />\r\n                <col");

WriteLiteral(" id=\"col-type\"");

WriteLiteral(" />\r\n                <col");

WriteLiteral(" id=\"col-contents\"");

WriteLiteral(" />\r\n            </colgroup>\r\n            <tr");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n                <th");

WriteLiteral(" colspan=\"3\"");

WriteLiteral(">Session</th>\r\n            </tr>\r\n            ");

WriteLiteral("\r\n");

            
            #line 76 "..\..\Views\ContextInspector\Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\ContextInspector\Data.cshtml"
             foreach (var variable in Model.SessionVariables)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr");

WriteLiteral(" class=\"data\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" class=\"varkey\"");

WriteLiteral(">");

            
            #line 79 "..\..\Views\ContextInspector\Data.cshtml"
                                  Write(variable.Key);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    <td");

WriteLiteral(" class=\"vartype\"");

WriteLiteral("><a");

WriteAttribute("title", Tuple.Create(" title=\"", 2565), Tuple.Create("\"", 2601)
            
            #line 80 "..\..\Views\ContextInspector\Data.cshtml"
, Tuple.Create(Tuple.Create("", 2573), Tuple.Create<System.Object, System.Int32>(variable.Value.FullTypeName
            
            #line default
            #line hidden
, 2573), false)
);

WriteLiteral(">");

            
            #line 80 "..\..\Views\ContextInspector\Data.cshtml"
                                                                           Write(variable.Value.ShortTypeName);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                    <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">");

            
            #line 81 "..\..\Views\ContextInspector\Data.cshtml"
                                 Write(variable.Value.Item);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");

            
            #line 83 "..\..\Views\ContextInspector\Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 85 "..\..\Views\ContextInspector\Data.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591