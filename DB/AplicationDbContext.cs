using Facturacion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public DbSet<Detalle_Factura>  detalle { get; set; }
        public DbSet<Facturacion.Models.Producto> Producto { get; set; }

    }
    
}
