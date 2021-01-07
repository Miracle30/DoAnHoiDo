#pragma checksum "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ffc9b2a564678f9e74ce30fc01bdcc163f6b73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Ticket_Index), @"mvc.1.0.view", @"/Views/Admin/Ticket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ffc9b2a564678f9e74ce30fc01bdcc163f6b73", @"/Views/Admin/Ticket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2742364a0d474ea9e7a485c00f6e7b84d29552e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TicketViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Ticket";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
      <th class=""th-sm"">Phone
      </th>
      <th class=""th-sm text-center"">Thời gian 
      </th>
    </tr>
  </thead>
  <tbody>   
");
#nullable restore
#line 24 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
      foreach (var item in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 536, "\"", 568, 3);
            WriteAttributeValue("", 546, "detailList(\'", 546, 12, true);
#nullable restore
#line 26 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
WriteAttributeValue("", 558, item.Id, 558, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 566, "\')", 566, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\">\n          <td class=\"text-center\">");
#nullable restore
#line 27 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\n          <td>");
#nullable restore
#line 28 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
         Write(item.RouteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 29 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
         Write(item.CarCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 30 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
         Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 31 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
         Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      </tr>\n");
#nullable restore
#line 33 "T:\carbooking_netcore-master\Views\Admin\Ticket\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\n</table>\n");
            DefineSection("Css", async() => {
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css\">\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TicketViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
