#pragma checksum "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aede673fd0468774250d0f7251d3ea838cf5299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detalle_Factura_Index), @"mvc.1.0.view", @"/Views/Detalle_Factura/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aede673fd0468774250d0f7251d3ea838cf5299", @"/Views/Detalle_Factura/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7334f350ed5be126b4d6cfcafda2fbb13563c501", @"/Views/_ViewImports.cshtml")]
    public class Views_Detalle_Factura_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Facturacion.Models.Detalle_Factura>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("producto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "prod", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Facturas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
  
    ViewData["Title"] = "Index";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Index</h1>\r\n \r\n<p>\r\n    \r\n</p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aede673fd0468774250d0f7251d3ea838cf52995649", async() => {
                WriteLiteral("\r\n        <span class=\"alert-danger\" id=\"error\"> ");
#nullable restore
#line 15 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
                                          Write(TempData["error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    <table> <thead><tr> <th>Producto</th> <th> Cantidad</th><th>Precio unitario</th> </thead> <tbody><tr><td> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aede673fd0468774250d0f7251d3ea838cf52996338", async() => {
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 16 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ID_PROUCTO;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td><td><input type=\"number\" name=\"quan\" /> </td><td id=\"prc\"> <input type=\"number\" name=\"prec\" readonly=\"readonly\" /></td>  <td><input type=\"submit\" value=\"agregar\" /></td></tr></tbody> </table> \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script>
        const producto = document.querySelector('#producto');

        document.addEventListener('DOMContentLoaded', () => {
            $.getJSON(""/Detalle_factura/GetData"", function (data) {

                for (var i = 0; i < data.length; i++) {
                    if (data[i].name == producto.value) {
                        document.querySelector('#prc').innerHTML = ` <input type=""number"" value=""${data[i].count}"" name=""prec"" readonly=""readonly"" /> `;
                    }

                }

                setTimeout(function () { document.querySelector('#error').innerHTML = ''; }, 3000);








            }
            )
        })
    producto.addEventListener('click', e => {
        
        $(document).ready(function () {
            $.getJSON(""/Detalle_factura/GetData"", function (data) {

                for (var i = 0; i < data.length; i++) {
                    if (data[i].name == e.target.value) {
                        document.querySelector('#");
            WriteLiteral(@"prc').innerHTML = ` <input type=""number"" value=""${data[i].count}"" name=""prec"" readonly=""readonly"" /> `;
}
                       
                }










            }
            )
        }
        )
    })














    </script>
<table class=""table"">
    <thead>
        <tr>
            
            <th>
                ");
#nullable restore
#line 89 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.producto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 92 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio_Unitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Subtotal</th>\r\n            <th></th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 104 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 109 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.producto.NOMBRE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 112 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                   $ ");
#nullable restore
#line 115 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.Precio_Unitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                  $ ");
#nullable restore
#line 118 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
                Write(item.Precio_Unitario*item.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 121 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Numero_Factura, id2 = item.ID_PROUCTO }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 122 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Numero_Factura, id2 = item.ID_PROUCTO }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n                    ");
#nullable restore
#line 123 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Numero_Factura, id2 = item.ID_PROUCTO }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 126 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr> <td colspan=\"3\"> </td> <td> Total : $");
#nullable restore
#line 127 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Detalle_Factura\Index.cshtml"
                                             Write(TempData["total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td></tr>\r\n    </tbody>\r\n</table>\r\n\r\n<div >\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aede673fd0468774250d0f7251d3ea838cf529915382", async() => {
                WriteLiteral("\r\n        <input type=\"button\" class=\"btn btn-warning\" value=\"Regresar\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Facturacion.Models.Detalle_Factura>> Html { get; private set; }
    }
}
#pragma warning restore 1591
