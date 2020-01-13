#pragma checksum "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea1387a10426726471237f674d47247ef71ab5f2"
// <auto-generated/>
#pragma warning disable 1591
namespace LibrairieDeComposants.Calendrier
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
using System.Globalization;

#line default
#line hidden
#line 2 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
using Models;

#line default
#line hidden
    public partial class JourComposant : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm" + " " + (
#line 6 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
                    jour.CssJourClass

#line default
#line hidden
            ) + " jour-moyen");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
                                                              () => OnAfficheModalNote.InvokeAsync(jour)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row h-100");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-sm-12 h-25");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "badge" + " badge-pill" + " " + (
#line 10 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
                                            jour.CssBadgeClass

#line default
#line hidden
            ));
            __builder.AddContent(12, 
#line 10 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
                                                                  jour.Jour.Day

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-sm-12 h-75");
            __builder.AddMarkupContent(17, "\r\n");
#line 14 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
             foreach (var note in jour.Notes)
            {

#line default
#line hidden
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-sm-12");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "note");
            __builder.AddContent(24, 
#line 17 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
                                      note

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#line 19 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
            }

#line default
#line hidden
            __builder.AddContent(27, "            ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "class", "align-bas text-sm-right");
            __builder.AddContent(30, 
#line 20 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
                                                   jour.Jour.ToString(EtatCalendrier.DateFormat, EtatCalendrier.Culture)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 26 "C:\Users\Hadrien\source\repos\BlazorPoc\LibrairieDeComposants\Calendrier\JourComposant.razor"
       
    [Parameter] public JourModels jour { get; set; }
    [Parameter] public EventCallback<JourModels> OnAfficheModalNote { get; set; }


    protected override async Task OnParametersSetAsync()
    {
        jour.CssJourClass = (EtatCalendrier.MoisSelectione == jour.Jour.Month) ? "jour" : "jour-dark";
        jour.CssBadgeClass = (EtatCalendrier.MoisSelectione == jour.Jour.Month) ? "badge-dark" : "badge-secondary";

        await base.OnParametersSetAsync();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierStateManager EtatCalendrier { get; set; }
    }
}
#pragma warning restore 1591
