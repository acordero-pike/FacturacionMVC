#pragma checksum "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d97eb0a2f16d0d684a9042f417a0677866e1cc60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_ventas_cliente), @"mvc.1.0.view", @"/Views/Reportes/ventas_cliente.cshtml")]
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
#line 1 "C:\Users\albin\Desktop\MVC\Facturacion\Views\_ViewImports.cshtml"
using Facturacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albin\Desktop\MVC\Facturacion\Views\_ViewImports.cshtml"
using Facturacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d97eb0a2f16d0d684a9042f417a0677866e1cc60", @"/Views/Reportes/ventas_cliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7334f350ed5be126b4d6cfcafda2fbb13563c501", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_ventas_cliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Facturacion.Models.ventacl_Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ventas_cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reportes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
  
    ViewBag.Title = "Reporte Ventas Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d97eb0a2f16d0d684a9042f417a0677866e1cc604139", async() => {
                WriteLiteral("\r\n    <div class=\" form\">\r\n        <h2>Reporte Ventas Clientes</h2>\r\n        <span id=\"error\" class=\"alert-warning\"> ");
#nullable restore
#line 12 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
                                           Write(TempData["error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <p> <span> Fecha Inicio </span> <input id=\"in\" type=\"date\" name=\"feci\" /> </p>\r\n        <p> <span> Fecha Final </span> <input id=\"fn\" type=\"date\" name=\"fecf\" /> </p>\r\n        <p> <span>   Clientes </span> ");
#nullable restore
#line 15 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
                                 Write(Html.DropDownList("cl", (IEnumerable<SelectListItem>)ViewBag.Clientes));

#line default
#line hidden
#nullable disable
                WriteLiteral("  </p>\r\n\r\n        <p> <input id=\"btn\" type=\"submit\" class=\"btn btn-success\" value=\"Buscar\" /></p>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    const ins = document.querySelector('#in');
    const fn = document.querySelector('#fn');

    ins.addEventListener('change', e => {
        console.log(fn.value)

        if (fn.value == """") {

        } else {

            if (fn.value < e.target.value) {
                document.querySelector('#error').innerHTML = 'Fecha de inicio Mayor a fecha final'
                document.querySelector('#btn').disabled = true;
                setTimeout(function () { document.querySelector('#error').innerHTML = ''; }, 3000);
            }
            else {
                document.querySelector('#btn').disabled = false;
            }
        }
    })
    fn.addEventListener('change', e => {


        if (ins.value == null) {

        } else {

            if (ins.value > e.target.value) {
                document.querySelector('#error').innerHTML = 'Fecha de inicio Mayor a fecha final'
                document.querySelector('#btn').disabled = true;
                setTimeou");
            WriteLiteral(@"t(function () { document.querySelector('#error').innerHTML = ''; }, 3000);
            }
            else {
                document.querySelector('#btn').disabled = false;
            }
        }
    })

        

        document.addEventListener('DOMContentLoaded', () => {


                setTimeout(function () { document.querySelector('#error').innerHTML = ''; }, 3000);


            }
            )

</script>

<table class=""table"">
    <tr>
        <th>
            ");
#nullable restore
#line 76 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
       Write(Html.DisplayNameFor(model => model.Mes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 79 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
       Write(Html.DisplayNameFor(model => model.Dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 82 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 85 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 88 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
       Write(Html.DisplayNameFor(model => model.Total_Vendido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 92 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
     if (Model is null || Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"5\"><span class=\"alert\"> No se encontraron Datos </span> </td>\r\n        </tr>\r\n");
#nullable restore
#line 97 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
    }
    else
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 114 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 117 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
               Write(Html.DisplayFor(modelItem => item.Total_Vendido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 121 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\ventas_cliente.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Facturacion.Models.ventacl_Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
