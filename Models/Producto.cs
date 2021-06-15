using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.Models
{
    public class Producto
    {
        [Key]
        public int? ID_PROUCTO {get; set;}

        public string NOMBRE {get; set;}
        public string DESCRIPCION {get; set;}
        public double PRECIO {get; set;}
        public double COSTO {get; set;}
        public int EXISTENCIA {get; set;}

        public bool ACTIVO { get; set;  }

}
}
