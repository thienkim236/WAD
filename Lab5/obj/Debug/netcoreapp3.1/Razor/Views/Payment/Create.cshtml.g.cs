#pragma checksum "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b23875a3cf8b914fb33c2e59f9253f11e5b46fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Create), @"mvc.1.0.view", @"/Views/Payment/Create.cshtml")]
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
#line 1 "D:\AptechSem3\WAD\Lab5\Views\_ViewImports.cshtml"
using Lab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AptechSem3\WAD\Lab5\Views\_ViewImports.cshtml"
using Lab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b23875a3cf8b914fb33c2e59f9253f11e5b46fe", @"/Views/Payment/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de5c7a10af704975369c03e51a68b1f930a79786", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab5.Models.Payment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   ViewData["Title"] = "Create"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Edit Payment</h2>\n<p>\n    <h3>");
#nullable restore
#line 6 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n</p>\n<br />\n");
#nullable restore
#line 9 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <div>\n        ");
#nullable restore
#line 13 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.LabelFor(model => model.PaymentCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 14 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.EditorFor(model => model.PaymentCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 15 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.PaymentCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div>\n        ");
#nullable restore
#line 18 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.LabelFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 19 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.EditorFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 20 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div>\n        ");
#nullable restore
#line 23 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.LabelFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 24 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.EditorFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 25 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div>\n        ");
#nullable restore
#line 28 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.LabelFor(model => model.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 29 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.EditorFor(model => model.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 30 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div>\n        ");
#nullable restore
#line 33 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.LabelFor(model => model.Fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 34 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.EditorFor(model => model.Fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 35 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <br />\n    <div>\n        <input type=\"submit\" value=\"Create\" class=\"btn-success\" />\n    </div>\n</div>");
#nullable restore
#line 41 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<div>\n    ");
#nullable restore
#line 44 "D:\AptechSem3\WAD\Lab5\Views\Payment\Create.cshtml"
Write(Html.ActionLink("Back to list", "Index", "Payment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab5.Models.Payment> Html { get; private set; }
    }
}
#pragma warning restore 1591