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
        [Required (ErrorMessage ="Ingrese el Nombre ya que es necesario")]
        public string NOMBRE {get; set;}
        public string DESCRIPCION {get; set;}
        [Range(1, 9999999, ErrorMessage = "Ingrese valores mayores a cero")]
        public double PRECIO {get; set;}
        [Range(1, 9999999, ErrorMessage = "Ingrese valores mayores a cero")]
        public double COSTO {get; set;}
        [Range(1, 9999999, ErrorMessage = "Ingrese valores mayores a cero")]
        public int EXISTENCIA {get; set;}

        public bool ACTIVO { get; set;  }

}
}
