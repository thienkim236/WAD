#pragma checksum "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "394ef91d7a7e5b1d3d485d8eb242fd4c3cdd041c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Create), @"mvc.1.0.view", @"/Views/Accounts/Create.cshtml")]
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
#line 1 "D:\AptechSem3\WAD\WAD\Lab06\Views\_ViewImports.cshtml"
using Lab06;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AptechSem3\WAD\WAD\Lab06\Views\_ViewImports.cshtml"
using Lab06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"394ef91d7a7e5b1d3d485d8eb242fd4c3cdd041c", @"/Views/Accounts/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0732a54392f73947b16e70f09daef1eceba3d2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab06.Models.Account>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create new account</h2>\r\n<p>\r\n    <h3>");
#nullable restore
#line 8 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</p>\r\n<br/>\r\n");
#nullable restore
#line 11 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div>\r\n        ");
#nullable restore
#line 15 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.AccountCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.EditorFor(model => model.AccountCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.AccountCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 20 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.EditorFor(model => model.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.AccountName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 25 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.EditorFor(model => model.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 30 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 31 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.EditorFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 35 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 36 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.EditorFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 37 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 40 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.IsAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 41 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.EditorFor(model => model.IsAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 42 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.IsAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div>\r\n        <input type=\"submit\" value=\"Create\" class=\"btn-primary\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 49 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab06.Models.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591