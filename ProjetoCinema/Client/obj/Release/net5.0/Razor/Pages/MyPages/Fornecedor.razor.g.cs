#pragma checksum "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3d02ec1e1ea631d31e1a62bf258ff2eb159f4a"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjetoCinema.Client.Pages.MyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using ProjetoCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using ProjetoCinema.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Shared.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Shared.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using Shared.Singles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using ProjetoCinema.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\_Imports.razor"
using ProjetoCinema.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fornecedor")]
    public partial class Fornecedor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                  fornecedor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                                              Adicionar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.AddMarkupContent(8, "<label>Nome do fornecedor</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "class", "form-control col-3");
                __builder2.AddAttribute(11, "placeholder", "nome");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                                                       fornecedor.NomeFornecedor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fornecedor.NomeFornecedor = __value, fornecedor.NomeFornecedor))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fornecedor.NomeFornecedor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n    <input type=\"submit\" value=\"Adicionar\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table");
            __builder.AddMarkupContent(19, "<thead><tr><th scope=\"col\">Codigo</th>\r\n            <th scope=\"col\">Nome</th></tr></thead>\r\n    ");
            __builder.OpenElement(20, "tbody");
            __builder.OpenComponent<ProjetoCinema.Client.Shared.Lists.ListFornecedor>(21);
            __builder.AddAttribute(22, "listaFornecedores", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProjetoCinema.Server.Models.Fornecedor>>(
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                                                                             listaFornecedores

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                  FormEdicao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "style", "display:" + " " + (
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                      display

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(30);
            __builder.AddAttribute(31, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                      fornecedorEdicao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                                                       Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(34);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n\r\n        ");
                __builder2.AddMarkupContent(38, "<label>Codigo do fornecedor</label>\r\n        ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Fornecedor.TypeInference.CreateInputNumber_0(__builder2, 39, 40, "form-control col-3", 41, "codigo", 42, 
#nullable restore
#line 36 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                                                             fornecedorEdicao.CodFornecedor

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fornecedorEdicao.CodFornecedor = __value, fornecedorEdicao.CodFornecedor)), 44, () => fornecedorEdicao.CodFornecedor);
                __builder2.AddMarkupContent(45, "\r\n\r\n        ");
                __builder2.AddMarkupContent(46, "<label>Nome do fornecedor</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control col-3");
                __builder2.AddAttribute(49, "placeholder", "nome");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
                                                           fornecedorEdicao.NomeFornecedor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fornecedorEdicao.NomeFornecedor = __value, fornecedorEdicao.NomeFornecedor))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fornecedorEdicao.NomeFornecedor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n\r\n        <input type=\"submit\" value=\"Editar\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Fornecedor.razor"
       
    string display = "none";
    public ProjetoCinema.Server.Models.Fornecedor fornecedor { get; set; }
    public ProjetoCinema.Server.Models.Fornecedor fornecedorEdicao { get; set; }
    List<ProjetoCinema.Server.Models.Fornecedor> listaFornecedores;

    protected async override Task OnInitializedAsync()
    {
        fornecedor = new ProjetoCinema.Server.Models.Fornecedor();
        fornecedorEdicao = new ProjetoCinema.Server.Models.Fornecedor();
        listaFornecedores = await fornecedorRepository.GetFornecedores(); ;
        base.OnInitializedAsync();
    }
    private async Task Adicionar()
    {
        //listaFornecedores.Add(fornecedor);
        //fornecedor = new CFornecedor();

        try
        {
            await fornecedorRepository.CreateFornecedor(fornecedor);
            listaFornecedores = await fornecedorRepository.GetFornecedores();
        }
        catch (Exception)
        {

            throw;
        }
    }
    private async Task Editar()
    {
        Console.WriteLine("editando...");
        fornecedorRepository.UpdateFornecedor(fornecedorEdicao);
        listaFornecedores = await fornecedorRepository.GetFornecedores();
        //foreach (CFornecedor fornecedor in listaFornecedores)
        //{
        //    if (fornecedorEdicao.codigo == fornecedor.codigo)
        //    {
        //        fornecedor.nome = fornecedorEdicao.nome;
        //    }
        //}
    }

    void FormEdicao()
    {
        if (display == "none") { display = "block"; } else { display = "none"; }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFornecedorRepository fornecedorRepository { get; set; }
    }
}
namespace __Blazor.ProjetoCinema.Client.Pages.MyPages.Fornecedor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
