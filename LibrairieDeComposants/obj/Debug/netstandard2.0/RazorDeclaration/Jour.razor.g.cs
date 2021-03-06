#pragma checksum "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Jour.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4962743b42be0d83ad3a6684c8947cc942fb11b"
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
    public partial class Jour : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 25 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Jour.razor"
       
    [Parameter] public JourModel jour { get; set; }
    [Parameter] public EventCallback<JourModel> OnAfficheModalNote { get; set; }


    protected override async Task OnParametersSetAsync()
    {
        jour.CssJourClass = (EtatCalendrier.MoisSelectione == jour.Jour.Month) ? "jour" : "jour-dark";
        jour.CssBadgeClass = (EtatCalendrier.MoisSelectione == jour.Jour.Month) ? "badge-dark" : "badge-secondary";

        //init le jours courant
        if (DateTime.Now.Day == jour.Jour.Day
         && DateTime.Now.Month == jour.Jour.Month
         && DateTime.Now.Year == jour.Jour.Year)
        {
            jour.CssJourClass += " text-info";
            jour.CssBadgeClass = "badge-info";
        }

        await base.OnParametersSetAsync();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierStateManager EtatCalendrier { get; set; }
    }
}
#pragma warning restore 1591
