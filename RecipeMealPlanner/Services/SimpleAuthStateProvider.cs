using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace RecipeMealPlanner.Services;

public class SimpleAuthStateProvider : AuthenticationStateProvider
{
    private readonly UserSession userSession;

    public SimpleAuthStateProvider(UserSession userSession)
    {
        this.userSession = userSession;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        ClaimsIdentity identity;

        if (userSession.IsLoggedIn)
        {
            identity = new ClaimsIdentity(
                new[]
                {
                    new Claim(ClaimTypes.Name, userSession.UserName)
                },
                "SimpleAuth"
            );
        }
        else
        {
            identity = new ClaimsIdentity();
        }

        var user = new ClaimsPrincipal(identity);
        return Task.FromResult(new AuthenticationState(user));
    }

    public void Login(string username)
    {
        userSession.IsLoggedIn = true;
        userSession.UserName = username;

        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public void Logout()
    {
        userSession.IsLoggedIn = false;
        userSession.UserName = "";

        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}