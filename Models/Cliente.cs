using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.Models
{
    public class Cliente
    {
        [Key]
        public int? codigo_cliente {get; set;}

        public string Nombres {get; set;}
        public string Apellido {get; set;}

        public string  Nit {get; set;}
        public int Telefono {get; set;}
        public bool Activo { get; set; }
}
}
