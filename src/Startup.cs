using CloudBank.RetailBank;
using CloudBank.Services;
using Microsoft.AspNetCore.Blazor.Http;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Authorization;
using CloudBank.Auth;
using Blazored.Modal;

namespace CloudBank
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Modal forms
            services.AddBlazoredModal();

            // Bank account API
            services.AddSingleton<IBankAccount, BankAccount>();
            services.AddScoped <IRetailBankApi, RetailBankApiNoHttp>();

            // Authorisation
            services.AddAuthorizationCore(); 
            services.AddSingleton<AuthenticationStateProvider, DummyAuthStateProvider>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {

            WebAssemblyHttpMessageHandler.DefaultCredentials = FetchCredentialsOption.Include;

            app.AddComponent<App>("app"); 
        }
    }
}
