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
    
    #line 4 "..\..\Views\Shared\_Area1.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
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
    
    #line 1 "..\..\Views\Shared\_Area1.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\_Area1.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_Area1.cshtml"
    using XCode;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Area1.cshtml")]
    public partial class _Views_Shared__Area1_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Area1_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\_Area1.cshtml"
  
    var prefix = (Object)Model + "";
    var page = ViewBag.Page as Pager;

    var areaId = page[prefix + "AreaID"];

            
            #line default
            #line hidden
WriteLiteral("\r\n<link");

WriteAttribute("href", Tuple.Create(" href=\"", 208), Tuple.Create("\"", 252)
, Tuple.Create(Tuple.Create("", 215), Tuple.Create<System.Object, System.Int32>(Href("~/Content/city-picker/city-picker.css")
, 215), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" style=\"position:relative\"");

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n    <div>\r\n        <input readonly");

WriteLiteral(" type=\"text\"");

WriteAttribute("id", Tuple.Create(" id=\"", 435), Tuple.Create("\"", 455)
            
            #line 15 "..\..\Views\Shared\_Area1.cshtml"
, Tuple.Create(Tuple.Create("", 440), Tuple.Create<System.Object, System.Int32>(prefix
            
            #line default
            #line hidden
, 440), false)
, Tuple.Create(Tuple.Create("", 449), Tuple.Create("AreaID", 449), true)
);

WriteAttribute("value", Tuple.Create(" value=\"", 456), Tuple.Create("\"", 471)
            
            #line 15 "..\..\Views\Shared\_Area1.cshtml"
, Tuple.Create(Tuple.Create("", 464), Tuple.Create<System.Object, System.Int32>(areaId
            
            #line default
            #line hidden
, 464), false)
);

WriteLiteral(" data-toggle=\"city-picker\"");

WriteLiteral(" placeholder=\"请选择省\"");

WriteLiteral(" data-level=\"province\"");

WriteLiteral(">\r\n    </div>\r\n</div>\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 569), Tuple.Create("\"", 611)
, Tuple.Create(Tuple.Create("", 575), Tuple.Create<System.Object, System.Int32>(Href("~/Content/city-picker/city-picker.js")
, 575), false)
);

WriteLiteral("></script>\r\n<script>\r\n    $.fn.citypicker.Constructor.DEFAULTS.dataUrl = \'/Cube/A" +
"reaChilds?id=\';\r\n    $.fn.citypicker.Constructor.DEFAULTS.areaParents = \'/Cube/A" +
"reaParents?id=\';\r\n</script>");

        }
    }
}
#pragma warning restore 1591