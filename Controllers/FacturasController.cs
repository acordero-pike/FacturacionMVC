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
    public class FacturasController : Controller
    {
        private readonly AplicationDbContext _context;

        public FacturasController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Facturas1
        public async Task<IActionResult> Index()
        {
            var aplicationDbContext = _context.facturas.Include(f => f.cliente);
            return View(await aplicationDbContext.ToListAsync());
        }

        // GET: Facturas1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.facturas
                .Include(f => f.cliente)
                .FirstOrDefaultAsync(m => m.Numero_Factura == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // GET: Facturas1/Create
        public IActionResult Create()
        {
            ViewData["codigo_cliente"] = new SelectList(_context.clientes,"codigo_cliente","Nombres");
            return View();
        }

        // POST: Facturas1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Numero_Factura,codigo_cliente,Fecha,Total,Anulada")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["codigo_cliente"] = new SelectList(_context.clientes, "codigo_cliente", "Nombres", factura.codigo_cliente);
            return View(factura);
        }

        // GET: Facturas1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.facturas.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            ViewData["codigo_cliente"] = new SelectList(_context.clientes, "codigo_cliente", "Nombres", factura.codigo_cliente);
            return View(factura);
        }

        // POST: Facturas1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Numero_Factura,codigo_cliente,Fecha,Total,Anulada")] Factura factura)
        {
            if (id != factura.Numero_Factura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturaExists(factura.Numero_Factura))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["codigo_cliente"] = new SelectList(_context.clientes, "codigo_cliente", "Nombres", factura.codigo_cliente);
            return View(factura);
        }

        // GET: Facturas1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.facturas
                .Include(f => f.cliente)
                .FirstOrDefaultAsync(m => m.Numero_Factura == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // POST: Facturas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var factura = await _context.facturas.FindAsync(id);
            _context.facturas.Remove(factura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacturaExists(int? id)
        {
            return _context.facturas.Any(e => e.Numero_Factura == id);
        }
    }
}
