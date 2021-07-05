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
        [Required(ErrorMessage ="Es necesario al menos un nombre para guardar cliente")]
        public string Nombres {get; set;}
        [Required(ErrorMessage = "Es necesario al menos un Apellido para guardar cliente")]
        public string Apellido {get; set;}

        public string  Nit {get; set;}
        [Required(ErrorMessage ="El telefono es necesario para continuar")]
        public int Telefono {get; set;}
        public bool Activo { get; set; }
}
}
