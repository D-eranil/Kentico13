#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd006fd6913d2dbe47db9d499c44253928a6e9c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cafes_Index), @"mvc.1.0.view", @"/Views/Cafes/Index.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd006fd6913d2dbe47db9d499c44253928a6e9c1", @"/Views/Cafes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cafes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.CafesIndexViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_GoogleMaps", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"cafes-page\">\r\n    <div class=\"row\"><h2>");
#nullable restore
#line 4 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                    Write(HtmlLocalizer["Our cafes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
         foreach (var cafe in Model.CompanyCafes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"cafe-image-tile cursor-hand js-scroll-to-map\" data-address=\"");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                                                                                   Write(cafe.Contact.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                                                                                                      Write(cafe.Contact.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <div class=\"cafe-image-tile-image-wrapper\">\r\n");
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                         if (!string.IsNullOrEmpty(cafe.PhotoPath))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 585, "\"", 606, 1);
#nullable restore
#line 13 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
WriteAttributeValue("", 591, cafe.PhotoPath, 591, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 607, "\"", 631, 1);
#nullable restore
#line 13 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
WriteAttributeValue("", 613, cafe.Contact.Name, 613, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "  title=\"", 632, "\"", 659, 1);
#nullable restore
#line 13 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
WriteAttributeValue("", 641, cafe.Contact.Name, 641, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"cafe-image-tile-image\" />\r\n");
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"cafe-image-tile-content\">\r\n                        <h3 class=\"cafe-image-tile-name\">");
#nullable restore
#line 17 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                                                    Write(cafe.Contact.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <address class=\"cafe-tile-address\">\r\n                            <a href=\"javascript:void(0)\" class=\"cafe-tile-address-anchor\">\r\n                                ");
#nullable restore
#line 20 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                           Write(cafe.Contact.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                                                 Write(cafe.Contact.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />\r\n                                ");
#nullable restore
#line 22 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                           Write(cafe.Contact.ZIP);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 22 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                                              Write(cafe.Contact.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 22 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                                                                     Write(cafe.Contact.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </address>\r\n                        <p>");
#nullable restore
#line 25 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                      Write(cafe.Contact.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 26 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                      Write(cafe.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <h2>");
#nullable restore
#line 33 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
   Write(HtmlLocalizer["Other places where you can drink our coffee"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 35 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
         foreach (var city in Model.PartnerCafes.Keys)
        {
            var first = true;
            foreach (var contact in Model.PartnerCafes[city])
            {
                if (first)
                {
                    var tokens = new string[] { contact.City, contact.Country, contact.State };
                    var address = String.Join(", ", tokens.Where(x => !String.IsNullOrEmpty(x)));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3>");
#nullable restore
#line 44 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                   Write(address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 45 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    ");
#nullable restore
#line 47 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
               Write(contact.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 47 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                              Write(contact.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 47 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                                               Write(contact.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n");
#nullable restore
#line 49 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                first = false;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <h2 class=\"map-title\">");
#nullable restore
#line 54 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Cafes\Index.cshtml"
                     Write(HtmlLocalizer["Find the nearest cafe"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"map js-map\"></div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd006fd6913d2dbe47db9d499c44253928a6e9c112789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.CafesIndexViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
