#pragma checksum "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6f9e0ce6a9c9bc04235cbb07110a5116e21b91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClientAccount_ViewDetailsOrder), @"mvc.1.0.view", @"/Views/ClientAccount/ViewDetailsOrder.cshtml")]
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
#line 1 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/_ViewImports.cshtml"
using DeliFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/_ViewImports.cshtml"
using DeliFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6f9e0ce6a9c9bc04235cbb07110a5116e21b91", @"/Views/ClientAccount/ViewDetailsOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c45c6e01147325aecd47ea063efc0dd42c745a7", @"/Views/_ViewImports.cshtml")]
    public class Views_ClientAccount_ViewDetailsOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeliFood.Models.OrderDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
  

    double totalPrice = 0;
    foreach (var item in Model)
    {
        totalPrice += item.TotalPrice;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""checkout-area section-space-y-axis-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-12"">
                <div class=""your-order"">
                    <div class=""row"">
                        <div class=""col-6"">
                            <h3>Your order</h3>
                        </div>
                        <div class=""col-6"">
                            <small>Shipped date: <strong>");
#nullable restore
#line 20 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
                                                    Write(Model.First().ShipDate.ToString(string.Format("dd/MM/yyyy")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></small>
                        </div>
                    </div>
                    <div class=""your-order-table table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""cart-product-name"">Product</th>
                                    <th class=""cart-product-total"">Total</th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 33 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"cart_item\">\n                                        <td class=\"cart-product-name\">\n                                            ");
#nullable restore
#line 37 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
                                       Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong class=\"product-quantity\">\n                                                × ");
#nullable restore
#line 38 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
                                             Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </strong>\n                                        </td>\n                                        <td class=\"cart-product-total\"><span class=\"amount\">");
#nullable restore
#line 41 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
                                                                                       Write(item.TotalPrice.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\n                                    </tr>\n");
#nullable restore
#line 43 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                            <tfoot>
                                <tr>
                                </tr>
                                <tr class=""order-total"">
                                    <th>Order Total</th>
                                    <td><strong><span class=""amount"">");
#nullable restore
#line 50 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
                                                                Write(totalPrice.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span></strong></td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <div class=""payment-method"">
                        <div class=""payment-accordion"">
                            <small>(VAT included)</small>
                            <small>VAT: <strong>");
#nullable restore
#line 58 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/ClientAccount/ViewDetailsOrder.cshtml"
                                           Write(Model.First().VAT);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</strong></small>\n\n                        </div>\n                    </div>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e6f9e0ce6a9c9bc04235cbb07110a5116e21b919062", async() => {
                WriteLiteral("Return to history ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeliFood.Models.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591