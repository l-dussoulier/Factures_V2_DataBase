// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Facturation_V2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using Facturation_V2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/_Imports.razor"
using Facturation_V2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/Pages/FetchData.razor"
using Facturation_V2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 148 "/Users/louis/Desktop/GitAntoine/Facturation_V2-master/Facturation_V2/Client/Pages/FetchData.razor"
       
    private IEnumerable<Facture> lesFactures = null;
    private FactureDTO factureDTO = new FactureDTO();
    protected override async Task OnInitializedAsync()
    {
        lesFactures = await http.GetFromJsonAsync<IEnumerable<Facture>>("api/factures");
    }

    protected async void SubmitForm()
    {
        var response = await http.PostAsJsonAsync("api/factures", factureDTO);
        navigation.NavigateTo("/fetchdata", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
