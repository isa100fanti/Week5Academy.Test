#pragma checksum "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\Dish\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e2a1d189d5d1a3ad2a2f9c765f68ac2471957bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Delete), @"mvc.1.0.view", @"/Views/Dish/Delete.cshtml")]
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
#line 1 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\_ViewImports.cshtml"
using Week5Academy.Esercitazione.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\_ViewImports.cshtml"
using Week5Academy.Esercitazione.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\_ViewImports.cshtml"
using Week5Academy.Esercitazione.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e2a1d189d5d1a3ad2a2f9c765f68ac2471957bc", @"/Views/Dish/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82e566228ee30074b2ff8c2ff0c2821b9d19b28b", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\Dish\Delete.cshtml"
   ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DELETE a DISH</h1>\r\n\r\n\r\n<div>\r\n    <h3>Dish #");
#nullable restore
#line 8 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\Dish\Delete.cshtml"
         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            Course Name\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 14 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\Dish\Delete.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            Description\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 20 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\Dish\Delete.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            Type courses\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 26 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\Dish\Delete.cshtml"
       Write(Model.TypeCourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            Price\r\n        </dt>\r\n        <dt class=\"col-sm-3\">\r\n            ");
#nullable restore
#line 32 "C:\Users\isabella.centofanti\source\repos\ACADEMY\Week5Academy.Esercitazione.RistoranteMVC\Week5Academy.Esercitazione.MVC\Views\Dish\Delete.cshtml"
       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
