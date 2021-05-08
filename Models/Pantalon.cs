using CotizadorExpress_Examen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen.Models
{
    class Pantalon : Prenda
    {
        public bool IsChupin { get; set; }
        public Pantalon(double precio, int cantidad, Calidad calidad, bool isChupin)
            : base(precio, cantidad, calidad)
        {
            this.IsChupin = isChupin;
        }

    }
}
