#pragma checksum "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed1ed9511db5643861e252637518566b396011b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed1ed9511db5643861e252637518566b396011b4", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c45c6e01147325aecd47ea063efc0dd42c745a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeliFood.Models.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
  
    var customer = ViewBag.Customer;
    double totalPrice = 0;
    foreach (var item in Model)
    {
        totalPrice += item.Total;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"checkout-area section-space-y-axis-100\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 col-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1ed9511db5643861e252637518566b396011b44388", async() => {
                WriteLiteral(@"
                    <div class=""checkbox-form"">
                        <h3>Billing Details</h3>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""checkout-form-list"">
                                    <label>Full Name</label>
                                    <input");
                BeginWriteAttribute("placeholder", " placeholder=\"", 781, "\"", 795, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 808, "\"", 834, 1);
#nullable restore
#line 22 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
WriteAttributeValue("", 816, customer.FullName, 816, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 25 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
                             if(customer.Address != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                             <div class=""col-md-12"">
                                <div class=""checkout-form-list"">
                                    <label>Address</label>
                                    <input placeholder=""Street address"" id=""checkout-Address""");
                BeginWriteAttribute("value", " value=\"", 1286, "\"", 1311, 1);
#nullable restore
#line 30 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
WriteAttributeValue("", 1294, customer.Address, 1294, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-value=\"Address\" type=\"text\" readonly>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 33 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""col-md-12"">
                                <div class=""checkout-form-list"">
                                    <label>Address <span class=""required"">*</span></label>
                                    <input placeholder=""Street address"" id=""checkout-Address"" data-value=""not"" type=""text"">
                                    <span class=""text-danger"" id=""addressNotif"" style=""display:none;"">Please fill your address for payment</span>
                                </div>
                            </div>
");
#nullable restore
#line 43 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            
                            <div class=""col-md-6"">
                                <div class=""checkout-form-list"">
                                    <label>Email </label>
                                    <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 2379, "\"", 2410, 1);
#nullable restore
#line 48 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
WriteAttributeValue("", 2387, customer.Account.Email, 2387, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""checkout-form-list"">
                                    <label>Phone </label>
                                    <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 2730, "\"", 2753, 1);
#nullable restore
#line 54 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
WriteAttributeValue("", 2738, customer.Phone, 2738, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                </div>
                            </div>
                        </div>
                        <div class=""different-address"">
                            <div class=""order-notes"">
                                <div class=""checkout-form-list checkout-form-list-2"">
                                    <label>Order Notes</label>
                                    <textarea id=""checkout-mess"" cols=""30"" rows=""10"" placeholder=""Notes about your order, e.g. special notes for delivery.""></textarea>
                                </div>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-lg-6 col-12"">
                <div class=""your-order"">
                    <h3>Your order</h3>
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
#line 82 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"cart_item\">\r\n                                    <td class=\"cart-product-name\">\r\n                                        ");
#nullable restore
#line 86 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong class=\"product-quantity\">\r\n                                            × ");
#nullable restore
#line 87 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
                                         Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </strong>\r\n                                    </td>\r\n                                    <td class=\"cart-product-total\"><span class=\"amount\">");
#nullable restore
#line 90 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
                                                                                   Write(item.Total.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\r\n                                </tr>\r\n");
#nullable restore
#line 92 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"


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
#line 102 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Cart/Checkout.cshtml"
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

                            <div class=""order-button-payment"">
                                <input value=""Place order"" id=""checkoutBtn"" type=""button"">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    $('#checkoutBtn').click(function () {
        if ($('#checkout-Address').val() == """") {
            $('#addressNotif').show();
        }
        else {
            $('#addressNotif').hide();
            var Note = $('#checkout-mess').val()
            var AddressInput = $('#checkout-Address').data(""value"");
            let Address;
            if (AddressInput == ""not"") {
                Address = $('#checkout-Address').val();
            }
            $.ajax({
                type: ""POST"",
                url: ""/Cart/Checkout/"",
                data: {
                    note: Note,
                    address: Address
                },
                success: function (respone) {
                    if (respone.success) {
                        window.location.href = respone.redirect
                    }
                },
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeliFood.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591