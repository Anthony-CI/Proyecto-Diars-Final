#pragma checksum "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378a2f100db492e9653ffb2d8753a2871b10ab3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuenta_Index), @"mvc.1.0.view", @"/Views/Cuenta/Index.cshtml")]
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
#line 1 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\_ViewImports.cshtml"
using Proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\_ViewImports.cshtml"
using Proyecto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378a2f100db492e9653ffb2d8753a2871b10ab3b", @"/Views/Cuenta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ccd0e355aa1d66d4794e50f98f1a22ffd693d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cuenta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <a class=""btn btn-primary"" href=""/Cuenta/Crear"" role=""button"">Crear Cuenta</a>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>

            <th scope=""col"">Tipo Cuenta</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Entidad Emisora</th>
            <th scope=""col"">Saldo Inicial</th>
            <th scope=""col"">Gastos</th>


        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 25 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
         foreach (var cuenta in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
           Write(cuenta.IdCuenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 30 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
           Write(cuenta.TipoCuenta.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
           Write(cuenta.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
           Write(cuenta.EntidadEmidora.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
           Write(cuenta.SaldoInicial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 818, "\"", 863, 2);
            WriteAttributeValue("", 825, "/Gasto/index?cuentaId=", 825, 22, true);
#nullable restore
#line 35 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
WriteAttributeValue("", 847, cuenta.IdCuenta, 847, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Gastos</a>\r\n\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591