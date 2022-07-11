#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_Reference.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c8185402afaa5aa7b950044dba966ca1552888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Reference), @"mvc.1.0.view", @"/Views/Shared/_Reference.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c8185402afaa5aa7b950044dba966ca1552888", @"/Views/Shared/_Reference.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Reference : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.ReferenceViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"row reference\">\r\n    <div class=\"title-wrapper\">\r\n        <h1 class=\"title-tab\">");
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_Reference.cshtml"
                         Write(HtmlLocalizer["Reference"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"col-sm-12 full-height\">\r\n        <div class=\"col-md-5 col-lg-3 sm-hidden\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 298, "\"", 320, 1);
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_Reference.cshtml"
WriteAttributeValue("", 304, Model.ImagePath, 304, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 321, "\"", 338, 1);
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_Reference.cshtml"
WriteAttributeValue("", 327, Model.Name, 327, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 339, "\"", 358, 1);
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_Reference.cshtml"
WriteAttributeValue("", 347, Model.Name, 347, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image-responsive\" />\r\n        </div>\r\n        <div class=\"col-sm-12 col-md-7 col-lg-9 quote\">\r\n            <div class=\"text\"><span>&ldquo;</span>");
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_Reference.cshtml"
                                             Write(Html.Raw(Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>&rdquo;</span></div>\r\n            <div class=\"name-and-description\">\r\n                <div class=\"name\">");
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_Reference.cshtml"
                             Write(Html.Raw(Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"description\">");
#nullable restore
#line 15 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Shared\_Reference.cshtml"
                                    Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.ReferenceViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
