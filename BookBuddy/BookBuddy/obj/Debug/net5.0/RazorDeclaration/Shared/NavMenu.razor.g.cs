// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookBuddy.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using BookBuddy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\_Imports.razor"
using BookBuddy.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\vnere\OneDrive\Desktop\FPBF\BookBuddy\BookBuddy\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    private string backgroundClass = "";

    private async Task SetBackground(string className)
    {
        await JSRuntime.InvokeVoidAsync("changeBackgroundImage", className);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
