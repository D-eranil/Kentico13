#pragma checksum "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Product\DisplayTemplates\ElectricGrinderViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6358d45707f10d40cf32b96752d9f4447b158c5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DisplayTemplates_ElectricGrinderViewModel), @"mvc.1.0.view", @"/Views/Product/DisplayTemplates/ElectricGrinderViewModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6358d45707f10d40cf32b96752d9f4447b158c5c", @"/Views/Product/DisplayTemplates/ElectricGrinderViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_DisplayTemplates_ElectricGrinderViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.ElectricGrinderViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product-detail-properties\">\r\n    <h4>");
#nullable restore
#line 4 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Product\DisplayTemplates\ElectricGrinderViewModel.cshtml"
   Write(HtmlLocalizer["Parameters"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-xs-12 col-sm-4\">");
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Product\DisplayTemplates\ElectricGrinderViewModel.cshtml"
                                  Write(HtmlLocalizer["Power"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-xs-12 col-sm-8\">");
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13\DancingGoatCore\Views\Product\DisplayTemplates\ElectricGrinderViewModel.cshtml"
                                  Write(string.Format("{0}W", Model.Power));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.ElectricGrinderViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
