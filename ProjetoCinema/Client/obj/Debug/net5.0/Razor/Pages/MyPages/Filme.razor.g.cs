#pragma checksum "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4affa1ef5d056500a22bb14d4c8163abdd0253f"
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
#line 3 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/filme")]
    public partial class Filme : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                  filme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
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
                __builder2.AddMarkupContent(7, "\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(8, "<label>Titúlo do filme</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "class", "form-control col-3");
                __builder2.AddAttribute(11, "placeholder", "titúlo");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                       filme.TituloFilme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filme.TituloFilme = __value, filme.TituloFilme))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => filme.TituloFilme));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n    ");
                __builder2.AddMarkupContent(16, "<label>Data de lançamento do filme</label>\r\n    ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputDate_0(__builder2, 17, 18, "form-control col-3", 19, "data", 20, 
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                       filme.Lancamento

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filme.Lancamento = __value, filme.Lancamento)), 22, () => filme.Lancamento);
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.AddMarkupContent(24, "<label>Diretor do filme</label>\r\n    ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputNumber_1(__builder2, 25, 26, "form-control col-3", 27, "diretor", 28, 
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                         filme.CodDiretor

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filme.CodDiretor = __value, filme.CodDiretor)), 30, () => filme.CodDiretor);
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
                __builder2.AddMarkupContent(32, "<label>Gênero do filme</label>\r\n    ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputNumber_2(__builder2, 33, 34, "form-control col-3", 35, "genero", 36, 
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                         filme.CodGenero

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filme.CodGenero = __value, filme.CodGenero)), 38, () => filme.CodGenero);
                __builder2.AddMarkupContent(39, "\r\n\r\n    ");
                __builder2.AddMarkupContent(40, "<label>Fornecedor do filme</label>\r\n    ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputNumber_3(__builder2, 41, 42, "form-control col-3", 43, "fornecedor", 44, 
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                         filme.CodFornecedor

#line default
#line hidden
#nullable disable
                , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filme.CodFornecedor = __value, filme.CodFornecedor)), 46, () => filme.CodFornecedor);
                __builder2.AddMarkupContent(47, "\r\n\r\n\r\n    <input type=\"submit\" value=\"Adicionar\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __builder.OpenElement(49, "table");
            __builder.AddAttribute(50, "class", "table");
            __builder.AddMarkupContent(51, @"<thead><tr><th scope=""col"">Codigo</th>
            <th scope=""col"">Titúlo</th>
            <th scope=""col"">Data de lançamento</th>
            <th scope=""col"">Diretor</th>
            <th scope=""col"">Gênero</th>
            <th scope=""col"">Fornecedor</th></tr></thead>
    ");
            __builder.OpenElement(52, "tbody");
            __builder.OpenComponent<ProjetoCinema.Client.Shared.Lists.ListFIlme>(53);
            __builder.AddAttribute(54, "listaFilmes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProjetoCinema.Server.Models.Filme>>(
#nullable restore
#line 44 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                                  listaFilmes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                  FormEdicao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "style", "display:" + " " + (
#nullable restore
#line 50 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                      display

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(62);
            __builder.AddAttribute(63, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 51 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                      filmeEdicao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 51 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                  Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(66);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(68);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n\r\n        ");
                __builder2.AddMarkupContent(70, "<label>Codigo do filme</label>\r\n        ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputNumber_4(__builder2, 71, 72, "form-control col-3", 73, "codigo", 74, 
#nullable restore
#line 56 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                             filmeEdicao.CodFilme

#line default
#line hidden
#nullable disable
                , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filmeEdicao.CodFilme = __value, filmeEdicao.CodFilme)), 76, () => filmeEdicao.CodFilme);
                __builder2.AddMarkupContent(77, "\r\n\r\n        ");
                __builder2.AddMarkupContent(78, "<label>Titúlo do filme</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "class", "form-control col-3");
                __builder2.AddAttribute(81, "placeholder", "titúlo");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                           filmeEdicao.TituloFilme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filmeEdicao.TituloFilme = __value, filmeEdicao.TituloFilme))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => filmeEdicao.TituloFilme));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n\r\n        ");
                __builder2.AddMarkupContent(86, "<label>Data de lançamento do filme</label>\r\n        ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputDate_5(__builder2, 87, 88, "form-control col-3", 89, "data", 90, 
#nullable restore
#line 62 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                           filmeEdicao.Lancamento

#line default
#line hidden
#nullable disable
                , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filmeEdicao.Lancamento = __value, filmeEdicao.Lancamento)), 92, () => filmeEdicao.Lancamento);
                __builder2.AddMarkupContent(93, "\r\n\r\n        ");
                __builder2.AddMarkupContent(94, "<label>Diretor do filme</label>\r\n        ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputNumber_6(__builder2, 95, 96, "form-control col-3", 97, "diretor", 98, 
#nullable restore
#line 65 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                             filmeEdicao.CodDiretor

#line default
#line hidden
#nullable disable
                , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filmeEdicao.CodDiretor = __value, filmeEdicao.CodDiretor)), 100, () => filmeEdicao.CodDiretor);
                __builder2.AddMarkupContent(101, "\r\n\r\n        ");
                __builder2.AddMarkupContent(102, "<label>Gênero do filme</label>\r\n        ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputNumber_7(__builder2, 103, 104, "form-control col-3", 105, "genero", 106, 
#nullable restore
#line 68 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                             filmeEdicao.CodGenero

#line default
#line hidden
#nullable disable
                , 107, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filmeEdicao.CodGenero = __value, filmeEdicao.CodGenero)), 108, () => filmeEdicao.CodGenero);
                __builder2.AddMarkupContent(109, "\r\n\r\n        ");
                __builder2.AddMarkupContent(110, "<label>Fornecedor do filme</label>\r\n        ");
                __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme.TypeInference.CreateInputNumber_8(__builder2, 111, 112, "form-control col-3", 113, "fornecedor", 114, 
#nullable restore
#line 71 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
                                                             filme.CodFornecedor

#line default
#line hidden
#nullable disable
                , 115, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filme.CodFornecedor = __value, filme.CodFornecedor)), 116, () => filme.CodFornecedor);
                __builder2.AddMarkupContent(117, "\r\n\r\n        <input type=\"submit\" value=\"Editar\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Administrator\source\repos\ProjetoCinema\ProjetoCinema\Client\Pages\MyPages\Filme.razor"
       
    string display = "none";
    public ProjetoCinema.Server.Models.Filme filme { get; set; }
    public ProjetoCinema.Server.Models.Filme filmeEdicao { get; set; }
    List<ProjetoCinema.Server.Models.Filme> listaFilmes;

    protected async override Task OnInitializedAsync()
    {
        filme = new ProjetoCinema.Server.Models.Filme();
        filmeEdicao = new ProjetoCinema.Server.Models.Filme();
        listaFilmes = await filmeRepository.GetFilmes();
        base.OnInitializedAsync();
    }
    private async Task Adicionar()
    {
        try
        {
            await filmeRepository.CreateFilme(filme);
            listaFilmes = await filmeRepository.GetFilmes();
        }
        catch (Exception)
        {

            throw;
        }
        //listaFilmes.Add(filme);
        //filme = new CFilme();
    }
    private async Task Editar()
    {
        Console.WriteLine("editando...");

        Console.WriteLine("editando...");
        filmeRepository.UpdateFilmes(filmeEdicao);
        listaFilmes = await filmeRepository.GetFilmes();
        //foreach (CFilme filme in listaFilmes)
        //{
        //    if (filmeEdicao.codigo == filme.codigo)
        //    {
        //        filme.titulo = filmeEdicao.titulo;
        //        filme.diretor = filmeEdicao.diretor;
        //        filme.data = filmeEdicao.data;
        //        filme.fornecedor = filmeEdicao.fornecedor;
        //        filme.genero = filmeEdicao.genero;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFilmeRepository filmeRepository { get; set; }
    }
}
namespace __Blazor.ProjetoCinema.Client.Pages.MyPages.Filme
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
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
