#pragma checksum "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c57a5891810ba45077d5b3491cf293f29eca676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLastTwoPost_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLastTwoPost/Default.cshtml")]
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
#line 1 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c57a5891810ba45077d5b3491cf293f29eca676", @"/Views/Shared/Components/BlogLastTwoPost/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLastTwoPost_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"tech-btm\">\r\n    <h3>Son Gönderiler</h3>\r\n");
#nullable restore
#line 7 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 258, "\"", 295, 2);
            WriteAttributeValue("", 265, "/Blog/BlogReadAll/", 265, 18, true);
#nullable restore
#line 11 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml"
WriteAttributeValue("", 283, item.BlogID, 283, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 323, "\"", 344, 1);
#nullable restore
#line 12 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml"
WriteAttributeValue("", 329, item.BlogImage, 329, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 376, "\"", 382, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 528, "\"", 565, 2);
            WriteAttributeValue("", 535, "/Blog/BlogReadAll/", 535, 18, true);
#nullable restore
#line 19 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml"
WriteAttributeValue("", 553, item.BlogID, 553, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 19 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml"
                                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i>");
#nullable restore
#line 23 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml"
                                                Write(((DateTime)item.BlogCreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\isikf\OneDrive\Masaüstü\BlogSite\CoreDemo\Views\Shared\Components\BlogLastTwoPost\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
