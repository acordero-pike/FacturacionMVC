using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.Models
{
    public class Factura
    {
        [Key]
        public int? Numero_Factura {get; set;}

        [ForeignKey("codigo_cliente")]
        public virtual Cliente cliente { get; set; }

        public DateTime Fecha { get; set; }

        public double Total { get; set; }

        public bool Anulada { get; set; }
    }
}
