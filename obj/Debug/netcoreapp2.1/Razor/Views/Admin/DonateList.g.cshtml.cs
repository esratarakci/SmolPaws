#pragma checksum "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b98b9a2f5cea7917240f6ae215ce63524e2e6aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DonateList), @"mvc.1.0.view", @"/Views/Admin/DonateList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DonateList.cshtml", typeof(AspNetCore.Views_Admin_DonateList))]
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
#line 1 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\_ViewImports.cshtml"
using SmolPaws;

#line default
#line hidden
#line 2 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\_ViewImports.cshtml"
using SmolPaws.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b98b9a2f5cea7917240f6ae215ce63524e2e6aa", @"/Views/Admin/DonateList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c39b5cc9dbfd9841f1d1717d146278a9cf22e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DonateList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Donate>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml"
  
    ViewData["Title"] = "AdminIndex";

#line default
#line hidden
            BeginContext(74, 291, true);
            WriteLiteral(@"

<table class=""table table-dark"">
    <thead>
        <tr>
            <th scope=""col"">DonateId</th>
            <th scope=""col"">Firstname Lastname</th>
            <th scope=""col"">Address</th>
            <th scope=""col"">Donation </th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 18 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml"
         foreach (var u in Model)
        {

#line default
#line hidden
            BeginContext(411, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(442, 10, false);
#line 21 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml"
           Write(u.DonateId);

#line default
#line hidden
            EndContext();
            BeginContext(452, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(476, 6, false);
#line 22 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml"
           Write(u.Name);

#line default
#line hidden
            EndContext();
            BeginContext(482, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(484, 10, false);
#line 22 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml"
                   Write(u.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(494, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(518, 9, false);
#line 23 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml"
           Write(u.Address);

#line default
#line hidden
            EndContext();
            BeginContext(527, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(551, 10, false);
#line 24 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml"
           Write(u.Donation);

#line default
#line hidden
            EndContext();
            BeginContext(561, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 26 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\DonateList.cshtml"
        }

#line default
#line hidden
            BeginContext(594, 25, true);
            WriteLiteral("    </tbody>\r\n\r\n</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Donate>> Html { get; private set; }
    }
}
#pragma warning restore 1591