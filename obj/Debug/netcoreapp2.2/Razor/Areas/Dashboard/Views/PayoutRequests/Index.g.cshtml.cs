#pragma checksum "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50fe7046ab738beb13601c88787662b270b27bb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_PayoutRequests_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/PayoutRequests/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Dashboard/Views/PayoutRequests/Index.cshtml", typeof(AspNetCore.Areas_Dashboard_Views_PayoutRequests_Index))]
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
#line 1 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\_ViewImports.cshtml"
using LinkShortener;

#line default
#line hidden
#line 2 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\_ViewImports.cshtml"
using LinkShortener.Models;

#line default
#line hidden
#line 3 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50fe7046ab738beb13601c88787662b270b27bb1", @"/Areas/Dashboard/Views/PayoutRequests/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff29dd782d6cf8cb37ef964f68d8cfa2ac8b538", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_PayoutRequests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LinkShortener.Models.PayoutRequest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
  
    ViewData["Title"] = @Localizer["Payouts"];

#line default
#line hidden
            BeginContext(197, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(204, 20, false);
#line 11 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
Write(Localizer["Payouts"]);

#line default
#line hidden
            EndContext();
            BeginContext(224, 93, true);
            WriteLiteral("</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(318, 41, false);
#line 17 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Money));

#line default
#line hidden
            EndContext();
            BeginContext(359, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(415, 40, false);
#line 20 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Paid));

#line default
#line hidden
            EndContext();
            BeginContext(455, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(590, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(651, 40, false);
#line 30 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Money));

#line default
#line hidden
            EndContext();
            BeginContext(691, 84, true);
            WriteLiteral("\r\n                </td>\r\n               \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(776, 39, false);
#line 34 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Paid));

#line default
#line hidden
            EndContext();
            BeginContext(815, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Users\husey\source\repos\LinkShortener\LinkShortener\Areas\Dashboard\Views\PayoutRequests\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(870, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LinkShortener.Models.PayoutRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591
