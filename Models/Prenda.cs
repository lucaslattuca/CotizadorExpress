using CotizadorExpress_Examen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen.Models
{
    abstract class Prenda
    {
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public Calidad Calidad { get; set; }

        protected Prenda(double precio, int cantidad, Calidad calidad)
        {
            Precio = precio;
            Cantidad = cantidad;
            Calidad = calidad;
        }
    }
}
