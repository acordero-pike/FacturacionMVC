using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace Facturacion.Controllers
{
    
    public class Error : Controller
    {
        public IActionResult Index(string? data , string[]? data2)
        {
            if (data == null)
            {
                TempData["ErrorViewModel"]="Error en el llamado de la pagina";
                return View();
            }
            else
            {
                TempData["ErrorViewModel"] = data;
                TempData["Detalle"] = data2[0];
                return View();
            }
        }
    }
}
