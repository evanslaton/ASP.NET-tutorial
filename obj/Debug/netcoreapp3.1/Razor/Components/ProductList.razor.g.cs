#pragma checksum "C:\Users\evans\source\Store\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc02be6bc4d2b0302286dc7cb9ae11e3a20cdda"
// <auto-generated/>
#pragma warning disable 1591
namespace Store.Components
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\evans\source\Store\Components\ProductList.razor"
using Store.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\evans\source\Store\Components\ProductList.razor"
using Store.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\evans\source\Store\Components\ProductList.razor"
using System;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\evans\source\Store\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 10 "C:\Users\evans\source\Store\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, 
#nullable restore
#line 13 "C:\Users\evans\source\Store\Components\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, @"<div class=""card-footer"">
                <small class=""text-muted"">
                    <button @onclick=""(e => SelectProduct(product.Id))"" data-toggle=""modal"" data-target=""#productModal"" class=""btn btn-primary"">
                        More Info
                    </button>
                </small>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 24 "C:\Users\evans\source\Store\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 27 "C:\Users\evans\source\Store\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal fade");
            __builder.AddAttribute(26, "id", "productModal");
            __builder.AddAttribute(27, "tabindex", "-1");
            __builder.AddAttribute(28, "role", "dialog");
            __builder.AddAttribute(29, "aria-labelledby", "productTitle");
            __builder.AddAttribute(30, "aria-hidden", "true");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(34, "role", "document");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-content");
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal-header");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "h5");
            __builder.AddAttribute(43, "class", "modal-title");
            __builder.AddAttribute(44, "id", "productTitle");
            __builder.AddContent(45, 
#nullable restore
#line 33 "C:\Users\evans\source\Store\Components\ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.AddMarkupContent(47, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-body");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card");
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "card-img");
            __builder.AddAttribute(57, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 40 "C:\Users\evans\source\Store\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "card-body");
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "p");
            __builder.AddAttribute(64, "class", "card-text");
            __builder.AddContent(65, 
#nullable restore
#line 43 "C:\Users\evans\source\Store\Components\ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "modal-footer");
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 48 "C:\Users\evans\source\Store\Components\ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                        ");
            __builder.AddMarkupContent(74, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 51 "C:\Users\evans\source\Store\Components\ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                        ");
            __builder.OpenElement(76, "span");
            __builder.AddContent(77, 
#nullable restore
#line 54 "C:\Users\evans\source\Store\Components\ProductList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, " ");
            __builder.AddContent(79, 
#nullable restore
#line 54 "C:\Users\evans\source\Store\Components\ProductList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 55 "C:\Users\evans\source\Store\Components\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\evans\source\Store\Components\ProductList.razor"
                     for (int i = 1; i < 6; i++)
                    {
                        int currentStar = i;
                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "                            <span class=\"fa fa-star checked\" @onclick=\"(e => SubmitRating(currentStar))\"></span>\r\n");
#nullable restore
#line 62 "C:\Users\evans\source\Store\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "                            <span class=\"fa fa-star\" @onclick=\"(e => SubmitRating(currentStar))\"></span>\r\n");
#nullable restore
#line 66 "C:\Users\evans\source\Store\Components\ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 72 "C:\Users\evans\source\Store\Components\ProductList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(88, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\evans\source\Store\Components\ProductList.razor"
 
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(product => product.Id == productId);
        CalcCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void CalcCurrentRating()
    {
        if (selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }

        Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
        Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
