using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen.Models
{
    class Cotizacion
    {
        public long Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoVendedor { get; set; }
        public Prenda Prenda { get; set; }
        public int Cantidad { get; set; }
        public double Resultado { get; set; }
    }
}
