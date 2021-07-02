using System;

namespace Facturacion.Models
{
    public class ventacl_Result
    {
        public Nullable<int> Mes { get; set; }
        public Nullable<int> Dia { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public Nullable<double> Total_Vendido { get; set; }
    }
}