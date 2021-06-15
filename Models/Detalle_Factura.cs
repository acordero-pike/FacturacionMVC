using SQLite;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
 

namespace Facturacion.Models
{
    public class Detalle_Factura
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Numero_Factura")]
        public virtual Factura Factura { get; set; }
       
        [ForeignKey("ID_PROUCTO")]
        public virtual Producto producto { get; set; }



        public int cantidad { get; set;  }
        public double Precio_Unitario { get; set; }
    }
}
