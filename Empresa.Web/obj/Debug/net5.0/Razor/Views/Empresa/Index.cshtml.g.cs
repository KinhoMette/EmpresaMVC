#pragma checksum "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a69d97e9d446c03f7f0b31bca83f2dcb59a347d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Index), @"mvc.1.0.view", @"/Views/Empresa/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\_ViewImports.cshtml"
using Empresa.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\_ViewImports.cshtml"
using Empresa.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a69d97e9d446c03f7f0b31bca83f2dcb59a347d9", @"/Views/Empresa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58d62d995c3b19af6774b1aac3f1461b0823b05a", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Empresa.Dominio.Models.PaginatedList<Empresa.Dominio.Entidades.EmpresaModelo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"main-content\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a69d97e9d446c03f7f0b31bca83f2dcb59a347d94337", async() => {
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-4"">
                <label for=""nomeFantasia"">Nome Fantasia</label>
                <input name=""NomeFantasia"" type=""text"" class=""form-control"" id=""nomeFantasia"">
            </div>
            <div class=""form-group col-md-4"">
                <label for=""cnpj"">CNPJ</label>
                <input name=""CNPJ"" type=""text"" class=""form-control"" id=""cnpj"">
            </div>
            <div class=""form-group col-md-3"">
                <label for=""inputState"">Situação</label>
                <select name=""Situacao"" id=""inputState"" class=""form-control"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a69d97e9d446c03f7f0b31bca83f2dcb59a347d95289", async() => {
                    WriteLiteral("Escolha");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a69d97e9d446c03f7f0b31bca83f2dcb59a347d96647", async() => {
                    WriteLiteral("Ativo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a69d97e9d446c03f7f0b31bca83f2dcb59a347d97889", async() => {
                    WriteLiteral("Inativo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <input type=\"submit\" value=\"Filtrar\" class=\"btn btn-primary\" style=\"width: 86px; height: 34px; padding-top: 5px; margin-top: 35px;\">\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 4 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
AddHtmlAttributeValue("", 134, Url.Action("Index", "Empresa"), 134, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#Modal"" style=""margin-bottom: 10px;"">
        Criar empresa
    </button>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Nome Fantasia</th>
                <th scope=""col"">CNPJ</th>
                <th scope=""col"">Situação</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 37 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"accordion\">\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
                   Write(item.NomeFantasia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
                   Write(item.CNPJ);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
                    Write(item.Situacao ? "Ativo" : "Inativo");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td class=""text-center"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-arrow-down"" viewBox=""0 0 16 16"">
                            <path fill-rule=""evenodd"" d=""M8 1a.5.5 0 0 1 .5.5v11.793l3.146-3.147a.5.5 0 0 1 .708.708l-4 4a.5.5 0 0 1-.708 0l-4-4a.5.5 0 0 1 .708-.708L7.5 13.293V1.5A.5.5 0 0 1 8 1z"" />
                        </svg>
                    </td>
                </tr>
                <tr class=""panel"">
                    <td>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2475, "\"", 2537, 1);
#nullable restore
#line 51 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
WriteAttributeValue("", 2482, Url.Action("Alterar", "Empresa", new { id = item.Id }), 2482, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">\r\n                            Alterar\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2660, "\"", 2755, 1);
#nullable restore
#line 54 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
WriteAttributeValue("", 2667, Url.Action("AlteraSituacao", "Empresa", new { id = item.Id, situacao = item.Situacao }), 2667, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\r\n                            Alterar situação\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2885, "\"", 2947, 1);
#nullable restore
#line 57 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
WriteAttributeValue("", 2892, Url.Action("Deletar", "Empresa", new { id = item.Id }), 2892, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\r\n                            Deletar\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 62 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <!-- Modal -->
    <div class=""modal fade"" id=""Modal"" tabindex=""-1"" aria-labelledby=""ModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""ModalLabel"">Cadastro de empresa</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a69d97e9d446c03f7f0b31bca83f2dcb59a347d915632", async() => {
                WriteLiteral(@"
                    <div class=""form-row"" style=""padding-left: 30px;"">
                        <div class=""form-group col-md-6"">
                            <label for=""inputEmail4"">Nome Fantasia</label>
                            <input name=""NomeFantasia"" type=""text"" class=""form-control"" id=""ema"">
                        </div>
                        <div class=""form-group col-md-5"">
                            <label for=""cnpj"">CNPJ</label>
                            <input name=""CNPJ"" type=""text"" class=""form-control"" id=""cnpj"">
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                        <button type=""submit"" class=""btn btn-primary"">Salvar</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 76 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
AddHtmlAttributeValue("", 3718, Url.Action("Criar", "Empresa"), 3718, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Paginação -->\r\n    <nav aria-label=\"Page navigation\">\r\n        <ul class=\"pagination\">\r\n");
#nullable restore
#line 99 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
             if (Model.HasPreviousPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4943, "\"", 5198, 1);
#nullable restore
#line 102 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
WriteAttributeValue("", 4950, Url.Action("Index", new { pageNumber = Model.PageIndex - 1, nomeFantasia = ViewContext.HttpContext.Request.Query["nomeFantasia"], cnpj = ViewContext.HttpContext.Request.Query["cnpj"], situacao = ViewContext.HttpContext.Request.Query["situacao"] }), 4950, 248, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n                </li>\r\n");
#nullable restore
#line 104 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
             for (int i = 1; i <= Model.TotalPages; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 5344, "\"", 5401, 2);
            WriteAttributeValue("", 5352, "page-item", 5352, 9, true);
#nullable restore
#line 107 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
WriteAttributeValue(" ", 5361, i == Model.PageIndex ? "active" : "", 5362, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5445, "\"", 5682, 1);
#nullable restore
#line 108 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
WriteAttributeValue("", 5452, Url.Action("Index", new { pageNumber = i, nomeFantasia = ViewContext.HttpContext.Request.Query["nomeFantasia"], cnpj = ViewContext.HttpContext.Request.Query["cnpj"], situacao = ViewContext.HttpContext.Request.Query["situacao"] }), 5452, 230, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 108 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
                                                                                                                                                                                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 110 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
             if (Model.HasNextPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5862, "\"", 6117, 1);
#nullable restore
#line 114 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
WriteAttributeValue("", 5869, Url.Action("Index", new { pageNumber = Model.PageIndex + 1, nomeFantasia = ViewContext.HttpContext.Request.Query["nomeFantasia"], cnpj = ViewContext.HttpContext.Request.Query["cnpj"], situacao = ViewContext.HttpContext.Request.Query["situacao"] }), 5869, 248, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n                </li>\r\n");
#nullable restore
#line 116 "C:\Users\84961\source\Apex\EmpresaMvc\Empresa.Web\Views\Empresa\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </nav>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Empresa.Dominio.Models.PaginatedList<Empresa.Dominio.Entidades.EmpresaModelo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
