#pragma checksum "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Semaine.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "474bcfb3b74d4c6fc5ce483768379180448dc47a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LibrairieDeComposants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\_Imports.razor"
using Model;

#line default
#line hidden
    public partial class Semaine : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 8 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Semaine.razor"
       
    [Parameter] public SemaineModel semaine { get; set; }
    [Parameter] public EventCallback<JourModel> OnAfficheModalNote { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
