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

        [Required(ErrorMessage ="Campo de Usuario Necesario")]
        [StringLength(25, ErrorMessage = "{0} Largo del Usuario entre {2} y {1} carcacteres.", MinimumLength = 5)]

        public string User { get; set; }
        [StringLength(100, ErrorMessage = "{0} Largo del Nombre entre {2} y {1} carcacteres.", MinimumLength = 5)]

        [Required(ErrorMessage = "Campo de Nombre Necesario")]

        public string Nombre { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "{0} Largo de contraseña entre {2} y {1}.", MinimumLength = 6)]
        public string password { get; set; }

    }
}
