#pragma checksum "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171406ad356f7c9de244af06a3bf5937412ec0ee"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LibrairieDeComposants.Calendrier.Component.calendrier
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
#line 1 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor"
using System.Globalization;

#line default
#line hidden
#line 2 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor"
using Models;

#line default
#line hidden
#line 3 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 4 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor"
using LibrairieDeComposants.Calendrier.Services;

#line default
#line hidden
#line 5 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor"
using System.Net.Http;

#line default
#line hidden
#line 6 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor"
using DAL;

#line default
#line hidden
#line 7 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor"
using LibrairieDeComposants.Calendrier.Component.semaine;

#line default
#line hidden
    public partial class Calendrier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 82 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier\Component\calendrier\Calendrier.razor"
       
    [Parameter] public String FormatDate { get; set; }
    [Parameter] public String NomCulture { get; set; }


    private IEnumerable<KeyValuePair<int, string>> mois;
    private string note;



    protected override async Task OnParametersSetAsync()
    {
        EtatCalendrier.UseCulture(NomCulture);
        EtatCalendrier.UseDateFormat(FormatDate);
        EtatCalendrier.MoisSelectione = DateTime.Now.Month;

        var dateFormatInfo = EtatCalendrier.Culture.DateTimeFormat;
        mois = Enumerable.Range(1, 12).Select(i => new KeyValuePair<int, string>(i, dateFormatInfo.GetMonthName(i)));

        await base.OnParametersSetAsync();
    }

    private void ReculeUnMois()
    {
        EtatCalendrier.MoisSelectione--;
        ChargerNotes();
    }

    private void AvanceUnMois()
    {
        EtatCalendrier.MoisSelectione++;
        ChargerNotes();
    }

    void OnAfficheModalNote(JourModels jour)
    {
        EtatCalendrier.JourSelectionne = jour;
        JSRuntime.InvokeVoidAsync("ouvrirModal");
    }

    void AjouterNote()
    {
        EtatCalendrier.JourSelectionne.AjouterNote(note);
        JSRuntime.InvokeVoidAsync("fermerModal");
        note = String.Empty;
    }


    private String _apiPath = "api/Notes";

    public void EnregistrerNote()
    {
        //IEnregistrerNote localStore = new WebServiceStorage(HttpClient, _apiPath);
        //localStore.EnregistrerNote(EtatCalendrier.JourSelectionne);
    }

    public void ChargerNotes()
    {
        //IEnregistrerNote localStore = new WebServiceStorage(HttpClient, _apiPath);

        DateTime datedebut = (EtatCalendrier.Calendrier.Semaines.ElementAt(0)?.Jours.ElementAt(0)?.Jour).Value;
        DateTime dateFin = (EtatCalendrier.Calendrier.Semaines.FindLast(x => true)?.Jours.FindLast(x => true).Jour).Value;

        if (datedebut == DateTime.MinValue || dateFin == DateTime.MinValue)
        {
            return;
        }

        //List<NotePersistanceModel> NotesBrutes = localStore.ChargerNotes(datedebut, dateFin);

        List<Note> notes = calendrierContext.Notes.Where(x => true).ToList();

        List<NoteViewModel> NotesBrutes = new List<NoteViewModel>();
        foreach (var item in notes)
        {
            NotesBrutes.Add(new NoteViewModel() { Date = item.Date, Note = item.Message });
        }

        foreach (NoteViewModel NoteBrute in NotesBrutes)
        {
            foreach (var semaine in EtatCalendrier.Calendrier.Semaines)
            {
                JourModels jour = semaine.Jours.Find(j => j.Jour.Year == NoteBrute.Date.Year
                                                        && j.Jour.Month == NoteBrute.Date.Month
                                                        &&j.Jour.Day == NoteBrute.Date.Day);

                if (jour != null)
                {
                    jour.Notes.Add(NoteBrute.Note);
                }
            }
        }

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierContext calendrierContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierStateManager EtatCalendrier { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591