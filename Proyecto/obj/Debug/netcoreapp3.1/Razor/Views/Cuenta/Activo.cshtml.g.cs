#pragma checksum "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Activo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ce157404dc3ec45d08616e2ec29b8522abb7059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuenta_Activo), @"mvc.1.0.view", @"/Views/Cuenta/Activo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce157404dc3ec45d08616e2ec29b8522abb7059", @"/Views/Cuenta/Activo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ccd0e355aa1d66d4794e50f98f1a22ffd693d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cuenta_Activo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Activo.cshtml"
  
    ViewData["Title"] = "Activo";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <label>Nombre</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"Nombre\"");
            BeginWriteAttribute("value", " value=\"", 167, "\"", 188, 1);
#nullable restore
#line 8 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Activo.cshtml"
WriteAttributeValue("", 175, Model.Nombre, 175, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n<div class=\"row\">\r\n    <label>Saldo Inicial</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"SaldoInicial\"");
            BeginWriteAttribute("value", " value=\"", 318, "\"", 345, 1);
#nullable restore
#line 12 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Activo.cshtml"
WriteAttributeValue("", 326, Model.SaldoInicial, 326, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n<div class=\"row\">\r\n    <label>Concepto</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"Concepto\"");
            BeginWriteAttribute("value", " value=\"", 466, "\"", 489, 1);
#nullable restore
#line 16 "C:\Users\alciS\Desktop\Proyecto-20200705T210605Z-001\Proyecto\Proyecto\Views\Cuenta\Activo.cshtml"
WriteAttributeValue("", 474, Model.Concepto, 474, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n\r\n\r\n");
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
