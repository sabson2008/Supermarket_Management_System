#pragma checksum "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92cb749cbf83219edbfe98a40d598cd4483eeda89e71f6025871dd4d849eda34"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\_Imports.razor"
using UseCases

#nullable disable
    ;
    #line default
    #line hidden
#nullable restore
#line 2 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
           [Authorize(Policy ="AdminOnly")]

#line default
#line hidden
#nullable disable

    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
      "/editproduct/{productId}"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class EditProductComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Product</h3>\r\n<br>");
#nullable restore
#line 12 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
 if (product != null)
{

#line default
#line hidden
#nullable disable

            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 14 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                 product

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                                         OnValidSumit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<global::Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"name\">Name</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", (object)("name"));
                __builder2.AddAttribute(14, "class", (object)("form-control"));
                __builder2.AddAttribute(15, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                                          product.Name

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Name = __value, product.Name)))));
                __builder2.AddAttribute(17, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<global::System.Func<global::System.String>>>(() => product.Name)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"category\">Category</label>\r\n        ");
                __builder2.OpenElement(22, "select");
                __builder2.AddAttribute(23, "id", "category");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                                     product.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.CategoryId = __value, product.CategoryId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(27, "option");
                __builder2.AddAttribute(28, "selected");
                __builder2.CloseElement();
#nullable restore
#line 27 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
            

#line default
#line hidden
#nullable disable

#nullable restore
#line 27 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
             foreach (var cat in categories)
            {

#line default
#line hidden
#nullable disable

                __builder2.OpenElement(29, "option");
                __builder2.AddAttribute(30, "value", 
#nullable restore
#line 29 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                                cat.CategoryId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(31, 
#nullable restore
#line 29 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                                                 cat.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 30 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
            }

#line default
#line hidden
#nullable disable

                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"price\">Price</label>\r\n        ");
                global::__Blazor.WebApp.Pages.EditProductComponent.TypeInference.CreateInputNumber_0(__builder2, 36, 37, "price", 38, "form-control", 39, 
#nullable restore
#line 36 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                                             product.Price

#line default
#line hidden
#nullable disable
                , 40, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Price = __value, product.Price)), 41, () => product.Price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label for=\"qty\">Quantity</label>\r\n        ");
                global::__Blazor.WebApp.Pages.EditProductComponent.TypeInference.CreateInputNumber_1(__builder2, 46, 47, "qty", 48, "form-control", 49, 
#nullable restore
#line 41 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                                           product.Quantity

#line default
#line hidden
#nullable disable
                , 50, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Quantity = __value, product.Quantity)), 51, () => product.Quantity);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.AddMarkupContent(53, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n    ");
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "type", "button");
                __builder2.AddAttribute(56, "class", "btn btn-primary");
                __builder2.AddAttribute(57, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                                                            OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(58, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 47 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"

}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
       
    [Parameter]
    public string ProductId { get; set; }

    private Product product;
    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        categories = ViewCategoriesUseCase.Execute();
    }    

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (int.TryParse(this.ProductId, out int iProductId))
        {
            var prod = GetProductByIdUseCase.Execute(iProductId);
            this.product = new Product { 
                ProductId = prod.ProductId, 
                Name = prod.Name,
                CategoryId = prod.CategoryId,
                Price = prod.Price,
                Quantity = prod.Quantity
            };
        }
    }

    private void OnValidSumit()
    {
        EditProductUseCase.Execute(this.product);
        NavigationManager.NavigateTo("/products");
    }

    private void OnCancel()
    {
        NavigationManager.NavigateTo("/products");
    }


#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 8 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
        IViewCategoriesUseCase

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 8 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                               ViewCategoriesUseCase

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 7 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
        IEditProductUseCase

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 7 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                            EditProductUseCase

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
        IGetProductByIdUseCase

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                               GetProductByIdUseCase

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
        IAddProductUseCase

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                           AddProductUseCase

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\EditProductComponent.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.WebApp.Pages.EditProductComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", (object)__arg0);
        __builder.AddAttribute(__seq1, "class", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", (object)__arg0);
        __builder.AddAttribute(__seq1, "class", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
