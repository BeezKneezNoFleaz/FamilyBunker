#pragma checksum "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff4e7959cf05b4dd3d842811118f1052fb1a12e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calendars_Details), @"mvc.1.0.view", @"/Views/Calendars/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calendars/Details.cshtml", typeof(AspNetCore.Views_Calendars_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff4e7959cf05b4dd3d842811118f1052fb1a12e", @"/Views/Calendars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d113e47824f38b55b696e3f5ec44179c35d8d2d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Calendars_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FamilyBunker.Entities.Calendar>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Calendar</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(207, 45, false);
#line 14 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.eventName));

#line default
#line hidden
            EndContext();
            BeginContext(252, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(296, 41, false);
#line 17 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
       Write(Html.DisplayFor(model => model.eventName));

#line default
#line hidden
            EndContext();
            BeginContext(337, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(381, 40, false);
#line 20 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
            EndContext();
            BeginContext(421, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(465, 36, false);
#line 23 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
       Write(Html.DisplayFor(model => model.date));

#line default
#line hidden
            EndContext();
            BeginContext(501, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(545, 45, false);
#line 26 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.startTime));

#line default
#line hidden
            EndContext();
            BeginContext(590, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(634, 41, false);
#line 29 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
       Write(Html.DisplayFor(model => model.startTime));

#line default
#line hidden
            EndContext();
            BeginContext(675, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(719, 43, false);
#line 32 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.endTime));

#line default
#line hidden
            EndContext();
            BeginContext(762, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(806, 39, false);
#line 35 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
       Write(Html.DisplayFor(model => model.endTime));

#line default
#line hidden
            EndContext();
            BeginContext(845, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(892, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5654b5aabb18449d8ce23c6208c7a1c4", async() => {
                BeginContext(946, 4, true);
                WriteLiteral("Edit");
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
#line 40 "C:\Users\Frank\source\repos\FamilyBunker\FamilyBunker\Views\Calendars\Details.cshtml"
                           WriteLiteral(Model.calendarId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(954, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(962, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f6a9ac937554e93aa0a2f30fa3308df", async() => {
                BeginContext(984, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1000, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FamilyBunker.Entities.Calendar> Html { get; private set; }
    }
}
#pragma warning restore 1591
