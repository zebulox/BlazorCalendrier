#pragma checksum "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\CalendrierPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501d54089a14b3a19b9b4aa5cb3824eee5db9dec"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\CalendrierPage.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\CalendrierPage.razor"
using LibrairieDeComposants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\CalendrierPage.razor"
using LibrairieDeComposants.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calendrier")]
    public partial class CalendrierPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\CalendrierPage.razor"
 if (EtatCalendrier.CurrentUser != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<LibrairieDeComposants.Calendrier>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 13 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\CalendrierPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Hadrien\source\repos\BlazorPoc\BlazorCalendrier\Calendrier\Pages\CalendrierPage.razor"
       
    //public String FormatDate = "dddd, d-MMM-yy";
    //public String FormatDate = "dd/MM/yyyy";
    //public String NomCulture = "fr-FR";

    public String FormatDate { get; set; }
    public String NomCulture { get; set; }
    public String ShortdateFormat { get; set; }

    //public String FormatDate = "MMM-d-yy ";
    //public String NomCulture = "en-US";


    protected override async Task OnParametersSetAsync()
    {
        NomCulture = "fr-FR";
        FormatDate = "dddd, d-MMM-yy";
        ShortdateFormat = "dd/MM/yyyy";

        EtatCalendrier.UseCulture(NomCulture);
        EtatCalendrier.UseDateFormat(FormatDate);
        EtatCalendrier.UseShortDateFormat(ShortdateFormat);

        if (EtatCalendrier.CurrentUser == null)
        {
            MyNavigationManager.NavigateTo("login");
        }
        await base.OnParametersSetAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalendrierStateManager EtatCalendrier { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager MyNavigationManager { get; set; }
    }
}
#pragma warning restore 1591
