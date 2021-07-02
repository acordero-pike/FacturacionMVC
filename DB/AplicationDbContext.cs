using Facturacion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Facturacion.DB
{
    
        public class AplicationDbContext : DbContext
        {
       
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
            {

            }

            public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente>  clientes { get; set; }
        public DbSet<Factura>  facturas { get; set; }
        public DbSet<Detalle_Factura>  detalle_Facturas { get; set; }
        public DbSet<Producto> Producto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detalle_Factura>().HasKey(p => new { p.Numero_Factura , p.ID_PROUCTO});
        }


        


        public virtual ObjectResult<ventacl_Result> ventacl(Nullable<System.DateTime> feci, Nullable<System.DateTime> fecf)
        {
            var feciParameter = feci.HasValue ?
                new ObjectParameter("feci", feci) :
                new ObjectParameter("feci", typeof(System.DateTime));

            var fecfParameter = fecf.HasValue ?
                new ObjectParameter("fecf", fecf) :
                new ObjectParameter("fecf", typeof(System.DateTime));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ventacl_Result>("ventacl", feciParameter, fecfParameter);
        }

        public virtual ObjectResult<ventacl_Result> ventacl2(Nullable<System.DateTime> feci, Nullable<System.DateTime> fecf, Nullable<int> cl)
        {
            var feciParameter = feci.HasValue ?
                new ObjectParameter("feci", feci) :
                new ObjectParameter("feci", typeof(System.DateTime));

            var fecfParameter = fecf.HasValue ?
                new ObjectParameter("fecf", fecf) :
                new ObjectParameter("fecf", typeof(System.DateTime));

            var clParameter = cl.HasValue ?
                new ObjectParameter("cl", cl) :
                new ObjectParameter("cl", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ventacl_Result>("ventacl2", feciParameter, fecfParameter, clParameter);
        }

        public virtual ObjectResult<ventaproducto_Result> ventaproducto(Nullable<System.DateTime> feci, Nullable<System.DateTime> fecf, string pr)
        {
            var feciParameter = feci.HasValue ?
                new ObjectParameter("feci", feci) :
                new ObjectParameter("feci", typeof(System.DateTime));

            var fecfParameter = fecf.HasValue ?
                new ObjectParameter("fecf", fecf) :
                new ObjectParameter("fecf", typeof(System.DateTime));

            var prParameter = pr != null ?
                new ObjectParameter("pr", pr) :
                new ObjectParameter("pr", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ventaproducto_Result>("ventaproducto", feciParameter, fecfParameter, prParameter);
        }

        public virtual ObjectResult<ventaproducto_Result> ventaproducto2(Nullable<System.DateTime> feci, Nullable<System.DateTime> fecf)
        {
            var feciParameter = feci.HasValue ?
                new ObjectParameter("feci", feci) :
                new ObjectParameter("feci", typeof(System.DateTime));

            var fecfParameter = fecf.HasValue ?
                new ObjectParameter("fecf", fecf) :
                new ObjectParameter("fecf", typeof(System.DateTime));

      
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ventaproducto_Result>("ventaproducto2", feciParameter, fecfParameter);
        }

    }
   

}
