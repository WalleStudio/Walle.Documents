#pragma checksum "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "101dc04b0b43ef7b2e9d186ca8e66126f2401736"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Walle.Documents.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using Walle.Documents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\_Imports.razor"
using Walle.Documents.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\GitHub\Walle.Documents\Walle.Documents\Walle.Documents\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
