#pragma checksum "T:\carbooking_netcore-master\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef41f9fb78032f83ba9c3887535649a55c96f2c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "T:\carbooking_netcore-master\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "T:\carbooking_netcore-master\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "T:\carbooking_netcore-master\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "T:\carbooking_netcore-master\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "T:\carbooking_netcore-master\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "T:\carbooking_netcore-master\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef41f9fb78032f83ba9c3887535649a55c96f2c0", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2742364a0d474ea9e7a485c00f6e7b84d29552e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "T:\carbooking_netcore-master\Views\Blog\Detail.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Tin tức";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Main -->\n\n<div class=\"container\" style=\"margin-top:70px\">\n     <h2 class=\"about__heading display-4 my-5 py-3\">\n        ");
#nullable restore
#line 10 "T:\carbooking_netcore-master\Views\Blog\Detail.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h2>

<div id=""blog-content"" class=""card card-cascade wider reverse mb-5"">
 
  <!-- Card image -->
  <div class=""view view-cascade overlay"">
    <img class=""card-img-top"" src=""https://mdbootstrap.com/img/Photos/Slides/img%20(70).jpg""
      alt=""Card image cap"">
    <a href=""#!"">
      <div class=""mask rgba-white-slight""></div>
    </a>
  </div>

  <!-- Card content -->
  <div class=""card-body card-body-cascade text-center mb-5"">

    <!-- Title -->
    <strong>20/12/2020</strong>
    <!-- Subtitle -->
    <!-- Text -->
    <p class=""card-text"">
        ");
#nullable restore
#line 32 "T:\carbooking_netcore-master\Views\Blog\Detail.cshtml"
   Write(Html.Raw(@Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n    <div class=\"content\">\n        ");
#nullable restore
#line 35 "T:\carbooking_netcore-master\Views\Blog\Detail.cshtml"
   Write(Html.Raw(@Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n  </div>\n</div>\n</div>\n<!-- Card -->\n\n");
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <style>
        #blog-content p{
            font-size: 14px !important;
        }
        #blog-content h4{
            font-size: 20px !important;
        }
        #blog-content h6{
            font-size: 18px !important;
        }

        .pagination a{
            font-size: 16px !important;
        }
    </style>
");
            }
            );
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
