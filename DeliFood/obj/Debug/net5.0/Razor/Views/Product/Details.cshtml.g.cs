#pragma checksum "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db9b8539c3781a1dc6bd8be757703fa3d7cef387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db9b8539c3781a1dc6bd8be757703fa3d7cef387", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c45c6e01147325aecd47ea063efc0dd42c745a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliFood.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("555"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("645"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("single-img gallery-popup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Thumnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("swiper-slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
  
    ViewData["Title"] = "Details product";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var lsProSameCat = ViewBag.lsProductsSameCat;

    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Main Content Area  -->
<main class=""main-content"">
    
    <div class=""single-product-area section-space-top-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""single-product-img h-100"">
                        <div class=""swiper-container single-product-slider"">
                            <div class=""swiper-wrapper"">
                                <div class=""swiper-slide"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db9b8539c3781a1dc6bd8be757703fa3d7cef3877597", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db9b8539c3781a1dc6bd8be757703fa3d7cef3877890", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 860, "~/images/product/", 860, 17, true);
#nullable restore
#line 22 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
AddHtmlAttributeValue("", 877, Model.Image, 877, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 727, "~/images/product/", 727, 17, true);
#nullable restore
#line 21 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
AddHtmlAttributeValue("", 744, Model.Image, 744, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                            <!-- Add Pagination -->
                            <div class=""swiper-pagination""></div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""product-thumb-with-content row"">
                        <div class=""col-12 order-lg-1 order-2 pt-10 pt-lg-0"">
                            <div class=""single-product-content"">
                                <h2 class=""title"">");
#nullable restore
#line 35 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
                                             Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div class=\"price-box pb-1\">\r\n                                    <span class=\"new-price text-danger\">");
#nullable restore
#line 37 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
                                                                   Write(Model.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VN??</span>
                                </div>
                                <div class=""rating-box-wrap pb-7"">
                                    <div class=""rating-box"">
                                        <ul>
                                            <li><i class=""pe-7s-star""></i></li>
                                            <li><i class=""pe-7s-star""></i></li>
                                            <li><i class=""pe-7s-star""></i></li>
                                            <li><i class=""pe-7s-star""></i></li>
                                            <li><i class=""pe-7s-star""></i></li>
                                        </ul>
                                    </div>
                                </div>
                                <p class=""short-desc mb-6"">
                                    Lorem ipsum dolor sit amet, consecte adipisicin elit, sed do
                                    eiusmod tempor incidi ut labore et dolore magna aliqua. Ut enim ");
            WriteLiteral(@"ad minim veniam,
                                    quis
                                    nostrud exercita ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute
                                    irure dolor in reprehenderit in voluptate velit esse cillum dolore.
                                </p>
                                <ul class=""quantity-with-btn pb-7"">
                                    <li class=""add-to-cart"">
                                        <a class=""addtoCart btn btn-custom-size lg-size btn-primary btn-secondary-hover rounded-0"" data-value=""");
#nullable restore
#line 59 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
                                                                                                                                          Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Add to cart</a>
                                    </li>
                                </ul>
                                <div class=""product-category text-matterhorn pb-2"">
                                    <span class=""title"">Categories :</span>
                                    <ul>
                                        <li>
                                            ");
#nullable restore
#line 66 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
                                       Write(Model.Category.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 order-lg-2 order-1 pt-10 pt-lg-0"">
                            <div class=""swiper-container single-product-thumbs"">
                                <div class=""swiper-wrapper"">
");
#nullable restore
#line 75 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
                                     foreach (var item in lsProSameCat)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db9b8539c3781a1dc6bd8be757703fa3d7cef38716075", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db9b8539c3781a1dc6bd8be757703fa3d7cef38716373", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4554, "~/images/product/", 4554, 17, true);
#nullable restore
#line 78 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
AddHtmlAttributeValue("", 4571, item.Image, 4571, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
                                                                  WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 80 "/Users/anhichi.1997gmail.com/Desktop/longlong/C5/T112/DeliFood/DeliFood/DeliFood/Views/Product/Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""product-tab-area section-space-top-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <ul class=""nav product-tab-nav product-tab-style-2"" role=""tablist"">
                        <li class=""nav-item"" role=""presentation"">
                            <a class=""active btn btn-custom-size"" id=""description-tab"" data-bs-toggle=""tab"" href=""#description"" role=""tab"" aria-controls=""description"" aria-selected=""true"">
                                Description
                            </a>
                        </li>
                    </ul>
                    <div class=""tab-content product-tab-content"">
                        <div class=""tab-pane fade show active"" id=""description"" role=""tabpanel"" ari");
            WriteLiteral(@"a-labelledby=""description-tab"">
                            <div class=""product-description-body"">
                                <p class=""short-desc mb-0"">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed
                                    do eiusmod tempor incidi ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                    quis nostrud exercit ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis
                                    aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat
                                    nulla pariatur. Excepteurdf sint occaecat cupidatat non proident, sunt in culpa qui
                                    officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste
                                    natus error sit voluptatem accusl doloremque laudantium, totam rem aperiam, eaque
                                    ipsa quae");
            WriteLiteral(@" ab illo inventore v et quasi architecto beatae vitae dicta sunt explicabo.
                                    Nemo enim ipsam voluptadtem quia voluptas sit aspernatur aut odit aut fugit, sed
                                    quia consequuntur magni dolores eos qui ratione
                                </p>
                            </div>
                        </div>
                
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""product-slider-area section-space-top-95 section-space-bottom-100"">
        
    </div>
</main>
<!-- Main Content Area End Here  -->
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'.addtoCart\').click(function () {\r\n            var idProduct = $(this).data(\"value\");\r\n            addToCart(idProduct);\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliFood.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
