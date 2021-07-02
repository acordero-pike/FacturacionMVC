using System;

namespace Facturacion.Models
{
    public class detalle_Result
    {
        public Nullable<int> Mes { get; set; }
        public Nullable<int> Dia { get; set; }
        public Nullable<int> Emitidas { get; set; }
        public Nullable<double> Total_Facturado { get; set; }
        public Nullable<int> Productos_Vendidos { get; set; }
    }
}