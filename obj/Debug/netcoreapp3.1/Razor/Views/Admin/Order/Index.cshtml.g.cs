#pragma checksum "G:\DACN\dacn\Views\Admin\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52fc94c531572c34f9f8adba90b4e88dcdfd3ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Order_Index), @"mvc.1.0.view", @"/Views/Admin/Order/Index.cshtml")]
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
#line 1 "G:\DACN\dacn\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\DACN\dacn\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\DACN\dacn\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\DACN\dacn\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\DACN\dacn\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\DACN\dacn\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52fc94c531572c34f9f8adba90b4e88dcdfd3ce8", @"/Views/Admin/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table id=""dtBasicExample"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
  <thead>
    <tr>
      <th class=""th-sm text-center"" >#ID
      </th>
      <th class=""th-sm"">Lộ Trình
      </th>
      <th class=""th-sm"">Xe
      </th>
      <th class=""th-sm"">Tổng tiền
      </th>
      <th class=""th-sm text-center"">Thời gian 
      </th>
    </tr>
  </thead>
  <tbody>   
");
#nullable restore
#line 24 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
     foreach (var item in Model )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n          <td>\r\n              ");
#nullable restore
#line 28 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n          <td>\r\n              ");
#nullable restore
#line 31 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
         Write(item.Route.StartPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 31 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
                                  Write(item.Route.EndPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n          <td>\r\n              ");
#nullable restore
#line 34 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
         Write(item.Car.CarCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n          <td>\r\n              ");
#nullable restore
#line 37 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
         Write(item.Amount.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ \r\n          </td>\r\n          <td>\r\n              ");
#nullable restore
#line 40 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
         Write(item.CreatedAt.ToString("d / M / yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n\r\n      </tr>\r\n");
#nullable restore
#line 44 "G:\DACN\dacn\Views\Admin\Order\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n<div>\r\n");
            WriteLiteral("</div>\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css\">\r\n");
            }
            );
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
        <script>
        $(document).ready(function () {
            $('#dtBasicExample').DataTable( 
               {  
                 ""order"": [[ 0, ""desc"" ]],
                  ""columnDefs"": [
                    { ""width"": ""5%"", ""targets"": 0 },
                    { ""width"": ""15%"", ""targets"": 4 },
                  ]
               },
            );
            $('.dataTables_length').addClass('bs-select');
        });

        function detailList(id){
          window.location.href = ""ticket/list/"" + id;
        }
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
