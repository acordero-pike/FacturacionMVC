#pragma checksum "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b23087ae2ccdf31a412f37845c09e13d45e7ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_Ventas_Producto), @"mvc.1.0.view", @"/Views/Reportes/Ventas_Producto.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b23087ae2ccdf31a412f37845c09e13d45e7ea", @"/Views/Reportes/Ventas_Producto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7334f350ed5be126b4d6cfcafda2fbb13563c501", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_Ventas_Producto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Facturacion.Models.ventaproducto_Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ventas_Producto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
  
    ViewBag.Title = "Reporte Ventas Producto";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b23087ae2ccdf31a412f37845c09e13d45e7ea4152", async() => {
                WriteLiteral("\r\n    <div class=\" form\">\r\n        <h2>Reporte Ventas Clientes </h2>\r\n        <span id=\"error\" class=\"alert-warning\"> ");
#nullable restore
#line 12 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
                                           Write(TempData["error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <p> <span> Fecha Inicio </span> <input id=\"in\" type=\"date\" name=\"feci\" /> </p>\r\n        <p> <span> Fecha Final </span> <input id=\"fn\" type=\"date\" name=\"fecf\" /> </p>\r\n        <span> Productos </span> ");
#nullable restore
#line 15 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
                            Write(Html.DropDownList("pr", (IEnumerable<SelectListItem>)ViewBag.Productos));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n        <p> <input id=\"btn\" type=\"submit\" class=\"btn btn-success\" value=\"Buscar\" /></p>\r\n    </div>\r\n\r\n");
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
#line 74 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
       Write(Html.DisplayNameFor(model => model.Mes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 77 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
       Write(Html.DisplayNameFor(model => model.Dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 80 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
       Write(Html.DisplayNameFor(model => model.Producto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        \r\n        <th>\r\n            ");
#nullable restore
#line 84 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
       Write(Html.DisplayNameFor(model => model.Total_Vendido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 88 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
     if (Model is null || Model.Count()==0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"5\"><span class=\"alert\"> No se encontraron Datos </span> </td>\r\n        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
    }
    else
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 101 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 107 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
               Write(Html.DisplayFor(modelItem => item.Producto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
               Write(Html.DisplayFor(modelItem => item.Total_Vendido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 115 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Reportes\Ventas_Producto.cshtml"
         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Facturacion.Models.ventaproducto_Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
