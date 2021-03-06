#pragma checksum "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ae22a98d5946eb1a657d1d950964261bc2c6f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderList), @"mvc.1.0.view", @"/Views/Home/OrderList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OrderList.cshtml", typeof(AspNetCore.Views_Home_OrderList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ae22a98d5946eb1a657d1d950964261bc2c6f2", @"/Views/Home/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab8.Models.CustomerOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";

#line default
#line hidden
            BeginContext(92, 297, true);
            WriteLiteral(@"
<h2>Order List</h2>

<table class=""table"">
    <tr>
        <th>OrderID</th>
        <th>OrderDate</th>
        <th>CustomerName</th>
        <th>CustomerAddress</th>
        <th>ProductName</th>
        <th>UnitPrice</th>
        <th>Quantity</th>
        <th>Total</th>
    </tr>
");
            EndContext();
#line 19 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(430, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(453, 13, false);
#line 22 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
       Write(item.Order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(466, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(486, 20, false);
#line 23 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
       Write(item.Order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(506, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(526, 26, false);
#line 24 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
       Write(item.Customer.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(552, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(572, 29, false);
#line 25 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
       Write(item.Customer.CustomerAddress);

#line default
#line hidden
            EndContext();
            BeginContext(601, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(621, 22, false);
#line 26 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
       Write(item.Order.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(643, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(663, 16, false);
#line 27 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
       Write(item.Order.Price);

#line default
#line hidden
            EndContext();
            BeginContext(679, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(699, 19, false);
#line 28 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
       Write(item.Order.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(718, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(738, 19, false);
#line 29 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
       Write(item.Order.SubTotal);

#line default
#line hidden
            EndContext();
            BeginContext(757, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 31 "D:\AptechSem3\WAD\WAD\Lab8\Views\Home\OrderList.cshtml"
    }

#line default
#line hidden
            BeginContext(782, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab8.Models.CustomerOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
