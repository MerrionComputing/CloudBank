#pragma checksum "D:\Source\CloudBank\src\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af3d3cf5be6762428c2b5cdef790d17450e93068"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>CloudBank - An Azure Serverless functions demo</h1>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<p>
    This demo shows the use of a <a href=""http://www.blazor.net"">Blazor</a> wrapper over an 
    Azure <a href=""https://azure.microsoft.com/en-us/services/functions"">functions</a> application 
    backed by an <a href=""https://github.com/MerrionComputing/EventsSourcing-on-Azure-Functions"">event sourcing</a>
    based data layer.
</p>
");
            __builder.AddMarkupContent(2, "<p>\r\n    It is designed to <i>scale to zero</i> so that when not being used there is absolutely no running cost.\r\n</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591