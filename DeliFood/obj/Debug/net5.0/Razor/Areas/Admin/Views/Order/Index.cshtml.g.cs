#pragma checksum "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4742afd996218dd37ff5a1997b83985a0cb078a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Index.cshtml")]
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
#line 1 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/_ViewImports.cshtml"
using DeliFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/_ViewImports.cshtml"
using DeliFood.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4742afd996218dd37ff5a1997b83985a0cb078a6", @"/Areas/Admin/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f394fe75643ca906d1b31547081221fe2420f6bd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<DeliFood.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-tone m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-tone m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-tone m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";
    var format = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Container START -->\r\n<!-- Content Wrapper START -->\r\n\r\n<div class=\"page-header\">\r\n    <h2 class=\"header-title\">ORDER</h2>\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4742afd996218dd37ff5a1997b83985a0cb078a68334", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <span class=""breadcrumb-item active"">List order</span>
        </nav>
    </div>

</div>
<div class=""card"">
    <div class=""card-body"">
        <div class=""row m-b-30"">
            <div class=""col-lg-3"">
                <label>ID Bill</label>
");
#nullable restore
#line 28 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                 if(ViewBag.idFilter != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"number\" id=\"txtIDBill\"  class=\"priceFilter form-control\"");
            BeginWriteAttribute("value", " value=\"", 1060, "\"", 1085, 1);
#nullable restore
#line 30 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
WriteAttributeValue("", 1068, ViewBag.idFilter, 1068, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"number\" />\r\n");
#nullable restore
#line 31 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"number\" id=\"txtIDBill\"  class=\"priceFilter form-control\" placeholder=\"number\" />\n");
#nullable restore
#line 35 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-lg-3\">\r\n                <label>From <small id=\"fromText\">(VNĐ)</small></label>\r\n");
#nullable restore
#line 39 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                 if(ViewBag.fromFilter != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"number\" id=\"txtFrom\" class=\"priceFilter form-control\"");
            BeginWriteAttribute("value", " value=\"", 1582, "\"", 1609, 1);
#nullable restore
#line 41 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
WriteAttributeValue("", 1590, ViewBag.fromFilter, 1590, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"VNĐ\" />\r\n");
#nullable restore
#line 42 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"number\" id=\"txtFrom\" class=\"priceFilter form-control\" placeholder=\"VNĐ\"/>\n");
#nullable restore
#line 46 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-lg-3\">\r\n                <label>To <small id=\"toText\">(VNĐ)</small></label>\r\n");
#nullable restore
#line 50 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                 if(ViewBag.toFilter != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <input type=\"number\" id=\"txtTo\" class=\"priceFilter form-control\"");
            BeginWriteAttribute("value", " value=\"", 2087, "\"", 2112, 1);
#nullable restore
#line 52 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
WriteAttributeValue("", 2095, ViewBag.toFilter, 2095, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"VNĐ\" />\r\n");
#nullable restore
#line 53 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"number\" id=\"txtTo\" class=\"priceFilter form-control\" placeholder=\"VNĐ\" />\n");
#nullable restore
#line 57 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""col-lg-3 text-right mt-4 text-white"">
                <a id=""FilterButtonBill"" class=""btn btn-secondary btn-tone-2"">Find</a>
            </div>
        </div>

        <div class=""table-responsive"">
            <table class=""table table-hover e-commerce-table"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Customer</th>
                        <th>Order date</th>
                        <th>Total price</th>
                        <th>Note</th>
                        <th>Status</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 78 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                     if (Model != null)
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        #");
#nullable restore
#line 84 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
    Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 87 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
   Write(item.Customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 90 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
   Write(item.OrderDate.ToString(string.Format("dd/MM/yyyy hh:mm tt")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 93 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
   Write(String.Format(format, "{0:c0}", item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n\r\n");
#nullable restore
#line 96 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
         if(item.Note != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 98 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
           Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 99 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Empty</td>\r\n");
#nullable restore
#line 103 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>\r\n");
#nullable restore
#line 105 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
         if (item.Status)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex align-items-center\">\r\n            <div class=\"badge badge-success badge-dot m-r-10\">    </div>\r\n            <div>Processed</div>\r\n        </div>\r\n");
#nullable restore
#line 111 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex align-items-center\">\r\n            <div class=\"badge badge-danger badge-dot m-r-10\"></div>\r\n            <div>Pending</div>\r\n        </div>\r\n");
#nullable restore
#line 118 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n    <td>\r\n        \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4742afd996218dd37ff5a1997b83985a0cb078a619452", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                                                                                                                      WriteLiteral(item.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4742afd996218dd37ff5a1997b83985a0cb078a622187", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                                                                                                                WriteLiteral(item.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4742afd996218dd37ff5a1997b83985a0cb078a624913", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
                                                                                                               WriteLiteral(item.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n\r\n</tr>");
#nullable restore
#line 127 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div aria-label=\"Page navigatio\">\r\n    <ul class=\"pagination\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4742afd996218dd37ff5a1997b83985a0cb078a628280", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
#nullable restore
#line 139 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Areas/Admin/Views/Order/Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </ul>\r\n</div>\r\n<!-- Content Wrapper END -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
            let NameFilter;
            let StatusFilter;
            let CatFilter;
        $('.priceFilter').keyup(function (e) {
            let input;
            input = $(this).val();
            console.log(input)
            if (input == """") {
                $(this).val(input);
            }
            else
            {
                if (input > 100000000) {
                    $(this).val(100000000);
                }
            }

            })

            NameFilter = $('#InputNameFilter').data(""value"");
            StatusFilter = $('#InputStatusFilter').data(""value"");
            CatFilter = $('#InputCatFilter').data('value');
            if (NameFilter != null) {
                $('#txtProductName').val(NameFilter);
            };
            if (StatusFilter != null) {
                $('#sbStatus option').removeAttr('selected');
                $(""#sbStatus option[value="" + ""'"" + StatusFilter + ""'"" + ""]"").attr('selected', true);
            };
 ");
                WriteLiteral(@"           if (CatFilter != null) {
                $('#sbCategory option').removeAttr('selected');
                $(""#sbCategory option[value="" + ""'"" + CatFilter + ""'"" + ""]"").attr('selected', true);
            };


            // filter

        $('#FilterButtonBill').click(function () {
            var idBillFilter = $('#txtIDBill').val();
            var fromPriceFilter = $('#txtFrom').val();
            var toPriceFilter = $('#txtTo').val();

            $.ajax({
                url: ""/Admin/Order/Filter"",
                datatype: ""json"",
                type: ""POST"",
                data: {
                    idbill: idBillFilter,
                    from: fromPriceFilter,
                    to: toPriceFilter
                },

                async: true,
                success: function (result) {
                    if (result.status) {
                        window.location.href = result.redirect;
                    }
                }
            })
        })

        </script>
");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<DeliFood.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
