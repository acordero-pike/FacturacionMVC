using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.DB
{
    public class Rerport
    {
        public  string _con;

        public Rerport(IConfiguration c)
        {
            _con = c.GetConnectionString("Conexion");
        }
    

    }
}
