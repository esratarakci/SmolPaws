#pragma checksum "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e6adc37b5a2c487ae3ed4b60959da79a9d92de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UserList.cshtml", typeof(AspNetCore.Views_Admin_UserList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e6adc37b5a2c487ae3ed4b60959da79a9d92de", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c39b5cc9dbfd9841f1d1717d146278a9cf22e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
  
    ViewData["Title"] = "AdminIndex";

#line default
#line hidden
            BeginContext(72, 368, true);
            WriteLiteral(@"

<table class=""table table-dark"">
    <thead>
        <tr>
            <th scope=""col"">UserId</th>
            <th scope=""col"">UserName</th>
            <th scope=""col"">Firstname Lastname</th>
            <th scope=""col"">E-Mail</th>
            <th scope=""col"">Admin</th>
            <th scope=""col"">DELETE</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 20 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
         foreach (var u in Model)
        {

#line default
#line hidden
            BeginContext(486, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(517, 8, false);
#line 23 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
           Write(u.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(525, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(549, 10, false);
#line 24 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
           Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(559, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(583, 11, false);
#line 25 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
           Write(u.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(594, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(596, 10, false);
#line 25 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
                        Write(u.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(606, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(630, 7, false);
#line 26 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
           Write(u.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(637, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(661, 9, false);
#line 27 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
           Write(u.IsAdmin);

#line default
#line hidden
            EndContext();
            BeginContext(670, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(693, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d506dd25a22443b9399c899f232b39b", async() => {
                BeginContext(769, 1, true);
                WriteLiteral("X");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
                                             WriteLiteral(u.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(774, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\asus\Desktop\Mehmet_Burak_Deveci_SmolPaws\SmolPaws\Views\Admin\UserList.cshtml"
        }

#line default
#line hidden
            BeginContext(807, 25, true);
            WriteLiteral("    </tbody>\r\n</table> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591