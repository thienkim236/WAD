#pragma checksum "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6853e26ebdea007a90f209e0a5f557f8ebc24a3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Create), @"mvc.1.0.view", @"/Views/Orders/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Create.cshtml", typeof(AspNetCore.Views_Orders_Create))]
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
#line 1 "D:\AptechSem3\WAD\WAD\Lab8\Views\_ViewImports.cshtml"
using Lab8;

#line default
#line hidden
#line 2 "D:\AptechSem3\WAD\WAD\Lab8\Views\_ViewImports.cshtml"
using Lab8.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6853e26ebdea007a90f209e0a5f557f8ebc24a3d", @"/Views/Orders/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(68, 35, true);
            WriteLiteral("<h1>Create new Order</h1>\r\n<br />\r\n");
            EndContext();
#line 7 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(133, 38, true);
            WriteLiteral("    <div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(172, 39, false);
#line 11 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.LabelFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(211, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(226, 40, false);
#line 12 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.EditorFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(266, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(312, 41, false);
#line 15 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.LabelFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(353, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(368, 42, false);
#line 16 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.EditorFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(410, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(456, 35, false);
#line 19 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.LabelFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(491, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(506, 36, false);
#line 20 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.EditorFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(542, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(588, 38, false);
#line 23 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.LabelFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(626, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(641, 39, false);
#line 24 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.EditorFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(680, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(726, 58, false);
#line 27 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.LabelFor(model => model.CustomerCode, "CustomerName"));

#line default
#line hidden
            EndContext();
            BeginContext(784, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(799, 95, false);
#line 28 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"
       Write(Html.DropDownListFor(model => model.CustomerCode, (IEnumerable<SelectListItem>)ViewBag.cusName));

#line default
#line hidden
            EndContext();
            BeginContext(894, 163, true);
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div>\r\n            <input type=\"submit\" name=\"Submit\" value=\"Create\" class=\"btn-primary\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 35 "D:\AptechSem3\WAD\WAD\Lab8\Views\Orders\Create.cshtml"

}

#line default
#line hidden
            BeginContext(1062, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
