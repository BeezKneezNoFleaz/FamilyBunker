#pragma checksum "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Manage\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc3401dc25c92c244ad746a67c121f28e99ac710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ListUsers), @"mvc.1.0.view", @"/Views/Manage/ListUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ListUsers.cshtml", typeof(AspNetCore.Views_Manage_ListUsers))]
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
#line 1 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\_ViewImports.cshtml"
using FamilyBunker;

#line default
#line hidden
#line 3 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\_ViewImports.cshtml"
using FamilyBunker.Models;

#line default
#line hidden
#line 4 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\_ViewImports.cshtml"
using FamilyBunker.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\_ViewImports.cshtml"
using FamilyBunker.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3401dc25c92c244ad746a67c121f28e99ac710", @"/Views/Manage/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d113e47824f38b55b696e3f5ec44179c35d8d2d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(39, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Manage\ListUsers.cshtml"
   
    ViewBag.Title = "All Users";

#line default
#line hidden
            BeginContext(87, 26, true);
            WriteLiteral("\r\n<h1>All Users</h1>\r\n\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Manage\ListUsers.cshtml"
 if (Model.Any())
{

    foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(177, 90, true);
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                User Id: ");
            EndContext();
            BeginContext(268, 7, false);
#line 20 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Manage\ListUsers.cshtml"
                    Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(275, 27, true);
            WriteLiteral("\r\n                User Id: ");
            EndContext();
            BeginContext(303, 13, false);
#line 21 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Manage\ListUsers.cshtml"
                    Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(316, 27, true);
            WriteLiteral("\r\n                User Id: ");
            EndContext();
            BeginContext(344, 10, false);
#line 22 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Manage\ListUsers.cshtml"
                    Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(354, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 25 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Manage\ListUsers.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(443, 174, true);
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        No Users created yet\r\n    </div>\r\n\r\n    <div class=\"card-body\">\r\n        No Users created yet\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 38 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Manage\ListUsers.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
