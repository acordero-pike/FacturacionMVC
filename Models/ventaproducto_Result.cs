using System;

namespace Facturacion.Models
{
    public class ventaproducto_Result
    {
        public Nullable<int> Mes { get; set; }
        public Nullable<int> Dia { get; set; }
        public string Producto { get; set; }
        public Nullable<double> Total_Vendido { get; set; }
    }
}