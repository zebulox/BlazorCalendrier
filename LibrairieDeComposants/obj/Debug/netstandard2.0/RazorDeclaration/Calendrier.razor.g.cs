#pragma checksum "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce08e302d368256c3e7ea49b99c4b461bdb5b50a"
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
#line 1 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 2 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
using Data.Dal;

#line default
#line hidden
    public partial class Calendrier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 153 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
       

    private IEnumerable<KeyValuePair<int, string>> mois;
    private NoteViewModel noteVm;



    protected override async Task OnParametersSetAsync()
    {
        EtatCalendrier.InitDataAccess(calendrierContext);
        EtatCalendrier.MoisSelectione = DateTime.Now.Month;

        var dateFormatInfo = EtatCalendrier.Culture.DateTimeFormat;
        mois = Enumerable.Range(1, 12).Select(i => new KeyValuePair<int, string>(i, dateFormatInfo.GetMonthName(i)));

        noteVm = new NoteViewModel();

        await base.OnParametersSetAsync();
    }

    private void ReculeUnMois()
    {
        EtatCalendrier.MoisSelectione--;
    }

    private void AvanceUnMois()
    {
        EtatCalendrier.MoisSelectione++;
    }

    void OnAfficheModalNote(JourModel jour)
    {
        EtatCalendrier.JourSelectionne = jour;
        JSRuntime.InvokeVoidAsync("ouvrirModal");
    }

    void AjouterNote()
    {
        if (EtatCalendrier.CurrentUser != null)
        {
            noteVm.Date = EtatCalendrier.JourSelectionne.Jour;
            noteVm.CreateurNom = EtatCalendrier.CurrentUser.Login;
            noteVm.CreateurAvatar = EtatCalendrier.CurrentUser.ProfilImage;
            noteVm.DateCreationNote = DateTime.Now;
            //mise à jour de l'interface
            EtatCalendrier.JourSelectionne.AjouterNote(noteVm);
            //mise à jour du store
            EtatCalendrier.EnregistrerNote(noteVm);

            JSRuntime.InvokeVoidAsync("fermerModal");
            noteVm = new NoteViewModel();
        }
    }

    void EffacerNote(NoteViewModel noteVm)
    {
        EtatCalendrier.EffacerNote(noteVm);
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierContext calendrierContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierStateManager EtatCalendrier { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
