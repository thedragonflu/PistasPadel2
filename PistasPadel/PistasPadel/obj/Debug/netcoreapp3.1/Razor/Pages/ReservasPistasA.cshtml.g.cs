#pragma checksum "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c48d42849853cda888900703395baf47dd838248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PistasPadel.Pages.Pages_ReservasPistasA), @"mvc.1.0.razor-page", @"/Pages/ReservasPistasA.cshtml")]
namespace PistasPadel.Pages
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
#line 1 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\_ViewImports.cshtml"
using PistasPadel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c48d42849853cda888900703395baf47dd838248", @"/Pages/ReservasPistasA.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a857f7d8d0ed1ccd039a80c6d41cfcf8e8ba67b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ReservasPistasA : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
  
    ViewData["Title"] = "ReservasPistas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Reservas Pistas A</h1>

<div class=""container row"" id=""titulo"">
    <div class=""col-6"">
        <h2 class=""text-info"">Reservas Pistas</h2>
    </div>
    <br />
</div>
<br />
<div class=""4"" id=""fechaPadre"">
    <input id=""fecha"" type=""date""
           min=""0-0-0""
           max=""0-0-0"" />
    <input id=""button"" type=""button"" onclick=""buscarHoras()"" value=""Buscar Horas"" />
</div>
<br />
<div class=""row text-center"" id=""cuadroTexto"">
    <div class=""alert alert-info text-center invisible"" style=""width: 100%"" id=""alerta"">
        <p id=""mensaje""></p>
        <a class=""btn btn-success"" id=""btnAceptar1"">Aceptar</a>
        <a class=""btn btn-success invisible"" id=""btnAceptar2"" onclick=""hacerInvisible()"">Aceptar</a>
        <a class=""btn btn-success invisible"" id=""btnAceptar3"">Aceptar</a>
        <a class=""btn btn-danger invisible"" id=""btnCancelar3"" onclick=""hacerInvisible()"">Cancelar</a>
        <a class=""btn btn-danger invisible"" id=""btnCancelar2"" onclick=""hacerVisible()"">Cancelar</a>");
            WriteLiteral(@"
        <a class=""btn btn-danger"" id=""btnCancelar1"" onclick=""cambiarSalirSinReservar()"">Cancelar</a>
    </div>
</div>
<br />
<div id=""horas"" style=""padding: 4px;
            width: 100%;
            height: 550px;
            overflow: auto;"">

");
            WriteLiteral("    <table class=\"table table-striped border\">\r\n        <tr id=\"nombres\" class=\"table-secondary\">\r\n            <th>Hora</th>\r\n            <th>Estado</th>\r\n            <th>Reservas</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
         for (var i = 9; i <= 21; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr id=\"horasHijo\">\r\n                <td>");
#nullable restore
#line 51 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(":00</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 1788, "\"", 1797, 2);
#nullable restore
#line 52 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
WriteAttributeValue("", 1793, i, 1793, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1795, "-h", 1795, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Libre</td>\r\n                <td>\r\n                    <a class=\"btn btn-success btn-sm\" style=\"color:white\"");
            BeginWriteAttribute("id", " id=\"", 1906, "\"", 1918, 2);
#nullable restore
#line 54 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
WriteAttributeValue("", 1911, i, 1911, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1913, "-btn1", 1913, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1919, "\"", 1961, 7);
            WriteAttributeValue("", 1929, "reserva(this,", 1929, 13, true);
            WriteAttributeValue(" ", 1942, "\'", 1943, 2, true);
#nullable restore
#line 54 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
WriteAttributeValue("", 1944, i, 1944, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1946, "-h\',", 1946, 4, true);
            WriteAttributeValue(" ", 1950, "\'", 1951, 2, true);
#nullable restore
#line 54 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
WriteAttributeValue("", 1952, i, 1952, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1954, "-btn2\')", 1954, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Reservar</a>\r\n                    <a class=\"btn btn-danger btn-sm invisible\" style=\"color:white\"");
            BeginWriteAttribute("id", " id=\"", 2059, "\"", 2071, 2);
#nullable restore
#line 55 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
WriteAttributeValue("", 2064, i, 2064, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2066, "-btn2", 2066, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2072, "\"", 2122, 7);
            WriteAttributeValue("", 2082, "cancelarReserva(this,", 2082, 21, true);
            WriteAttributeValue(" ", 2103, "\'", 2104, 2, true);
#nullable restore
#line 55 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
WriteAttributeValue("", 2105, i, 2105, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2107, "-h\',", 2107, 4, true);
            WriteAttributeValue(" ", 2111, "\'", 2112, 2, true);
#nullable restore
#line 55 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
WriteAttributeValue("", 2113, i, 2113, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2115, "-btn1\')", 2115, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Cancelar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\erick\source\repos\PistasPadel2Pruebas\PistasPadel\PistasPadel\Pages\ReservasPistasA.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>


<script>

    // Formato de la fecha actual
    function fechaActual() {
        let date = new Date();
        let year = date.getFullYear().toString();
        let day = date.getDate();
        let month = date.getMonth() + 1;
        if (month < 9) {
            if (day < 9) {
                return year.toString() + ""-0"" + month.toString() + ""-0"" + day;
            } else {
                return year.toString() + ""-0"" + month.toString() + ""-"" + day;
            } 
        } else {
            if (day < 9) {
                return year.toString() + ""-"" + month.toString() + ""-0"" + day;
            } else {
                return year.toString() + ""-"" + month.toString() + ""-"" + day;
            }
        }
    }
    document.getElementById(""fecha"").value = fechaActual();

    function fechaLimite() {
        var date = new Date();
        var day = date.getDate() + 1;
        var month = date.getMonth() + 1;
        var year = date.getFullYear().toString");
            WriteLiteral(@"();
        if (month < 9) {
            if (day < 9) {
                return year.toString() + ""-0"" + month.toString() + ""-0"" + day;
            } else {
                return year.toString() + ""-0"" + month.toString() + ""-"" + day;
            }
        } else {
            if (day < 9) {
                return year.toString() + ""-"" + month.toString() + ""-0"" + day;
            } else {
                return year.toString() + ""-"" + month.toString() + ""-"" + day;
            }
        }
    }
    document.getElementById(""fecha"").setAttribute(""max"", fechaLimite());
    document.getElementById(""fecha"").setAttribute(""min"", fechaActual());

    // Hacer visible la alerta
    function hacerVisible() {
        let element = document.getElementById(""alerta"");
        element.className = ""alert alert-info text-center visible"";

        let msg = document.getElementById(""mensaje"");
        msg.innerHTML = ""¿Quiere reservar una pista de pádel a esta hora?"";

        let btn1 = document.getElem");
            WriteLiteral(@"entById(""btnAceptar1"");
        btn1.className = ""btn btn-success"";

        let btn2 = document.getElementById(""btnCancelar1"");
        btn2.className = ""btn btn-danger"";

        let btn3 = document.getElementById(""btnAceptar2"");
        btn3.className = ""btn btn-success invisible"";

        let btn4 = document.getElementById(""btnCancelar2"");
        btn4.className = ""btn btn-danger invisible"";
    }

    // Hacer invisible la alerta
    function hacerInvisible() {
        let elmnt = document.getElementById(""alerta"");
        elmnt.className = ""alert alert-info text-center invisible"";

        let btn1 = document.getElementById(""btnAceptar2"");
        btn1.className = ""btn btn-success invisible"";

        let btn2 = document.getElementById(""btnCancelar2"");
        btn2.className = ""btn btn-danger invisible"";

        let btn3 = document.getElementById(""btnAceptar3"");
        btn3.className = ""btn btn-success invisible"";

        let btn4 = document.getElementById(""btnCancelar3"");");
            WriteLiteral(@"
        btn4.className = ""btn btn-danger invisible"";

        let btn5 = document.getElementById(""btnAceptar1"");
        btn5.className = ""btn btn-success"";

        let btn6 = document.getElementById(""btnCancelar1"");
        btn6.className = ""btn btn-danger"";
    }

    // Hacer visible la alerta de salir sin reservar
    function cambiarSalirSinReservar() {
        let msg = document.getElementById(""mensaje"");
        msg.innerHTML = ""¿Está seguro de que quiere salir sin hacer la reserva?""

        let btn1 = document.getElementById(""btnAceptar2"");
        btn1.className = ""btn btn-success"";

        let btn2 = document.getElementById(""btnCancelar2"");
        btn2.className = ""btn btn-danger"";

        let btn3 = document.getElementById(""btnAceptar1"");
        btn3.className = ""btn btn-success invisible"";

        let btn4 = document.getElementById(""btnCancelar1"");
        btn4.className = ""btn btn-danger invisible"";
    }

    // Hacer visible la alerta de cancelar reserva
   ");
            WriteLiteral(@" function visibleCancelar() {
        hacerVisible();

        let msg = document.getElementById(""mensaje"");
        msg.innerHTML = ""¿Está seguro de que quiere cancelar su reserva?""

        let btn1 = document.getElementById(""btnAceptar3"");
        btn1.className = ""btn btn-success"";

        let btn2 = document.getElementById(""btnCancelar3"");
        btn2.className = ""btn btn-danger"";

        let btn3 = document.getElementById(""btnAceptar2"");
        btn3.className = ""btn btn-success invisible"";

        let btn4 = document.getElementById(""btnCancelar2"");
        btn4.className = ""btn btn-danger invisible"";

        let btn5 = document.getElementById(""btnAceptar1"");
        btn5.className = ""btn btn-success invisible"";

        let btn6 = document.getElementById(""btnCancelar1"");
        btn6.className = ""btn btn-danger invisible"";
    }

    // Cambio de estilo de Libre a Reservado
    function reserva(elmnt, id, idbtn) {
        hacerVisible();
        let element = document.g");
            WriteLiteral(@"etElementById(id);
        element.style.background = ""purple"";
        element.style.color = ""white"";
        element.innerHTML = ""Reservado"";
        element.style.borderRadius = ""0px 50px 50px 0px"";

        element.previousElementSibling.style.background = ""purple"";
        element.previousElementSibling.style.color = ""white"";
        element.previousElementSibling.style.borderRadius = ""50px 0px 0px 50px"";

        elmnt.className = ""btn btn-success btn-sm invisible"";

        let element2 = document.getElementById(idbtn);
        element2.className = ""btn btn-danger btn-sm"";

        hacerInvisible();
    }

    // Cambio de estilo de reservado a libre
    function cancelarReserva(elmnt, id, idbtn) {
        visibleCancelar();
        let element = document.getElementById(id);
        element.style.background = ""white"";
        element.style.color = ""black"";
        element.innerHTML = ""Libre"";
        element.style.borderRadius = ""0px 0px 0px 0px"";

        element.previousEle");
            WriteLiteral(@"mentSibling.style.background = ""white"";
        element.previousElementSibling.style.color = ""black"";
        element.previousElementSibling.style.borderRadius = ""0px 0px 0px 0px"";

        elmnt.className = ""btn btn-success btn-sm invisible"";

        let element2 = document.getElementById(idbtn);
        element2.className = ""btn btn-success btn-sm visible"";

        hacerInvisible();
    }

    function buscarHoras() {
        let valor = document.getElementById(""fecha"").value;
        let msValor = Date.parse(valor);
        let fechaValor = new Date(msValor);

        let ms1 = Date.parse(fechaActual());
        let fecha1 = new Date(ms1);

        if (fechaValor.getTime() == fecha1.getTime()) {
            location.href = ""/ReservasPistasA"";
        } else {
            location.href = ""/ReservasPistasB"";
        }
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PistasPadel.Pages.ReservasPistasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PistasPadel.Pages.ReservasPistasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PistasPadel.Pages.ReservasPistasModel>)PageContext?.ViewData;
        public PistasPadel.Pages.ReservasPistasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
