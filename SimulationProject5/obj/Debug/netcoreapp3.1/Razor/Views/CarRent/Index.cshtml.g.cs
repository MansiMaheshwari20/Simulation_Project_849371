#pragma checksum "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a107b1366ee95e3ae463f2810fa888e4998a308"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarRent_Index), @"mvc.1.0.view", @"/Views/CarRent/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\_ViewImports.cshtml"
using SimulationProject5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\_ViewImports.cshtml"
using SimulationProject5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a107b1366ee95e3ae463f2810fa888e4998a308", @"/Views/CarRent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fa2a5741ada630f22168eb78962786fe00f0ac", @"/Views/_ViewImports.cshtml")]
    public class Views_CarRent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.RentalCar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
  
    ViewData["Title"] = "Index";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 13 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
       Write(Html.DisplayNameFor(m => m.Nameclient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
       Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
       Write(Html.DisplayNameFor(m => m.Adhar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n       \r\n\r\n        <th>\r\n            ");
#nullable restore
#line 24 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
       Write(Html.DisplayNameFor(m => m.Car.CartypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n       \r\n    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
           Write(Html.DisplayFor(m => item.Nameclient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
           Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
           Write(Html.DisplayFor(m => item.Adhar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
           Write(Html.DisplayFor(m => item.Car.CartypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\mansi\source\repos\SimulationProject5\SimulationProject5\Views\CarRent\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.RentalCar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
