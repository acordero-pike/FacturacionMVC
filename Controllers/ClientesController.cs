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

    public class ClientesController : Controller
    {
        private readonly AplicationDbContext _context;

        public ClientesController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.clientes.ToListAsync()); //retorna el listado de clientes 
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina" }); //mensaje de error llamado del controlador 

            }

            var cliente = await _context.clientes
                .FirstOrDefaultAsync(m => m.codigo_cliente == id);
            if (cliente == null)
            {
                 return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Cliente no encotrado" }); //cliente solicitado no encontrado

            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("codigo_cliente,Nombres,Apellido,Nit,Telefono,Activo")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina" }); //mensaje de error llamado del controlador 
            }

            var cliente = await _context.clientes.FindAsync(id); // busqueda del cliente 
            if (cliente == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Cliente no encontrado" }); //llamdo del error

            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("codigo_cliente,Nombres,Apellido,Nit,Telefono,Activo")] Cliente cliente)
        {
            if (id != cliente.codigo_cliente)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina falta identificador para editar" }); //mensaje de error llamado del controlador 

            }

            if (ModelState.IsValid) //validacion de modelo 
            {
                try
                {
                    _context.Update(cliente); //actualiza el modelo 
                    await _context.SaveChangesAsync(); //guarda cambios 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.codigo_cliente))
                    {
                        return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina  identificador repetido" }); //mensaje de error llamado del controlador 

                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));//retorna el index
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id) 
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina" }); //mensaje de error llamado del controlador 

            }

            var cliente = await _context.clientes // bucamos clientes y enconteramos el que se eliimina 
                .FirstOrDefaultAsync(m => m.codigo_cliente == id);
            if (cliente == null)
            {
                return RedirectToAction("Index", "Error", new { data = "Error", data2 = "Mal llamado de la pagina cliente no encontrado" }); //mensaje de error llamado del controlador 

            }

            return View(cliente);//regresa la vista del dato encontrado 
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            try
            {
                var cliente = await _context.clientes.FindAsync(id);//busca el dato 
                _context.clientes.Remove(cliente);//lo remueve 
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { data = e.Message, data2 = e.InnerException.Message.Split('.')});
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int? id)
        {
            return _context.clientes.Any(e => e.codigo_cliente == id);
        }
    }
}
