#pragma checksum "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310b232b7220e7cdd6780e166b91407f33e5125c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Car_Create), @"mvc.1.0.view", @"/Views/Admin/Car/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310b232b7220e7cdd6780e166b91407f33e5125c", @"/Views/Admin/Car/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2742364a0d474ea9e7a485c00f6e7b84d29552e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Car_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger text-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:16px;margin-top:20px; padding:0 15px;border:0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("defaultSubscriptionFormPassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Biển số xe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Thông báo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exampleFormControlTextarea3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("defaultSubscriptionFormSeatNumber"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Số ghế"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center border border-light p-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/car/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_19 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Employee";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Thêm mới Xe</h4>\n\n<!-- Default form subscription --> \n <div class=\"row\">\n     <div class=\"col-md-6 mx-auto\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310b232b7220e7cdd6780e166b91407f33e5125c11666", async() => {
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310b232b7220e7cdd6780e166b91407f33e5125c11935", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 12 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
#nullable restore
#line 14 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
             if(!string.IsNullOrEmpty(ViewBag.message))
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <div class=\"alert alert-success\">");
#nullable restore
#line 16 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
                                             Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n");
#nullable restore
#line 17 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
             }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "310b232b7220e7cdd6780e166b91407f33e5125c14418", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 19 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CarCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n           <div class=\"form-group\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310b232b7220e7cdd6780e166b91407f33e5125c16411", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#nullable restore
#line 21 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "310b232b7220e7cdd6780e166b91407f33e5125c18283", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
#nullable restore
#line 23 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SeatNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n              <div class=\"form-upload d-flex flex-start position-relative\">\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "310b232b7220e7cdd6780e166b91407f33e5125c20329", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#nullable restore
#line 26 "T:\carbooking_netcore-master\Views\Admin\Car\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Thumbnail);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                  <input type=""file""  class=""position-absolute"">
                  <button type=""button"" class=""btn btn-info btn-rounded btn-sm"" style=""width:120px  "">Ảnh đại diện</button><br>
            </div>
                  <div class=""text-center my-2 position-relative"">
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                          <img class=""mt-2""  id=""profile-thumbnail"" style=""width:80px"" >
                      </span>
                  </div>

            <div class=""form-upload d-flex flex-start position-relative"">
                  <input id=""i-images"" type=""file"" class=""position-absolute"">
                  <button type=""button"" class=""btn btn-info btn-rounded btn-sm"" style=""width:120px  "">Ảnh </button><br>
");
                WriteLiteral(@"            </div>
            <div class=""text-center my-5 d-flex justify-content-around"">
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                            <img class=""images mt-2""  style=""width:80px"" >
                      </span>
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                            <img class=""images mt-2""  style=""width:80px"" >
                      </span>
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                            <img class=""images mt-2""  style=""width:80px"" >
                      </span>
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                            <img class=""images mt-2""  style=""width:80px"" >
                      </span>
             </div>
            <div class=""text-center my-5 d-flex ");
                WriteLiteral(@"justify-content-around"">
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                            <img class=""images mt-2""  style=""width:80px"" >
                      </span>
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                            <img class=""images mt-2""  style=""width:80px"" >
                      </span>
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                            <img class=""images mt-2""  style=""width:80px"" >
                      </span>
                      <span class=""d-inline-block"" style=""width:100px; height:100px; border: 1px dotted gray"">
                            <img class=""images mt-2""  style=""width:80px"" >
                      </span>
             </div>


            <div class=""text-left"">
                <button class=""btn btn-primary btn-sm"" type=""submit"" style=""w");
                WriteLiteral("idth:120px \">Thêm</button>\n            </div>\n\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        \n\n     </div>\n </div>\n");
            DefineSection("Css", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "310b232b7220e7cdd6780e166b91407f33e5125c26913", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_18);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_19);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <style>\n        .form-upload input[type=\"file\"]{\n            width: 120px;\n            z-index: 999;\n            opacity: 0;\n        }\n        </style>\n");
            }
            );
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $('input[id$=datepicker]').datepicker({
                dateFormat:'mm/dd/yy',
                changeYear: true,
                changeMonth: true,
            });
    
        });
    </script>
        <script>

        let inputEditThumbnail = document.querySelector('.form-upload input[type=""file""]');

        let thumbnailUrl = document.querySelector('input[name=""Thumbnail""]');
        inputEditThumbnail.addEventListener('change', function() {
        let Thumbnail = document.querySelector('#profile-thumbnail');
        
        var url = ""/admin/car/upload/thumbnail"";
            var formData = new FormData();
            formData.append(""Thumbnail"", inputEditThumbnail.files[0]);

        fetch(url, {
                    method: 'POST',
                    body: formData
                })
                .then(response => response.json())
                .then(data => {
                    data.thumbnail = data.thumbnail.replace('\\', '/');
              ");
                WriteLiteral(@"      Thumbnail.setAttribute(""src"", data.thumbnail);
                    thumbnailUrl.value = data.thumbnail;
                })
                .catch(err => {
                    console.log(err);
                })
        })

        let inputUploadImages = document.querySelector('#i-images');
        let dataImages        = [];
        let imageUrls         = document.querySelector('input[name=""CarImages""]');
        let images            = document.querySelectorAll('.images');
        let indexImages       = 0;
        inputUploadImages.addEventListener('change', function() {

            if(indexImages > 7){
                return;
            }
            else{

                let Thumbnail = document.querySelector('#profile-thumbnail');
                
                var url = ""/admin/car/upload/thumbnail"";
                    var formData = new FormData();
                    formData.append(""Thumbnail"", inputUploadImages.files[0]);

                fetch(url, {
                            metho");
                WriteLiteral(@"d: 'POST',
                            body: formData
                        })
                        .then(response => response.json())
                        .then(data => {
                            
                            //dataImages.push({url: data.thumbnail, size: data.fileSize});
                            //imageUrls.value = JSON.stringify(dataImages);
                            data.thumbnail = data.thumbnail.replace('\\', '/');
                            images[indexImages].setAttribute(""src"", data.thumbnail);

                            input = document.createElement('input');
                            input.type='hidden';
                            input.value = data.thumbnail;
                            input.name =""CarImages[""+indexImages+""].url"";
                            images[indexImages].after(input);

                            input = document.createElement('input');
                            input.type='hidden';
                            input.value = data.file");
                WriteLiteral(@"Size;
                            input.name =""CarImages[""+indexImages+""].size"";
                            images[indexImages].after(input);

                            indexImages ++;

                        })
                        .catch(err => {
                            console.log(err);
                 })
            }
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591