#pragma checksum "D:\Source\CloudBank\src\Pages\LiveView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c144468835c87bd3d820e595fff2487873089f6f"
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
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "D:\Source\CloudBank\src\_Imports.razor"
using Blazored;

#line default
#line hidden
#line 8 "D:\Source\CloudBank\src\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#line 9 "D:\Source\CloudBank\src\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#line 10 "D:\Source\CloudBank\src\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#line 11 "D:\Source\CloudBank\src\_Imports.razor"
using CloudBank;

#line default
#line hidden
#line 12 "D:\Source\CloudBank\src\_Imports.razor"
using CloudBank.Shared;

#line default
#line hidden
#line 13 "D:\Source\CloudBank\src\_Imports.razor"
using CloudBank.RetailBank;

#line default
#line hidden
#line 2 "D:\Source\CloudBank\src\Pages\LiveView.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/liveview")]
    public partial class LiveView : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Live Accounts View</h3>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "id", "notificationList");
            __builder.AddMarkupContent(3, "\r\n");
#line 12 "D:\Source\CloudBank\src\Pages\LiveView.razor"
     foreach (var notification in notifications)
    {

#line default
#line hidden
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "li");
            __builder.AddContent(6, 
#line 14 "D:\Source\CloudBank\src\Pages\LiveView.razor"
             notification

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#line 15 "D:\Source\CloudBank\src\Pages\LiveView.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 18 "D:\Source\CloudBank\src\Pages\LiveView.razor"
       
    private HubConnection hubConnection;
    private List<object> notifications = new List<object>();


    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(@"https://retailbank.service.signalr.net")
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            // Turn the message into an object...

            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    public bool IsConnected
    {
        get
        {
            if (hubConnection != null)
            {
                return (hubConnection.State == HubConnectionState.Connected);
            }

            return false;
        }
    }

    public void Dispose()
    {
        // Clear down the SignalR connection
        _ = hubConnection.DisposeAsync();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
