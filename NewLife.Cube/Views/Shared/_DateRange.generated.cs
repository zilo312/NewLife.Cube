﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_DateRange.cshtml")]
    public partial class _Views_Shared__DateRange_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__DateRange_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_DateRange.cshtml"
  
    var fmt = Model as String;
    var formatStr = !fmt.IsNullOrEmpty() ? fmt : "yyyy-MM-dd";
    //var name = fmt == "yyyy-MM-dd" ? "日期" : "时间";
    var p = ViewBag.Page as Pager;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-calendar\"");

WriteLiteral("></i></span>\r\n        <input");

WriteLiteral(" name=\"dtStart\"");

WriteLiteral(" id=\"dtStart\"");

WriteAttribute("value", Tuple.Create(" value=\"", 437), Tuple.Create("\"", 458)
            
            #line 11 "..\..\Views\Shared\_DateRange.cshtml"
, Tuple.Create(Tuple.Create("", 445), Tuple.Create<System.Object, System.Int32>(p["dtStart"]
            
            #line default
            #line hidden
, 445), false)
);

WriteAttribute("dateformat", Tuple.Create(" dateformat=\"", 459), Tuple.Create("\"", 482)
            
            #line 11 "..\..\Views\Shared\_DateRange.cshtml"
, Tuple.Create(Tuple.Create("", 472), Tuple.Create<System.Object, System.Int32>(formatStr
            
            #line default
            #line hidden
, 472), false)
);

WriteLiteral(" class=\"form-control form_datetime\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"dtEnd\"");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">~</label>\r\n    <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n        ");

WriteLiteral("\r\n        <input");

WriteLiteral(" name=\"dtEnd\"");

WriteLiteral(" id=\"dtEnd\"");

WriteAttribute("value", Tuple.Create(" value=\"", 796), Tuple.Create("\"", 815)
            
            #line 18 "..\..\Views\Shared\_DateRange.cshtml"
, Tuple.Create(Tuple.Create("", 804), Tuple.Create<System.Object, System.Int32>(p["dtEnd"]
            
            #line default
            #line hidden
, 804), false)
);

WriteAttribute("dateformat", Tuple.Create(" dateformat=\"", 816), Tuple.Create("\"", 839)
            
            #line 18 "..\..\Views\Shared\_DateRange.cshtml"
, Tuple.Create(Tuple.Create("", 829), Tuple.Create<System.Object, System.Int32>(formatStr
            
            #line default
            #line hidden
, 829), false)
);

WriteLiteral(" class=\"form-control form_datetime\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" />\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
