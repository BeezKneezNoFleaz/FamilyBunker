#pragma checksum "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0918533c680d480edf714550c67fa923c3a6d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccessDenied), @"mvc.1.0.view", @"/Views/Account/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/AccessDenied.cshtml", typeof(AspNetCore.Views_Account_AccessDenied))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0918533c680d480edf714550c67fa923c3a6d2", @"/Views/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d113e47824f38b55b696e3f5ec44179c35d8d2d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access Denied";

#line default
#line hidden
            BeginContext(46, 140, true);
            WriteLiteral("\n<header>\n    <h1 class=\"text-danger\">Access Denied.</h1>\n    <p class=\"text-danger\">You do not have access to this resource.</p>\n</header>\n");
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
