#pragma checksum "D:\Source\CloudBank\src\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "691263ae8b876f1a71f1ad220f4e43841107effa"
// <auto-generated/>
#pragma warning disable 1591
namespace CloudBank.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Modal.BlazoredModal>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "sidebar");
            __builder.OpenComponent<CloudBank.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "<div class=\"top-row px-4\"><a href=\"https://github.com/MerrionComputing/EventsSourcing-on-Azure-Functions\" target=\"_blank\" class=\"ml-md-auto\">GitHub source</a></div>\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddContent(11, 
#line 18 "D:\Source\CloudBank\src\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 23 "D:\Source\CloudBank\src\Shared\MainLayout.razor"
 

    [Parameter]
    public ApiCommand[] apiCommands { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (null == apiCommands)
        {
            apiCommands = await Http.GetJsonAsync<ApiCommand[]>("sample-data/bank-api.json");
            if (null != apiCommands)
            {
                // fix up the rertail bank api with them...
                retailBankApi.Initialise(apiCommands);
            }
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRetailBankApi retailBankApi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
