#pragma checksum "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a114b7ddb58c2a29055e644027341780c223cdb"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row justify-content-md-center");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-sm text-sm-right");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-secondary");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                      ReculeUnMois

#line default
#line hidden
            ));
            __builder.AddMarkupContent(13, "<span class=\"material-icons\">fast_rewind</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-sm");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "id", "mois");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 18 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                              EtatCalendrier.MoisSelectione

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EtatCalendrier.MoisSelectione = __value, EtatCalendrier.MoisSelectione));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(27, "\r\n");
#line 19 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                     foreach (var m in mois)
                    {
                        if (m.Key == EtatCalendrier.MoisSelectione)
                        {

#line default
#line hidden
            __builder.AddContent(28, "                            ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", 
#line 23 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                             m.Key

#line default
#line hidden
            );
            __builder.AddAttribute(31, "selected", true);
            __builder.AddContent(32, 
#line 23 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                m.Value

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#line 24 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                        }
                        else
                        {

#line default
#line hidden
            __builder.AddContent(34, "                            ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", 
#line 27 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                             m.Key

#line default
#line hidden
            );
            __builder.AddContent(37, 
#line 27 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                       m.Value

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#line 28 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                        }
                    }

#line default
#line hidden
            __builder.AddContent(39, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-secondary");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 34 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                      AvanceUnMois

#line default
#line hidden
            ));
            __builder.AddMarkupContent(50, "<span class=\"material-icons\">fast_forward</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n");
#line 38 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
     foreach (var semaine in EtatCalendrier.Calendrier.Semaines)
    {

#line default
#line hidden
            __builder.AddContent(54, "        ");
            __builder.OpenComponent<LibrairieDeComposants.Semaine>(55);
            __builder.AddAttribute(56, "semaine", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LibrairieDeComposants.Model.SemaineModel>(
#line 40 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                          semaine

#line default
#line hidden
            ));
            __builder.AddAttribute(57, "OnAfficheModalNote", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<LibrairieDeComposants.Model.JourModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<LibrairieDeComposants.Model.JourModel>(this, 
#line 40 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                       OnAfficheModalNote

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n");
#line 41 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(59, "\r\n\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal");
            __builder.AddAttribute(62, "id", "myModal");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-dialog");
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-content");
            __builder.AddMarkupContent(69, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "modal-header");
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "h4");
            __builder.AddAttribute(74, "class", "modal-title");
            __builder.AddContent(75, "Ajouter une note le ");
            __builder.AddContent(76, 
#line 50 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                 EtatCalendrier.JourSelectionne.Jour.ToString(EtatCalendrier.DateFormat, EtatCalendrier.Culture)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.AddMarkupContent(78, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "modal-body");
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "id", "accordion");
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "card");
            __builder.AddMarkupContent(88, "\r\n                            ");
            __builder.AddMarkupContent(89, @"<div class=""card-header"" id=""headingOne"">
                                <h5 class=""mb-0"">
                                    <button class=""btn btn-link"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                        Ecrire une note
                                    </button>
                                </h5>
                            </div>

                            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "id", "collapseOne");
            __builder.AddAttribute(92, "class", "collapse show");
            __builder.AddAttribute(93, "aria-labelledby", "headingOne");
            __builder.AddAttribute(94, "data-parent", "#accordion");
            __builder.AddMarkupContent(95, "\r\n                                ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "card-body");
            __builder.AddMarkupContent(98, "\r\n                                    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "form-group");
            __builder.AddMarkupContent(101, "\r\n                                        ");
            __builder.AddMarkupContent(102, "<label for=\"exampleFormControlTextarea1\"> <span class=\"material-icons\">edit</span> Note :</label>\r\n                                        ");
            __builder.OpenElement(103, "textarea");
            __builder.AddAttribute(104, "class", "form-control");
            __builder.AddAttribute(105, "id", "exampleFormControlTextarea1");
            __builder.AddAttribute(106, "rows", "3");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 70 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                                                                        noteVm.Note

#line default
#line hidden
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => noteVm.Note = __value, noteVm.Note));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\r\n");
#line 74 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                 if (EtatCalendrier.CurrentUser != null)
                                {

#line default
#line hidden
            __builder.AddContent(112, "                                    ");
            __builder.OpenElement(113, "button");
            __builder.AddAttribute(114, "type", "button");
            __builder.AddAttribute(115, "class", "btn btn-dark float-right mb-5");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 76 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                                                          AjouterNote

#line default
#line hidden
            ));
            __builder.AddContent(117, "Ajouter : ");
            __builder.AddMarkupContent(118, "<span class=\"material-icons\">done_outline</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
#line 77 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                }
                                else
                                {

#line default
#line hidden
            __builder.AddContent(120, "                                    ");
            __builder.AddMarkupContent(121, "<button type=\"button\" class=\"btn btn-dark float-right mb-5\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Vous devez vous connecter avant de créer une note\" disabled>Ajouter : <span class=\"material-icons\">done_outline</span></button>\r\n");
#line 81 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                }

#line default
#line hidden
            __builder.AddMarkupContent(122, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "card");
            __builder.AddMarkupContent(127, "\r\n                            ");
            __builder.AddMarkupContent(128, @"<div class=""card-header"" id=""headingTwo"">
                                <h5 class=""mb-0"">
                                    <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                        Voir les notes
                                    </button>
                                </h5>
                            </div>
                            ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "id", "collapseTwo");
            __builder.AddAttribute(131, "class", "collapse");
            __builder.AddAttribute(132, "aria-labelledby", "headingTwo");
            __builder.AddAttribute(133, "data-parent", "#accordion");
            __builder.AddMarkupContent(134, "\r\n                                ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "card-body");
            __builder.AddMarkupContent(137, "\r\n\r\n                                        ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "card-columns");
            __builder.AddMarkupContent(140, "\r\n");
#line 97 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                             foreach (var note in EtatCalendrier.JourSelectionne.Notes)
                                            {


#line default
#line hidden
            __builder.AddContent(141, "                                                ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "card");
            __builder.AddAttribute(144, "style", "width: 100%;");
            __builder.AddMarkupContent(145, "\r\n                                                    ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "card-header");
            __builder.AddMarkupContent(148, "\r\n                                                        ");
            __builder.OpenElement(149, "h5");
            __builder.AddAttribute(150, "class", "card-title");
            __builder.AddMarkupContent(151, "\r\n                                                            ");
            __builder.OpenElement(152, "img");
            __builder.AddAttribute(153, "src", 
#line 103 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                        note.CreateurAvatar

#line default
#line hidden
            );
            __builder.AddAttribute(154, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddContent(155, " (");
            __builder.AddContent(156, 
#line 103 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                                                                       note.CreateurNom

#line default
#line hidden
            );
            __builder.AddMarkupContent(157, ")\r\n                                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                                                    ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "card-body");
            __builder.AddMarkupContent(162, "\r\n                                                        ");
            __builder.OpenElement(163, "p");
            __builder.AddAttribute(164, "class", "card-text");
            __builder.AddContent(165, 
#line 107 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                               note.Note

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                                                        ");
            __builder.OpenElement(167, "a");
            __builder.AddAttribute(168, "href", "#");
            __builder.AddContent(169, 
#line 108 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                      note.DateCreationNote.ToString(EtatCalendrier.ShortdateFormat, EtatCalendrier.Culture)

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n");
#line 110 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                     if (EtatCalendrier.CurrentUser.Login == note.CreateurNom)
                                                    {

#line default
#line hidden
            __builder.AddContent(172, "                                                ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "card-footer");
            __builder.AddMarkupContent(175, "\r\n                                                    ");
            __builder.OpenElement(176, "button");
            __builder.AddAttribute(177, "type", "button");
            __builder.AddAttribute(178, "class", "btn btn-sm btn-dark float-right mb-2");
            __builder.AddAttribute(179, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 113 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                                                                                                   e => EffacerNote(note)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(180, "\r\n                                                        ");
            __builder.AddMarkupContent(181, "<span class=\"material-icons\">delete</span>\r\n                                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n");
#line 117 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                                    }

#line default
#line hidden
            __builder.AddContent(184, "                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n");
#line 119 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
                                            }

#line default
#line hidden
            __builder.AddContent(186, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n\r\n                \r\n                ");
            __builder.AddMarkupContent(193, "<div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn\" data-dismiss=\"modal\">Fermer</button>\r\n                </div>\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 142 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\LibrairieDeComposants\Calendrier.razor"
       

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