﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Facturacion.DB;
using Facturacion.Models;


namespace Facturacion.Controllers
{
    public class Detalle_FacturaController : Controller
    {
        private readonly AplicationDbContext _context;

        public Detalle_FacturaController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Detalle_Factura
        public async Task<IActionResult> Index(int? id)
        {
            if(id==null)
            {
                return BadRequest();
            }
            else
            {
                TempData["Factura"] = id;
                ViewData["ID_PROUCTO"] = new SelectList(_context.Producto, "ID_PROUCTO", "NOMBRE");
                double total = 0;
                var aplicationDbContext = _context.detalle_Facturas.Include(d => d.Factura).Include(d => d.producto).Where( g => g.Numero_Factura==id);
                foreach( var it in aplicationDbContext)
                {
                    total = total+it.Precio_Unitario * it.cantidad;
                }
                TempData["total"] = total;
                return View(await aplicationDbContext.ToListAsync());
            }
           
        }

        // GET: Detalle_Factura/Details/5
        public async Task<IActionResult> Details(int? id , int? id2)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_Factura = await _context.detalle_Facturas
                .Include(d => d.Factura)
                .Include(d => d.producto)
                .FirstOrDefaultAsync(m => m.Numero_Factura == id && m.ID_PROUCTO==id2);
            if (detalle_Factura == null)
            {
                return NotFound();
            }
            TempData["FAC"] = detalle_Factura.Numero_Factura; ;
            TempData["Prod"] =detalle_Factura.ID_PROUCTO;
            return View(detalle_Factura);
        }

        // GET: Detalle_Factura/Create
         

        // POST: Detalle_Factura/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( int prod , int quan , float prec)
        {
            Detalle_Factura dt = new Detalle_Factura();
            if (ModelState.IsValid)
            {
                var  Factura = await _context.facturas.FindAsync(Convert.ToInt32(TempData["Factura"]));

                double total = 0;
                var aplicationDbContext = _context.detalle_Facturas.Include(d => d.Factura).Include(d => d.producto).Where(g => g.Numero_Factura == Convert.ToInt32(TempData["Factura"]));
                foreach (var it in aplicationDbContext)
                {
                    total = total + it.Precio_Unitario * it.cantidad;
                }

                total = total + (prec * quan);
                Factura.Total = total;
                _context.facturas.Update(Factura);
                 

                dt.ID_PROUCTO = prod;
                dt.cantidad = quan;
                dt.Precio_Unitario = prec;
                dt.Numero_Factura = Convert.ToInt32(TempData["Factura"]);
                _context.Add(dt);
                await _context.SaveChangesAsync();

                 
                return RedirectToAction("Index", "Detalle_Factura", new { id = dt.Numero_Factura });
            }
             ViewData["ID_PROUCTO"] = new SelectList(_context.Producto, "ID_PROUCTO", "NOMBRE", dt.ID_PROUCTO);
            return RedirectToAction("Index", "Detalle_Factura", new { id = dt.Numero_Factura });
        }

        // GET: Detalle_Factura/Edit/5
        public async Task<IActionResult> Edit(int? id , int? id2)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_Factura = await _context.detalle_Facturas.FindAsync(id,id2);
            if (detalle_Factura == null)
            {
                return NotFound();
            }
            ViewData["Numero_Factura"] = new SelectList(_context.facturas, "Numero_Factura", "Numero_Factura", detalle_Factura.Numero_Factura);
            ViewData["ID_PROUCTO"] = new SelectList(_context.Producto, "ID_PROUCTO", "ID_PROUCTO", detalle_Factura.ID_PROUCTO);
            TempData["Factura"] = detalle_Factura.Numero_Factura;
            return View(detalle_Factura);
        }

        // POST: Detalle_Factura/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Numero_Factura,ID_PROUCTO,cantidad,Precio_Unitario")] Detalle_Factura detalle_Factura)
        {
            if (id != detalle_Factura.Numero_Factura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalle_Factura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Detalle_FacturaExists(detalle_Factura.Numero_Factura))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Detalle_Factura", new { id =detalle_Factura.Numero_Factura });
            }
            ViewData["Numero_Factura"] = new SelectList(_context.facturas, "Numero_Factura", "Numero_Factura", detalle_Factura.Numero_Factura);
            ViewData["ID_PROUCTO"] = new SelectList(_context.Producto, "ID_PROUCTO", "ID_PROUCTO", detalle_Factura.ID_PROUCTO);
            return View(detalle_Factura);
        }

        // GET: Detalle_Factura/Delete/5
        public async Task<IActionResult> Delete(int? id , int? id2)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_Factura = await _context.detalle_Facturas
                .Include(d => d.Factura)
                .Include(d => d.producto)
                .FirstOrDefaultAsync(m => m.Numero_Factura == id && m.ID_PROUCTO==id2);
            if (detalle_Factura == null)
            {
                return NotFound();
            }
            TempData["FAC"] = detalle_Factura.Numero_Factura; 

            TempData["Prod"] = detalle_Factura.ID_PROUCTO;
            return View(detalle_Factura);
        }

        // POST: Detalle_Factura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id, int id2)
        {
            var detalle_Factura = await _context.detalle_Facturas.FindAsync(id,id2);
            _context.detalle_Facturas.Remove(detalle_Factura);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Detalle_Factura", new { id = detalle_Factura.Numero_Factura });
        }

        private bool Detalle_FacturaExists(int? id)
        {
            return _context.detalle_Facturas.Any(e => e.Numero_Factura == id);
        }

        public ActionResult GetData()
        {
            
            var query = _context.Producto.Select(g => new { name = g.ID_PROUCTO, count = g.PRECIO }).ToList();
             
            return Json(query);
        }
    }
}

