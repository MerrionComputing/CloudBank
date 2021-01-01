#pragma checksum "D:\Source\CloudBank\src\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6539c65531678c5d4ab9524c0a5432f5e5c222f2"
// <auto-generated/>
#pragma warning disable 1591
namespace CloudBank.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Source\CloudBank\src\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Source\CloudBank\src\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 3 "D:\Source\CloudBank\src\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\Source\CloudBank\src\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\Source\CloudBank\src\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "D:\Source\CloudBank\src\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#line 7 "D:\Source\CloudBank\src\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "D:\Source\CloudBank\src\_Imports.razor"
using Blazored;

#line default
#line hidden
#line 9 "D:\Source\CloudBank\src\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#line 10 "D:\Source\CloudBank\src\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#line 11 "D:\Source\CloudBank\src\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#line 12 "D:\Source\CloudBank\src\_Imports.razor"
using CloudBank;

#line default
#line hidden
#line 13 "D:\Source\CloudBank\src\_Imports.razor"
using CloudBank.Shared;

#line default
#line hidden
#line 14 "D:\Source\CloudBank\src\_Imports.razor"
using CloudBank.RetailBank;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Bank Accounts</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Sample bank accounts</p>");
#line 9 "D:\Source\CloudBank\src\Pages\FetchData.razor"
 if (accounts == null)
{

#line default
#line hidden
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#line 12 "D:\Source\CloudBank\src\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th width=\"20%\">Account Number</th>\r\n                <th>Owner</th>\r\n                <th>Live view</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#line 24 "D:\Source\CloudBank\src\Pages\FetchData.razor"
             foreach (BankAccount account in accounts.Values )
            {

#line default
#line hidden
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 28 "D:\Source\CloudBank\src\Pages\FetchData.razor"
                                                              () => NavigateToAccount(account.AccountNumber)

#line default
#line hidden
            ));
            __builder.AddContent(12, 
#line 29 "D:\Source\CloudBank\src\Pages\FetchData.razor"
                         account.AccountNumber

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#line 32 "D:\Source\CloudBank\src\Pages\FetchData.razor"
                     account.ClientName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
#line 34 "D:\Source\CloudBank\src\Pages\FetchData.razor"
                     if (!account.Watching)
                    {

#line default
#line hidden
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-info");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 36 "D:\Source\CloudBank\src\Pages\FetchData.razor"
                                                               () => WatchAccount(account.AccountNumber)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(21, "\r\n                            Watch this account\r\n                        ");
            __builder.CloseElement();
#line 39 "D:\Source\CloudBank\src\Pages\FetchData.razor"
                    }
                    else
                    {

#line default
#line hidden
            __builder.AddMarkupContent(22, "<span>Watching...</span>");
#line 43 "D:\Source\CloudBank\src\Pages\FetchData.razor"
                    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.CloseElement();
#line 46 "D:\Source\CloudBank\src\Pages\FetchData.razor"
            }

#line default
#line hidden
            __builder.CloseElement();
            __builder.CloseElement();
#line 49 "D:\Source\CloudBank\src\Pages\FetchData.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 51 "D:\Source\CloudBank\src\Pages\FetchData.razor"
       
    Dictionary<string,BankAccount> accounts;

    protected override async Task OnInitializedAsync()
    {
        accounts = new Dictionary<string, BankAccount>();

        foreach(BankAccount acct in await Http.GetJsonAsync<BankAccount[]>("sample-data/bank-accounts.json"))
        {
            accounts.Add(acct.AccountNumber, acct);
        }

    }

    public void NavigateToAccount(string accountNumber)
    {
        NavigationManager.NavigateTo($"myaccount/{accountNumber}");
    }

    public void WatchAccount(string accountNumber)
    {
        if (accounts.ContainsKey(accountNumber ))
        {
            accounts[accountNumber].Watching = true;
            this.StateHasChanged();
        }
    }

    public class BankAccount
    {
        public String AccountNumber { get; set; }

        public string ClientName { get; set; }

        // Is this bank account in the live view
        public bool Watching { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
