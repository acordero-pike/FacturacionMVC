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
    public class Detalle_FacturaController : Controller
    {
        private readonly AplicationDbContext _context;

        public Detalle_FacturaController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Detalle_Factura
        public async Task<IActionResult> Index(int? id, int? error)
        {
            if(id==null)
            {
                string men = "Error al Cargar ";
                string men2 = "Se cargo de Manera Errorena ya que no posee una factura. ";
                    return RedirectToAction("Index", "Error", new { data = men, data2 = men2.Split('.') });
                 
            }
            else
            {
                if(error!=null)
                { TempData["error"] = "No contamos con la cantidad para suplir ese pedido la cantidad que tenemos es de "+error; }//muestra el mensaje de error con la cantidad de producto disponible 
                TempData["Factura"] = id;//mantenemos el id de factura en todo momento para poder generar mas datos en el detalle 
                var pr = from a in _context.Producto where a.ACTIVO == true select a; // validamos que sean solo productos activos 
                ViewData["ID_PROUCTO"] = new SelectList(pr, "ID_PROUCTO", "NOMBRE");//mostramos el nombre y otorgamos el valor 
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
        public async Task<IActionResult> Details(int? id , int? id2, int error)
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
                var producto = from a in _context.Producto where a.ID_PROUCTO == prod select a.EXISTENCIA;
                var pr =  await _context.Producto.FindAsync(prod);
                double total = 0;
                var aplicationDbContext = _context.detalle_Facturas.Include(d => d.Factura).Include(d => d.producto).Where(g => g.Numero_Factura == Convert.ToInt32(TempData["Factura"]));
                foreach (var it in aplicationDbContext)
                {
                    total = total + it.Precio_Unitario * it.cantidad;
                }
                dt.Numero_Factura = Convert.ToInt32(TempData["Factura"]);
          
                int suplies = Convert.ToInt32(producto.First()) - quan; // calculamos el sobrante en productos antes de guardar 
                if (suplies>=0)
                {
                    var test = await _context.detalle_Facturas.FindAsync( dt.Numero_Factura,prod);// aca veremos si ya existe el elemento en el cuadro y en lugar de crear una mas solo sumarle 
                    if(test== null) // si es nulo quiere decir que es un nuevo elemento 
                    {
                        total = total + (prec * quan); // asi mismo el total 
                        Factura.Total = total;
                        _context.facturas.Update(Factura); // se actualiza el total en factura 
                        pr.EXISTENCIA = pr.EXISTENCIA - quan; // se resta la existencia del producto
                        _context.Producto.Update(pr); //actualizamos 
                        dt.ID_PROUCTO = prod; //otrogamos los valores al modelo 
                        dt.cantidad = quan;
                        dt.Precio_Unitario = prec;

                        _context.Add(dt); //agregamos un nuevo elemento
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        test.cantidad = test.cantidad + quan; //actualizamos la cantidad 
                        total = total + (prec * quan); // asi mismo el total 
                        Factura.Total = total; 
                        _context.facturas.Update(Factura); // se actualiza el total en factura 
                        pr.EXISTENCIA = pr.EXISTENCIA - quan; // se resta la existencia del producto
                        _context.Producto.Update(pr); //actualizamos 
                        _context.detalle_Facturas.Update(test);
                        await _context.SaveChangesAsync();

                    }
                }
                else
                {
                     
                                return RedirectToAction("Index", "Detalle_Factura", new { id = dt.Numero_Factura , error = Convert.ToInt32(producto.First()) }); //retorna la cantidad que tenemos al index para mostrar el error 

                }



                return RedirectToAction("Index", "Detalle_Factura", new { id = dt.Numero_Factura }); // si todo sale bien solo se envia la factura para que liste solo lso de la factura #
            }
             ViewData["ID_PROUCTO"] = new SelectList(_context.Producto, "ID_PROUCTO", "NOMBRE", dt.ID_PROUCTO);

            return RedirectToAction("Index", "Detalle_Factura", new { id = dt.Numero_Factura }  );
        }

        // GET: Detalle_Factura/Edit/5
        public async Task<IActionResult> Edit(int? id , int? id2)
        {
            if (id == null)//si el id viene null 
            {
                return NotFound(); // pagina de que no se encontro 
            }

            var detalle_Factura = await _context.detalle_Facturas.FindAsync(id,id2);
            if (detalle_Factura == null)// validamos que el exista en la base de datos lo que necesitamos 
            {
                return NotFound();// de no ser asi mostrara esto 
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
            if (id != detalle_Factura.Numero_Factura)// si el id no es igual al del modelo mostrara un erro 
            {
                return NotFound();
            }

            if (ModelState.IsValid)//validamos el modelo 
            {
                var Factura = await _context.facturas.FindAsync(detalle_Factura.Numero_Factura);
                var dt = await _context.detalle_Facturas.FindAsync(detalle_Factura.Numero_Factura, detalle_Factura.ID_PROUCTO);
                try
                {
                    double total = 0;
                    int devolver=0;
                    var aplicationDbContext = _context.detalle_Facturas.Include(d => d.Factura).Include(d => d.producto).Where(g => g.Numero_Factura == detalle_Factura.Numero_Factura);
                    foreach (var it in aplicationDbContext)
                    {
                        
                        if (it.ID_PROUCTO != detalle_Factura.ID_PROUCTO)
                        {
                            total = total + it.Precio_Unitario * it.cantidad;

                        }
                        else
                        {
                            devolver = it.cantidad;
                        }
                    }


                    total = total + (detalle_Factura.cantidad * detalle_Factura.Precio_Unitario);

                    var pr = await _context.Producto.FindAsync(detalle_Factura.ID_PROUCTO);
                    
                    int test = (pr.EXISTENCIA + devolver) - detalle_Factura.cantidad; // calculamos si tenemos la cantidad necesaria
                    if (test>=0)
                    {
                        dt.cantidad = detalle_Factura.cantidad;
                        pr.EXISTENCIA = test;
                        Factura.Total = total;
                        _context.detalle_Facturas.Update(dt);//actualizamos
                        _context.facturas.Update(Factura);
                        _context.Producto.Update(pr);
                        
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        TempData["error"] = "La Cantidad ingresada no es valida , podemos suplirlo con " + pr.EXISTENCIA +" mas a su pedido : Recuerda que y posees " + devolver + " unidades"; 
                        ViewData["Numero_Factura"] = new SelectList(_context.facturas, "Numero_Factura", "Numero_Factura", detalle_Factura.Numero_Factura);
                        ViewData["ID_PROUCTO"] = new SelectList(_context.Producto, "ID_PROUCTO", "ID_PROUCTO", detalle_Factura.ID_PROUCTO);
                        return View(detalle_Factura);
                    }

                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Detalle_FacturaExists(detalle_Factura.Numero_Factura))
                    {
                        return NotFound();// retorno de error 
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
            double total = 0;
            int devolver = 0;
            var aplicationDbContext = _context.detalle_Facturas.Include(d => d.Factura).Include(d => d.producto).Where(g => g.Numero_Factura == detalle_Factura.Numero_Factura);
            var Factura = await _context.facturas.FindAsync(detalle_Factura.Numero_Factura);
            var pr = await _context.Producto.FindAsync(detalle_Factura.ID_PROUCTO);


            foreach (var it in aplicationDbContext)
            {
                if (it.ID_PROUCTO != detalle_Factura.ID_PROUCTO)
                {
                    total = total + it.Precio_Unitario * it.cantidad;

                }
                else
                {
                    devolver = it.cantidad;
                }
            }
            Factura.Total = total;
            pr.EXISTENCIA = pr.EXISTENCIA + devolver;
            _context.facturas.Update(Factura);
            _context.Producto.Update(pr);
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

