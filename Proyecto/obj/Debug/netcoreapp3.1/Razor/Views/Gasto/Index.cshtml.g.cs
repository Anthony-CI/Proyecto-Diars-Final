#pragma checksum "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Gasto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9915041bc4146a726afc3e501eebcec1a2a86a9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gasto_Index), @"mvc.1.0.view", @"/Views/Gasto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9915041bc4146a726afc3e501eebcec1a2a86a9e", @"/Views/Gasto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ccd0e355aa1d66d4794e50f98f1a22ffd693d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Gasto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Gasto\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<div>\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 98, "\"", 142, 2);
            WriteAttributeValue("", 105, "/Gasto/Crear?cuentaId=", 105, 22, true);
#nullable restore
#line 8 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Gasto\Index.cshtml"
WriteAttributeValue("", 127, Model.IdCuenta, 127, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">Agregar Gasto</a>
</div>

<div>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Monto</th>

            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 23 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Gasto\Index.cshtml"
             foreach (var gasto in Model.Gastos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Gasto\Index.cshtml"
               Write(gasto.IdGasto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Gasto\Index.cshtml"
               Write(gasto.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Gasto\Index.cshtml"
               Write(gasto.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Gasto\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n<div class=\"form-group\">\r\n    <a class=\"btn btn-primary\" href=\"/cuenta/Index\">Cancelar</a>\r\n</div>\r\n\r\n");
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
