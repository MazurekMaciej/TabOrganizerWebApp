#pragma checksum "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\Container\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77d9dfbef815beabaf43e5d59180d53196d52de5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Container_Index), @"mvc.1.0.view", @"/Views/Container/Index.cshtml")]
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
#line 1 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\_ViewImports.cshtml"
using TabOrganizer___WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\_ViewImports.cshtml"
using TabOrganizer___WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d9dfbef815beabaf43e5d59180d53196d52de5", @"/Views/Container/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8d54a01ac1485470cd6f6d8a658f4e8e712d4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Container_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TabOrganizer___WebApp.Models.Container>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "container", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\Container\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Containers</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77d9dfbef815beabaf43e5d59180d53196d52de54451", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 13 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\Container\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- Card -->\r\n    <div class=\"card promoting-card\">\r\n\r\n        <!-- Card content -->\r\n        <div class=\"card-body d-flex flex-row\">\r\n\r\n            <!-- Avatar -->\r\n");
            WriteLiteral("\r\n            <!-- Content -->\r\n            <div>\r\n\r\n                <!-- Title -->\r\n                <h4 class=\"card-title font-weight-bold mb-2\">");
#nullable restore
#line 28 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\Container\Index.cshtml"
                                                        Write(product.Name.Substring(0, Math.Min(product.Name.Length, 17)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <!-- Subtitle -->\r\n                <p class=\"card-text\"><i class=\"far fa-clock pr-2\"></i>");
#nullable restore
#line 30 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\Container\Index.cshtml"
                                                                 Write(product.DateCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\"><i class=\"far fa-clock pr-2\"></i>Websites: ");
#nullable restore
#line 31 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\Container\Index.cshtml"
                                                                           Write(product.Websites.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <!-- Card image -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77d9dfbef815beabaf43e5d59180d53196d52de57598", async() => {
                WriteLiteral("\r\n            <div class=\"view overlay\">\r\n");
                WriteLiteral("                <div class=\"card-img-top\">\r\n                    <p class=\"card-text\">");
#nullable restore
#line 41 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\Container\Index.cshtml"
                                    Write(product.Description.Substring(0, Math.Min(product.Description.Length, 183)));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n");
                WriteLiteral("            </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <!-- Card content -->\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n            <!-- Text -->\r\n");
            WriteLiteral("            <!-- Button -->\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    </div>\r\n        <!-- Card -->\r\n");
#nullable restore
#line 65 "D:\.NET projects\TabOrganizer - WebApp\TabOrganizer - WebApp\TabOrganizer - WebApp\Views\Container\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TabOrganizer___WebApp.Models.Container>> Html { get; private set; }
    }
}
#pragma warning restore 1591
