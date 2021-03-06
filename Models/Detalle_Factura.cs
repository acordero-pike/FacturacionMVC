
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

        [Key, Column(Order = 1)]
        [Display(Name ="Factura")]
        public int? Numero_Factura { get; set; }

        [ForeignKey("Numero_Factura")]
        public virtual Factura Factura { get; set; }
        [Key, Column(Order = 2)]
        [Display(Name = "Producto")]
        public int? ID_PROUCTO { get; set; } 
        [ForeignKey("ID_PROUCTO")]
        public virtual Producto producto { get; set; }


        [Range(1, 9999999,ErrorMessage ="Ingrese valores mayores a cero")]
        public int cantidad { get; set;  }
        public double Precio_Unitario { get; set; }
    }
}
