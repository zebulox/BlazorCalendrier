#pragma checksum "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\Composants\Calendrier\Semaine\SemaineVue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "072275a997dbaab27d5493f438aa90c424dc5997"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Calendrier.Composants.Calendrier.Semaine
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using Calendrier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\_Imports.razor"
using Calendrier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\Composants\Calendrier\Semaine\SemaineVue.razor"
using Calendrier.Jour;

#line default
#line hidden
#nullable disable
    public partial class SemaineVue : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Hadrien\source\repos\Calendrier\Calendrier\Composants\Calendrier\Semaine\SemaineVue.razor"
       
    [Parameter] public SemaineModel semaine { get; set; }
    [Parameter] public EventCallback<JourModel> OnAfficheModalNote { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591