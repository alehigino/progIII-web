#pragma checksum "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e6082240a12b767390932d02ed3cbbd70b8048"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacientes_Index), @"mvc.1.0.view", @"/Views/Pacientes/Index.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\_ViewImports.cshtml"
using pacientesPessoas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\_ViewImports.cshtml"
using pacientesPessoas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e6082240a12b767390932d02ed3cbbd70b8048", @"/Views/Pacientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdb8addc0c1ba395f400ac2b5a41f8383492953", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<pacientesPessoas.Models.Pacientes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
  
    ViewData["Title"] = "Teste";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Lista de pacientes</h2>\r\n<div class=\"container\">\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>");
#nullable restore
#line 10 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 11 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.idPessoa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 12 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.data_entrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 13 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.comorbidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 14 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.grau));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>...</th>\r\n        </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.idPessoa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.data_entrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.comorbidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.grau));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1061, "\"", 1124, 2);
            WriteAttributeValue("", 1068, "Pacientes/Excluir/", 1068, 18, true);
#nullable restore
#line 26 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
WriteAttributeValue("", 1086, Html.DisplayFor(modelItem => item.id), 1086, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Excluir</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1184, "\"", 1246, 2);
            WriteAttributeValue("", 1191, "Pacientes/Editar/", 1191, 17, true);
#nullable restore
#line 27 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
WriteAttributeValue("", 1208, Html.DisplayFor(modelItem => item.id), 1208, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Usuario\Desktop\Sistemas de Informação\5º Período\Programação III\pacientesPessoas\Views\Pacientes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<pacientesPessoas.Models.Pacientes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
