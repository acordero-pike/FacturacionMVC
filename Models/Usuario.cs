using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.Models
{
    public class Usuario
    {

        [Key]
        public int id_usu { get; set; }

        [Required]
        public string User { get; set; }

        [Required]

        public string Nombre { get; set; }

        [Required]
        public string password { get; set; }

    }
}
