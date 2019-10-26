using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CloudBank.Auth
{
    public class DummyAuthStateProvider
        :AuthenticationStateProvider
    {

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity("Clerk");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal( identity ) ) );
        }
    }
}
