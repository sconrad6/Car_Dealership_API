#pragma checksum "C:\Users\sibgy\source\repos\Car_Dealership_API\Car_Dealership\Views\Car\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe52e8fe43930b7d53cc6a09433f03327a1e8d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Result), @"mvc.1.0.view", @"/Views/Car/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Car/Result.cshtml", typeof(AspNetCore.Views_Car_Result))]
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
#line 1 "C:\Users\sibgy\source\repos\Car_Dealership_API\Car_Dealership\Views\_ViewImports.cshtml"
using Car_Dealership;

#line default
#line hidden
#line 2 "C:\Users\sibgy\source\repos\Car_Dealership_API\Car_Dealership\Views\_ViewImports.cshtml"
using Car_Dealership.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe52e8fe43930b7d53cc6a09433f03327a1e8d1", @"/Views/Car/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb73c5ae3e9a9816af5823adfe7947f33dea50b", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car_Dealership.Models.Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\sibgy\source\repos\Car_Dealership_API\Car_Dealership\Views\Car\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
            BeginContext(44, 21, true);
            WriteLiteral("\r\n<h1>Result</h1>\r\n\r\n");
            EndContext();
            BeginContext(99, 166, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Make</td>\r\n        <td>Model</td>\r\n        <td>Year</td>\r\n        <td>Color</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(266, 10, false);
#line 20 "C:\Users\sibgy\source\repos\Car_Dealership_API\Car_Dealership\Views\Car\Result.cshtml"
       Write(Model.Make);

#line default
#line hidden
            EndContext();
            BeginContext(276, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(296, 11, false);
#line 21 "C:\Users\sibgy\source\repos\Car_Dealership_API\Car_Dealership\Views\Car\Result.cshtml"
       Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(307, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(327, 10, false);
#line 22 "C:\Users\sibgy\source\repos\Car_Dealership_API\Car_Dealership\Views\Car\Result.cshtml"
       Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(337, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(357, 11, false);
#line 23 "C:\Users\sibgy\source\repos\Car_Dealership_API\Car_Dealership\Views\Car\Result.cshtml"
       Write(Model.Color);

#line default
#line hidden
            EndContext();
            BeginContext(368, 28, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car_Dealership.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
