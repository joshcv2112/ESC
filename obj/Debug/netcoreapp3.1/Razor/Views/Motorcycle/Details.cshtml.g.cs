#pragma checksum "C:\code\ESC\Views\Motorcycle\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be53cf24d4b0492e1e7ea01a689e64509e8a1269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Motorcycle_Details), @"mvc.1.0.view", @"/Views/Motorcycle/Details.cshtml")]
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
#line 1 "C:\code\ESC\Views\_ViewImports.cshtml"
using MotoInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\code\ESC\Views\_ViewImports.cshtml"
using MotoInventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be53cf24d4b0492e1e7ea01a689e64509e8a1269", @"/Views/Motorcycle/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a83ba3cccedb70b5cd6e437af67ebba2b2d8d79", @"/Views/_ViewImports.cshtml")]
    public class Views_Motorcycle_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MotoInventory.Models.MotorcycleInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>");
#nullable restore
#line 10 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VINNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 10 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.VINNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 11 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ESCNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 11 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.ESCNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 12 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 12 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 13 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 13 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 14 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 14 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 15 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 15 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 16 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TurnInDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 16 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                        Write(Html.DisplayFor(model => model.TurnInDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 17 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateAcquired));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 17 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.DateAcquired));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 18 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EngineCC));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 18 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                      Write(Html.DisplayFor(model => model.EngineCC));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 19 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteID));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 19 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.SiteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 20 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 20 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.SiteLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 21 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 21 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                           Write(Html.DisplayFor(model => model.PurchasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dt>");
#nullable restore
#line 22 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentValue));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 22 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.CurrentValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be53cf24d4b0492e1e7ea01a689e64509e8a126910402", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vinNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\code\ESC\Views\Motorcycle\Details.cshtml"
                                  WriteLiteral(Model.VINNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vinNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vinNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vinNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be53cf24d4b0492e1e7ea01a689e64509e8a126912551", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MotoInventory.Models.MotorcycleInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
