using Facturacion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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

           foreach(var forg in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                forg.DeleteBehavior = DeleteBehavior.Restrict;
            }
         }


        


    }
   

}
