using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen.Models
{
    class Tienda
    {
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public List<Prenda> Prendas { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
