#pragma checksum "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a97342f21fd1a6aea4f4f6a0369c0f75739d6a62"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_B2C.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using BlazorApp_B2C;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\_Imports.razor"
using BlazorApp_B2C.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "a");
                __builder2.AddAttribute(3, "href", "MicrosoftIdentity/Account/EditProfile");
                __builder2.AddMarkupContent(4, "\r\n            Hello ");
#nullable restore
#line 4 "C:\Users\juguerra\source\repos\Blazor_B2C\BlazorApp_B2C\Shared\LoginDisplay.razor"
__builder2.AddContent(5, context.User.Claims.FirstOrDefault(c => c.Type.Contains("givenname"))?.Value);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<a href=\"MicrosoftIdentity/Account/Signout\">Log Out</a>");
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "<a href=\"MicrosoftIdentity/Account/SignIn\">Log In</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
