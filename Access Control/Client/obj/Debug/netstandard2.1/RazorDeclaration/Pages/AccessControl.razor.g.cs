// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Access_Control.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using Access_Control.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\_Imports.razor"
using Access_Control.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/accesscontrol")]
    public partial class AccessControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "C:\Users\dborges\source\repos\Access Control\Access Control\Client\Pages\AccessControl.razor"
       
    List<UserDto> ecList = new List<UserDto>() {
        new UserDto
        {
            Id = 1,
            Email = "diego@hotmail.com",
            Nome = "Diego",
            Permissao = new PermissaoDto
            {
                Id = 1,
                Nome = "Spotter",
                Permissao = true
            }
        },
                new UserDto
        {
            Id = 2,
            Email = "diego2@hotmail.com",
            Nome = "Diego2",
            Permissao = new PermissaoDto
            {
                Id = 2,
                Nome = "Spotter2",
                Permissao = true
            }
        },
                                new UserDto
        {
            Id = 3,
            Email = "teste@hotmail.com",
            Nome = "teste",
            Permissao = new PermissaoDto
            {
                Id = 3,
                Nome = "SpotterApi",
                Permissao = false
            }
        },
        };
    string txtNomeEmpresa;
    string txtUsuario;
    string txtIdEmpresa;
    bool? empresaAtiva = null;
    bool BuscarDisabled = false;

    class UserDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public PermissaoDto Permissao { get; set; }
    }

    class PermissaoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Permissao { get; set; }
    }

    public async Task AddTags()
    {

        try
        {

            await ShowAlert("Operação realizada com sucesso");

        }
        catch (Exception ex)
        {
            await ShowAlert(ex.Message);
        }

        base.StateHasChanged();
    }

    public async Task Buscar()
    {
        try
        {
            ecList = ecList.Where(x => x.Nome == txtUsuario).ToList();
        }
        catch (Exception ex)
        {
            await ShowAlert(ex.Message);
        }

        //base.StateHasChanged();
    }

    public void Limpar()
    {
        ecList = new List<UserDto>();

        base.StateHasChanged();
    }

    public async Task KeyWasPressed(KeyboardEventArgs args)
    {
        if (args.Code == "Enter" || args.Code == "NumpadEnter")
        {
            await Buscar();
        }
    }

    private async Task ShowAlert(string pMessage)
    {
        await jsRuntime.InvokeAsync<object>
            ("ShowAlert", pMessage);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591