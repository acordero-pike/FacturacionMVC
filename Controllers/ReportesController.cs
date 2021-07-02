using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Facturacion.DB;
using Facturacion.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
namespace Facturacion.Controllers
{
    [Authorize]
    public class ReportesController : Controller
    {
        private readonly AplicationDbContext _context;

        public ReportesController(AplicationDbContext context)
        {
            _context = context;
        }

         private string DB = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS;Database=MVC;user=sa;password=albin123;Trusted_Connection=false;MultipleActiveResultSets=true";







        public async Task<IActionResult> DetalleAsync(DateTime? feci, DateTime? fecf)
        {


            if (feci is null || fecf is null)
            {
                TempData["error"] = "Ingrese los campos de fechas, ambos son necesrios ";
                return View();
            }
            else
            {
                var dt = new List<detalle_Result>();

                
                using (SqlConnection sql = new SqlConnection(DB))
                {
                    using (SqlCommand cmd = new SqlCommand("detalle", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@feci", feci.Value));
                        cmd.Parameters.Add(new SqlParameter("@fecf", fecf.Value));

                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                dt.Add(mapeardt(reader));
                            }
                        }
                    }
                }
                return View(dt);
            }
        }

        private detalle_Result mapeardt(SqlDataReader read)
        {
            return new detalle_Result()
            {
                Dia = (int)read["Dia"],
                Mes = (int)read["Mes"],
                Emitidas = (int)read["Emitidas"],
                Total_Facturado = (double)read["Total_Facturado"],
                Productos_Vendidos = (int)read["Productos_Vendidos"]

            };
        }

        public async Task<IActionResult> ventas_clienteAsync(DateTime? feci, DateTime? fecf, int? cl)
        {
            var x = from a in _context.clientes select a;
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem { Text = "Seleccione Una Opcion", Value = "0" });

            foreach (var i in x)

            {
                lst.Add(new SelectListItem { Text = i.Nombres + ' ' + i.Apellido, Value = i.codigo_cliente.ToString() });
            }
            if (feci is null && fecf is null && cl == null)
            {
                
 
                ViewData["Clientes"] = new SelectList(lst, "Value", "Text");
                return View();
            }


            if (cl == null || cl==0)
            {
                if (feci is null || fecf is null)
                {
                    TempData["error"] = "Ingrese los campos de fechas, ambos son necesarios Cliente ";

                    ViewData["Clientes"] = new SelectList(lst, "Value", "Text");
                    return View();
                }
                var vlc = new List<ventacl_Result>();

                using (SqlConnection sql = new SqlConnection(DB))
                {
                    using (SqlCommand cmd = new SqlCommand("ventacl", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@feci", feci.Value));
                        cmd.Parameters.Add(new SqlParameter("@fecf", fecf.Value));

                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                vlc.Add(mapearvc(reader));
                            }
                        }
                    }
                }
                ViewData["Clientes"] = new SelectList(lst, "Value", "Text");
                return View(vlc);
            }
            else if (feci is null || fecf is null && cl!=null)
            {
                 

                var vlc = new List<ventacl_Result>();

                using (SqlConnection sql = new SqlConnection(DB))
                {
                    using (SqlCommand cmd = new SqlCommand("ventacl3", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                          cmd.Parameters.Add(new SqlParameter("@cl", cl));

                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                vlc.Add(mapearvc(reader));
                            }
                        }
                    }
                }
                ViewData["Clientes"] = new SelectList(lst, "Value", "Text");
                return View(vlc);
            }
            else
            {
                if (feci is null || fecf is null)
                {
                    TempData["error"] = "Ingrese los campos de fechas, ambos son necesarios Seleccione un Cliente";

                    ViewData["Clientes"] = new SelectList(lst, "Value", "Text");
                    return View();
                }
                var vlc = new List<ventacl_Result>();

                using (SqlConnection sql = new SqlConnection(DB))
                {
                    using (SqlCommand cmd = new SqlCommand("ventacl2", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@feci", feci.Value));
                        cmd.Parameters.Add(new SqlParameter("@fecf", fecf.Value));
                        cmd.Parameters.Add(new SqlParameter("@cl", cl));

                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                vlc.Add(mapearvc(reader));
                            }
                        }
                    }
                }
                ViewData["Clientes"] = new SelectList(lst, "Value", "Text");
                return View(vlc);
            }
        }
            

        

        



        private ventacl_Result mapearvc(SqlDataReader read)
        {



            return new ventacl_Result()
            {
                Dia = (int)read["Dia"],
                Mes = (int)read["Mes"],
                Nombres = read["Nombres"].ToString(),
                Apellido = read["Apellido"].ToString(),
                Total_Vendido = (double)read["Total_Vendido"]

            };
        }

        public async Task<IActionResult> ventas_ProductoAsync(DateTime? feci, DateTime? fecf, int? pr)
        {
            var x = from a in _context.Producto select a;
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem { Text = "Seleccione Una Opcion", Value = "0" });

            foreach (var i in x)

            {
                lst.Add(new SelectListItem { Text = i.NOMBRE, Value = i.ID_PROUCTO.ToString() });
            }

            if (feci is null && fecf is null && pr == null)
            {

                ViewData["Productos"] = new SelectList(lst, "Value", "Text");
                return View();
            }
            if (pr == null || pr==0 )
            {

                if (feci is null || fecf is null)
                {
                    TempData["error"] = "Ingrese los campos de fechas, ambos son necesrios o  Seleccione un Producto";
                    ViewData["Productos"] = new SelectList(lst, "Value", "Text");
                    return View();
                }
                var vlc = new List<ventaproducto_Result>();

                using (SqlConnection sql = new SqlConnection(DB))
                {
                    using (SqlCommand cmd = new SqlCommand("ventaproducto2", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@feci", feci.Value));
                        cmd.Parameters.Add(new SqlParameter("@fecf", fecf.Value));

                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                vlc.Add(mapearvp(reader));
                            }
                        }
                    }
                }
                ViewData["Productos"] = new SelectList(lst, "Value", "Text");

                return View(vlc);
            }
            else if(feci is null || fecf is null && pr != null)
            {

                
                var vlc = new List<ventaproducto_Result>();

                using (SqlConnection sql = new SqlConnection(DB))
                {
                    using (SqlCommand cmd = new SqlCommand("ventaproducto3", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                       
                        cmd.Parameters.Add(new SqlParameter("@pr", pr));

                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                vlc.Add(mapearvp(reader));
                            }
                        }
                    }
                }
                ViewData["Productos"] = new SelectList(lst, "Value", "Text");

                return View(vlc);
            }
            else
            {
                if (feci is null || fecf is null)
                {
                    TempData["error"] = "Ingrese los campos de fechas, ambos son necesrios Seleccione un Producto";
                    ViewData["Productos"] = new SelectList(lst, "Value", "Text");
                    return View();
                }



                var vlc = new List<ventaproducto_Result>();

                using (SqlConnection sql = new SqlConnection(DB))
                {
                    using (SqlCommand cmd = new SqlCommand("ventaproducto", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@feci", feci.Value));
                        cmd.Parameters.Add(new SqlParameter("@fecf", fecf.Value));
                        cmd.Parameters.Add(new SqlParameter("@pr", pr));

                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                vlc.Add(mapearvp(reader));
                            }
                        }
                    }
                }
                ViewData["Productos"] = new SelectList(lst, "Value", "Text");

                return View(vlc);
            }
        }

        private ventaproducto_Result mapearvp(SqlDataReader read)
        {
            return new ventaproducto_Result()
            {
                Dia = (int)read["Dia"],
                Mes = (int)read["Mes"],
                Producto = read["Producto"].ToString(),
                Total_Vendido = (double)read["Total_Vendido"]


            };
        }
    }
         
}
