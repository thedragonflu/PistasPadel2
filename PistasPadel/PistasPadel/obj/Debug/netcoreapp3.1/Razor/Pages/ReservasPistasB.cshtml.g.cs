#pragma checksum "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51a1d19b0cb6614120163dfa7a7c884649d9b505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PistasPadel.Pages.Pages_ReservasPistasB), @"mvc.1.0.razor-page", @"/Pages/ReservasPistasB.cshtml")]
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
#line 1 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\_ViewImports.cshtml"
using PistasPadel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a1d19b0cb6614120163dfa7a7c884649d9b505", @"/Pages/ReservasPistasB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a857f7d8d0ed1ccd039a80c6d41cfcf8e8ba67b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ReservasPistasB : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:brown"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
  
    ViewData["Title"] = "ReservasPistasB";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Reservas Pistas B</h1>

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
#line 48 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
         for (var i = 9; i <= 21; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr id=\"horasHijo\">\r\n                <td>");
#nullable restore
#line 51 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(":00</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 1790, "\"", 1799, 2);
#nullable restore
#line 52 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
WriteAttributeValue("", 1795, i, 1795, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1797, "-h", 1797, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Libre</td>\r\n                <td>\r\n                    <a class=\"btn btn-success btn-sm\" style=\"color:white\"");
            BeginWriteAttribute("id", " id=\"", 1908, "\"", 1920, 2);
#nullable restore
#line 54 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
WriteAttributeValue("", 1913, i, 1913, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1915, "-btn1", 1915, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1921, "\"", 1963, 7);
            WriteAttributeValue("", 1931, "reserva(this,", 1931, 13, true);
            WriteAttributeValue(" ", 1944, "\'", 1945, 2, true);
#nullable restore
#line 54 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
WriteAttributeValue("", 1946, i, 1946, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1948, "-h\',", 1948, 4, true);
            WriteAttributeValue(" ", 1952, "\'", 1953, 2, true);
#nullable restore
#line 54 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
WriteAttributeValue("", 1954, i, 1954, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1956, "-btn2\')", 1956, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Reservar</a>\r\n                    <a class=\"btn btn-danger btn-sm invisible\" style=\"color:white\"");
            BeginWriteAttribute("id", " id=\"", 2061, "\"", 2073, 2);
#nullable restore
#line 55 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
WriteAttributeValue("", 2066, i, 2066, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2068, "-btn2", 2068, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2074, "\"", 2124, 7);
            WriteAttributeValue("", 2084, "cancelarReserva(this,", 2084, 21, true);
            WriteAttributeValue(" ", 2105, "\'", 2106, 2, true);
#nullable restore
#line 55 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
WriteAttributeValue("", 2107, i, 2107, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2109, "-h\',", 2109, 4, true);
            WriteAttributeValue(" ", 2113, "\'", 2114, 2, true);
#nullable restore
#line 55 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
WriteAttributeValue("", 2115, i, 2115, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2117, "-btn1\')", 2117, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Cancelar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\curso18-19\Source\Repos\thedragonflu\PistasPadel2\PistasPadel\PistasPadel\Pages\ReservasPistasB.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<br />\r\n<br />\r\n<center>\r\n    <div class=\"col-sm-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51a1d19b0cb6614120163dfa7a7c884649d9b50510356", async() => {
                WriteLiteral("Cerrar sesión");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</center>

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
    document.getElementById(""fecha"").value = fechaLimite();

    function fechaLimite() {
        var date = new Date();
        var day = date.getDate() + 1;
        var month = date.getMonth() + 1;
        var year = date.getFullYear().toStri");
            WriteLiteral(@"ng();
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

        let btn1 = document.getEl");
            WriteLiteral(@"ementById(""btnAceptar1"");
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

        let btn4 = document.getElementById(""btnCancelar3""");
            WriteLiteral(@");
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
            WriteLiteral(@"   function visibleCancelar() {
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
        $(document).ready(func");
            WriteLiteral(@"tion () {
            $(""#btnAceptar1"").click(function () {
                var element = document.getElementById(id);
                element.style.background = ""purple"";
                element.style.color = ""white"";
                element.innerHTML = ""Reservado"";
                element.style.borderRadius = ""50px 50px 50px 50px"";

                elmnt.className = ""btn btn-success btn-sm invisible"";

                var element2 = document.getElementById(idbtn);
                element2.className = ""btn btn-danger btn-sm"";

                hacerInvisible();
            });
        });
    }

    // Cambio de estilo de reservado a libre
    function cancelarReserva(elmnt, id, idbtn) {
        visibleCancelar();
        $(document).ready(function () {
            $(""#btnAceptar3"").click(function () {
                var element = document.getElementById(id);
                element.style.background = ""white"";
                element.style.color = ""black"";
                element.in");
            WriteLiteral(@"nerHTML = ""Libre"";
                element.style.borderRadius = ""0px 0px 0px 0px"";

                elmnt.className = ""btn btn-danger btn-sm invisible"";

                var element2 = document.getElementById(idbtn);
                element2.className = ""btn btn-success btn-sm"";

                hacerInvisible();
            });
        });
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

    document.getElementById(""button"").addEventListener(""click"", buscarHoras);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PistasPadel.Pages.ReservasPistasBModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PistasPadel.Pages.ReservasPistasBModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PistasPadel.Pages.ReservasPistasBModel>)PageContext?.ViewData;
        public PistasPadel.Pages.ReservasPistasBModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
