#pragma checksum "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dba862c1af9c52afbc0bb4b189286bfe9cc88fa4"
// <auto-generated/>
#pragma warning disable 1591
namespace BookBuddy.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using BookBuddy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\_Imports.razor"
using BookBuddy.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-qdkf0ia5gx");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-qdkf0ia5gx>BookBuddy</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-qdkf0ia5gx");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-qdkf0ia5gx></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 10 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-qdkf0ia5gx");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-qdkf0ia5gx");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-qdkf0ia5gx");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor"
                                                                                 () => SetBackground("bg1")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "<span aria-hidden=\"true\" b-qdkf0ia5gx></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddAttribute(30, "b-qdkf0ia5gx");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "popular-picks");
            __builder.AddAttribute(34, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor"
                                                                     () => SetBackground("bg2")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "id", "genre-link");
            __builder.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "<span aria-hidden=\"true\" b-qdkf0ia5gx></span> Popular Picks\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "nav-item px-3");
            __builder.AddAttribute(41, "b-qdkf0ia5gx");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
            __builder.AddAttribute(44, "href", "Genres");
            __builder.AddAttribute(45, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor"
                                                              () => SetBackground("bg3")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<span aria-hidden=\"true\" b-qdkf0ia5gx></span> Genres\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\vnere\Downloads\BookBuddy (7)\BookBuddy\BookBuddy\Shared\NavMenu.razor"
       
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
