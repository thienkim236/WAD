#pragma checksum "D:\AptechSem3\WAD\WAD\Lab8\Views\Customers\_pvMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b24119b684101f2f70bff801e502cc413c990370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers__pvMenu), @"mvc.1.0.view", @"/Views/Customers/_pvMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/_pvMenu.cshtml", typeof(AspNetCore.Views_Customers__pvMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b24119b684101f2f70bff801e502cc413c990370", @"/Views/Customers/_pvMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers__pvMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 62, true);
            WriteLiteral("<div style=\"background-color:coral\" class=\"bg-info\">\r\n    <h3>");
            EndContext();
            BeginContext(63, 54, false);
#line 2 "D:\AptechSem3\WAD\WAD\Lab8\Views\Customers\_pvMenu.cshtml"
   Write(Html.ActionLink("Customer List", "Index", "Customers"));

#line default
#line hidden
            EndContext();
            BeginContext(117, 26, true);
            WriteLiteral("</h3>  \r\n    ||\r\n    <h3> ");
            EndContext();
            BeginContext(144, 52, false);
#line 4 "D:\AptechSem3\WAD\WAD\Lab8\Views\Customers\_pvMenu.cshtml"
    Write(Html.ActionLink("Create new", "Create", "Customers"));

#line default
#line hidden
            EndContext();
            BeginContext(196, 13, true);
            WriteLiteral("</h3>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
