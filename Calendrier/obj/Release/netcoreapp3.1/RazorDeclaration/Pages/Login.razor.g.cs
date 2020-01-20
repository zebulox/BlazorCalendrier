#pragma checksum "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "578e423d52a2bb1846735729e36c264d2529add1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Calendrier.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using Calendrier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\_Imports.razor"
using Calendrier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\Login.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\Login.razor"
using Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\Login.razor"
using Data.Dal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\Login.razor"
using LibrairieDeComposants;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\Login.razor"
       
    public String UserLogin { get; set; }
    public String UserMotDePasse { get; set; }
    public bool CreateAccount { get; set; }

    //is-invalid
    private String formInvalid;
    private bool erreurConnexion;
    private bool erreurCreationCompte;


    protected override async Task OnParametersSetAsync()
    {
        AfficheErreurConnexion(false);
        AfficheErreurCreation(false);

        await base.OnParametersSetAsync();
    }


    public void LogUser()
    {
        Utilisateur utilisateur = new Utilisateur() { Login = UserLogin, MotDePasse = UserMotDePasse };
        EntityFrameworkStorage store = new EntityFrameworkStorage(calendrierContext);

        if (CreateAccount)
        {
            if (store.CheckLoginAvailability(utilisateur))
            {
                store.CréerUtilisateur(utilisateur);

                AfficheErreurConnexion(false);
                AfficheErreurCreation(false);
            }
            //retours interface création compte KO
            else
            {
                AfficheErreurConnexion(false);
                AfficheErreurCreation(true);
            }
        }
        else
        {
            if (store.LogIn(utilisateur.Login, utilisateur.MotDePasse))
            {
                EtatCalendrier.CurrentUser = store.GetUtilisateur(utilisateur.Login, utilisateur.MotDePasse);
                AfficheErreurConnexion(false);
                AfficheErreurCreation(false);
                MyNavigationManager.NavigateTo("calendrier");
            }
            //retours interface login KO plus propose créer compte
            else
            {
                AfficheErreurCreation(false);
                AfficheErreurConnexion(true);
            }
        }
    }

    private void AfficheErreurConnexion(bool affiche)
    {
        erreurConnexion = affiche;
        formInvalid = (affiche)?"is-invalid":String.Empty;
    }

    private void AfficheErreurCreation(bool affiche)
    {
        erreurCreationCompte = affiche;
        formInvalid = (affiche)?"is-invalid":String.Empty;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierStateManager EtatCalendrier { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierContext calendrierContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager MyNavigationManager { get; set; }
    }
}
#pragma warning restore 1591
