// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
           [Authorize(Policy = "CashierOnly")]

#line default
#line hidden
#nullable disable

    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
      "/cashier_console"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class CashierConsoleComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\admin\Desktop\Supermarket_Management_System\SupermarketManagement\WebApp\Pages\CashierConsoleComponent.razor"
       
    private TodayTransactionsComponent transactionComponent;

    private Product selectedProduct;
    private string cashierName;

    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }

    private AuthenticationState authState;

    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;
        cashierName = authState.User.Identity.Name;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        if (firstRender)
        {
            transactionComponent.LoadTransactions(cashierName);
        }
    }

    private void SelectProduct(Product product)
    {
        selectedProduct = product;
    }

    private void SellProduct(Product product)
    {
        transactionComponent.LoadTransactions(cashierName);
    }


#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
