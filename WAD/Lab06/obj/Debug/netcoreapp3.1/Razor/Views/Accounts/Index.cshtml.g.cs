#pragma checksum "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb6469417697e255e06843035d01086c2aac238"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb6469417697e255e06843035d01086c2aac238", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0732a54392f73947b16e70f09daef1eceba3d2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab06.Models.Account>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Account List</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Account Name</th>\r\n        <th>Address</th>\r\n        <th>Balance</th>\r\n        <th>Role</th>\r\n        <th>Selected</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Index.cshtml"
           Write(item.AccountName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Index.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Index.cshtml"
           Write(item.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Index.cshtml"
           Write(item.IsAdmin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <input type=\"checkbox\" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\AptechSem3\WAD\WAD\Lab06\Views\Accounts\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <tr>
        <td><input type=""button"" id=""Add"" value=""Add New"" /></td>
        <td></td>
        <td>
        </td>
        <td>
        </td>
        <td>
            <input type=""button"" id=""Edit"" value=""Edit"" /> &nbsp; &nbsp;
            <input type=""submit"" id=""Delete"" value=""Delete"" />
        </td>
    </tr>

</table>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab06.Models.Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591