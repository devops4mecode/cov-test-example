//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    
    #line 1 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
    using Coverity.Security;
    
    #line default
    #line hidden
    
    public class _Page_Views_Example_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
#line hidden
        public _Page_Views_Example_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 3 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
  
    ViewBag.Title = "Index";

            
            #line default
            #line hidden
WriteLiteral("\n\n\n<div");

WriteAttribute("data", Tuple.Create(" data=\"", 67), Tuple.Create("\"", 92)
            
            #line 8 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
, Tuple.Create(Tuple.Create("", 74), Tuple.Create<System.Object, System.Int32>(ViewBag.Attribute
            
            #line default
            #line hidden
, 74), false)
);

WriteLiteral(">\n    Hello ");

            
            #line 9 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
     Write(Cov.HtmlText(ViewBag.Name));

            
            #line default
            #line hidden
WriteLiteral(". \n</div>\n\n<a");

WriteAttribute("href", Tuple.Create(" href=\"", 145), Tuple.Create("\"", 175)
            
            #line 12 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
, Tuple.Create(Tuple.Create("", 152), Tuple.Create<System.Object, System.Int32>(Cov.AsURL(ViewBag.Url)
            
            #line default
            #line hidden
, 152), false)
);

WriteLiteral(">\n  Click me\n</a>\n\n<a");

WriteAttribute("style", Tuple.Create(" style=\"", 197), Tuple.Create("\"", 247)
, Tuple.Create(Tuple.Create("", 205), Tuple.Create("font-family:\'", 205), true)
            
            #line 16 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
, Tuple.Create(Tuple.Create("", 218), Tuple.Create<System.Object, System.Int32>(Cov.CssString(ViewBag.Font)
            
            #line default
            #line hidden
, 218), false)
, Tuple.Create(Tuple.Create("", 246), Tuple.Create("\'", 246), true)
);

WriteLiteral(">\n  Click me\n</a>\n\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\n  var str = \'");

            
            #line 21 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
        Write(Cov.JsString(ViewBag.JsString));

            
            #line default
            #line hidden
WriteLiteral("\';\n  // Do something with the string `str`\n</script>\n\n<div");

WriteLiteral(" id=\"forMyContent\"");

WriteLiteral("></div>\n<script>\n    var foo = \"<h1>");

            
            #line 27 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
              Write(Cov.JsString(Cov.Html(ViewBag.JsString)));

            
            #line default
            #line hidden
WriteLiteral("</h1>\";\n    $(\"#forMyContent\").html(foo);\n</script>\n\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\n    var num = ");

            
            #line 32 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
         Write(Cov.AsNumber(ViewBag.Number));

            
            #line default
            #line hidden
WriteLiteral(";\n    // Do something with the number `num`\n</script>\n\n<style>\n  #foo[id ~= \'");

            
            #line 37 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
         Write(Cov.CssString(ViewBag.CssID));

            
            #line default
            #line hidden
WriteLiteral("\'] {\n    background-color: pink !important;\n  }\n</style>\n\n<style>\n  #foo {\n    ba" +
"ckground: url(\'");

            
            #line 44 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
                Write(Cov.CssString(ViewBag.BackgroundUrl));

            
            #line default
            #line hidden
WriteLiteral("\');\n  }\n</style>\n\n<style>\n  #foo {\n    background-color: ");

            
            #line 50 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
                 Write(Cov.AsCssColor(ViewBag.BackgroundColour));

            
            #line default
            #line hidden
WriteLiteral(";\n  }\n</style>\n\n<a");

WriteAttribute("href", Tuple.Create(" href=\"", 979), Tuple.Create("\"", 1025)
, Tuple.Create(Tuple.Create("", 986), Tuple.Create("/path/page?elmt=1#", 986), true)
            
            #line 54 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1004), Tuple.Create<System.Object, System.Int32>(ViewBag.LinkFragment
            
            #line default
            #line hidden
, 1004), false)
);

WriteLiteral(">\n  Link name\n</a>\n\n<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1048), Tuple.Create("\"", 1127)
, Tuple.Create(Tuple.Create("", 1055), Tuple.Create("http://example.com/path/?", 1055), true)
            
            #line 58 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1080), Tuple.Create<System.Object, System.Int32>(Cov.Uri(ViewBag.Name)
            
            #line default
            #line hidden
, 1080), false)
, Tuple.Create(Tuple.Create("", 1102), Tuple.Create("=", 1102), true)
            
            #line 58 "C:\Users\radzuan-1\OneDrive - Mettler Toledo LLC\Codes\coverity-security-library-.net-develop\Coverity.Security\Coverity.Security.Example\Views\Example\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1103), Tuple.Create<System.Object, System.Int32>(Cov.Uri(ViewBag.Number)
            
            #line default
            #line hidden
, 1103), false)
);

WriteLiteral(">\n  Click me\n</a>");

        }
    }
}
