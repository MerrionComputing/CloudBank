#pragma checksum "D:\Source\CloudBank\src\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888ded532d4d6d70a15620da85ba45cd02db276e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>User</h1>\r\n<hr>\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Create a new account</h3>\r\n");
            __builder.OpenElement(2, "h3");
            __builder.AddMarkupContent(3, "<span class=\"circle-cropper\" style=\"fill:azure\"><span class=\"oi oi-monitor\" aria-hidden=\"true\"></span></span>&nbsp;");
            __builder.AddContent(4, 
#line 12 "D:\Source\CloudBank\src\Pages\User.razor"
                                                                                                                        LastFunctionMessage

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "<span class=\"oi oi-eye\" aria-hidden=\"true\"></span>\r\n        Checking user authorisation to perform account actions\r\n    ");
            }
            ));
            __builder.AddAttribute(9, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
                __builder2.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 20 "D:\Source\CloudBank\src\Pages\User.razor"
                          accountopenpayload

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 20 "D:\Source\CloudBank\src\Pages\User.razor"
                                                                                         () => CreateAccount()

#line default
#line hidden
                )));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((deposit_context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "form-group ");
                    __builder3.AddMarkupContent(18, "<span class=\"oi oi-key\" aria-hidden=\"true\"></span> Account number:\r\n                ");
                    __builder3.OpenElement(19, "input");
                    __builder3.AddAttribute(20, "placeholder", "Account Number");
                    __builder3.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 24 "D:\Source\CloudBank\src\Pages\User.razor"
                                                                 AccountNumber

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AccountNumber = __value, AccountNumber));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n                ");
                    __builder3.OpenElement(24, "button");
                    __builder3.AddAttribute(25, "class", "btn btn-secondary");
                    __builder3.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 25 "D:\Source\CloudBank\src\Pages\User.razor"
                                                            GenerateRandomAccountNumber

#line default
#line hidden
                    ));
                    __builder3.AddContent(27, "Generate Random Account Number");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n            ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "form-group ");
                    __builder3.AddMarkupContent(31, "<label for=\"clientname\">Client name: </label>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                    __builder3.AddAttribute(33, "id", "clientname");
                    __builder3.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 29 "D:\Source\CloudBank\src\Pages\User.razor"
                                                        accountopenpayload.ClientName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => accountopenpayload.ClientName = __value, accountopenpayload.ClientName))));
                    __builder3.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => accountopenpayload.ClientName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\r\n                ");
                    __Blazor.CloudBank.Pages.User.TypeInference.CreateValidationMessage_0(__builder3, 38, 39, 
#line 30 "D:\Source\CloudBank\src\Pages\User.razor"
                                          () => accountopenpayload.ClientName  

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\r\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "class", "form-group ");
                    __builder3.AddMarkupContent(43, "<label for=\"depositamount\">Opening balance: </label>\r\n                ");
                    __Blazor.CloudBank.Pages.User.TypeInference.CreateInputNumber_1(__builder3, 44, 45, "depositamount", 46, 
#line 34 "D:\Source\CloudBank\src\Pages\User.razor"
                                                             accountopenpayload.OpeningBalance

#line default
#line hidden
                    , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => accountopenpayload.OpeningBalance = __value, accountopenpayload.OpeningBalance)), 48, () => accountopenpayload.OpeningBalance);
                    __builder3.AddMarkupContent(49, "\r\n                ");
                    __Blazor.CloudBank.Pages.User.TypeInference.CreateValidationMessage_2(__builder3, 50, 51, 
#line 35 "D:\Source\CloudBank\src\Pages\User.razor"
                                          () => accountopenpayload.OpeningBalance 

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n            ");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "class", "form-group ");
                    __builder3.AddMarkupContent(55, "<label for=\"comments\">Comments: </label>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(56);
                    __builder3.AddAttribute(57, "id", "comments");
                    __builder3.AddAttribute(58, "class", "w-100");
                    __builder3.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 40 "D:\Source\CloudBank\src\Pages\User.razor"
                                            accountopenpayload.Commentary 

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => accountopenpayload.Commentary  = __value, accountopenpayload.Commentary ))));
                    __builder3.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => accountopenpayload.Commentary ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n                ");
                    __Blazor.CloudBank.Pages.User.TypeInference.CreateValidationMessage_3(__builder3, 63, 64, 
#line 42 "D:\Source\CloudBank\src\Pages\User.razor"
                                          () => accountopenpayload.Commentary 

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n            ");
                    __builder3.AddMarkupContent(66, "<button type=\"submit\" class=\"btn btn-secondary\"><span class=\"oi oi-cloud-upload\" aria-hidden=\"true\"></span>\r\n                Submit\r\n            </button>\r\n            ");
                    __builder3.OpenElement(67, "button");
                    __builder3.AddAttribute(68, "type", "reset");
                    __builder3.AddAttribute(69, "class", "btn btn-secondary");
                    __builder3.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 48 "D:\Source\CloudBank\src\Pages\User.razor"
                                                                       () => accountopenpayload = new AccountOpeningData() 

#line default
#line hidden
                    ));
                    __builder3.AddMarkupContent(71, "<span class=\"oi oi-action-undo\" aria-hidden=\"true\"></span>\r\n                Clear\r\n            ");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(72, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(73, "<span class=\"oi oi-ban\" aria-hidden=\"true\"></span>\r\n        You have no authorisation to create a new account\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(75, "p");
            __builder.AddMarkupContent(76, "<span class=\"oi oi-clock \" aria-hidden=\"true\"></span>&nbsp;Last Run Time: ");
            __builder.AddContent(77, 
#line 62 "D:\Source\CloudBank\src\Pages\User.razor"
                                                                              LastRunTime

#line default
#line hidden
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 64 "D:\Source\CloudBank\src\Pages\User.razor"
       


    [Parameter]
    public string AccountNumber { get; set; } = "";

    [Parameter]
    public string LastFunctionMessage { get; set; } = @"Welcome to Cloudbank.  Connecting...";

    [Parameter]
    public TimeSpan LastRunTime { get; set; }

    [Parameter]
    public AccountOpeningData accountopenpayload { get; set; } = new AccountOpeningData();

    public void GenerateRandomAccountNumber()
    {
        Random rnd = new Random();
        string datepart = DateTime.UtcNow.ToString("yyyyMMddhhmm");


        AccountNumber = $"{Convert.ToChar(rnd.Next(65, 90))}-{datepart}-{Convert.ToChar(rnd.Next(65, 90))}";
    }

    private async Task CreateAccount()
    {
        try
        {
            LastFunctionMessage = $"Creating new account for {accountopenpayload.ClientName}...";
            var result = await retailBankApi.OpenAccount(Http, AccountNumber, accountopenpayload);
            LastFunctionMessage = result.Message;
            LastRunTime = result.ExecutionTime;
        }
        catch (Exception ex)
        {
            LastFunctionMessage = ex.Message;
        }
        this.StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRetailBankApi retailBankApi { get; set; }
    }
}
namespace __Blazor.CloudBank.Pages.User
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
