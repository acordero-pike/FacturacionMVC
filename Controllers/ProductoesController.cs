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

namespace Facturacion.Controllers
{
    [Authorize]

    public class ProductoesController : Controller
    {
        private readonly AplicationDbContext _context;

        public ProductoesController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Productoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Producto.ToListAsync());//lista de productos
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina" }); //mensaje de error llamado del controlador 

            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.ID_PROUCTO == id);//busqueda por id 
            if (producto == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina No se encontro el producto " }); //mensaje de error llamado del controlador 

            }

            return View(producto);
        }

        // GET: Productoes/Create
        public IActionResult Create()
        {
            return View();//vista de crear
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_PROUCTO,NOMBRE,DESCRIPCION,PRECIO,COSTO,EXISTENCIA,ACTIVO")] Producto producto)
        {
            if (ModelState.IsValid)//validacion de modelo
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();// guardar cambios 
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina" }); //mensaje de error llamado del controlador 

            }

            var producto = await _context.Producto.FindAsync(id); //busqueda del producto por id 
            if (producto == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina No se encontro el producto " }); //mensaje de error llamado del controlador 

            }
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("ID_PROUCTO,NOMBRE,DESCRIPCION,PRECIO,COSTO,EXISTENCIA,ACTIVO")] Producto producto)
        {
            if (id != producto.ID_PROUCTO)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina" }); //mensaje de error llamado del controlador 

            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto); //actualizar el producto
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.ID_PROUCTO)) // revision de existencia del id 
                    {
                                   return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina el codigo produto ya existe " }); //mensaje de error llamado del controlador 

                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina" }); //mensaje de error llamado del controlador 

            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.ID_PROUCTO == id);//busqueda del producto 
            if (producto == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina Producto no encontrado" }); //mensaje de error llamado del controlador 

            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            try
            {
                var producto = await _context.Producto.FindAsync(id);
                _context.Producto.Remove(producto);//elimincacion 
                await _context.SaveChangesAsync();//guardado
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { data = e.Message, data2 = e.InnerException.Message.Split('.') });
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int? id)
        {
            return _context.Producto.Any(e => e.ID_PROUCTO == id);
        }
    }
}
