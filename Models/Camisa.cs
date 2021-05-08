using CotizadorExpress_Examen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen.Models
{
    class Camisa : Prenda
    {
        public bool IsMangaCorta { get; set; }
        public bool IsCuelloMao { get; set; }

        public Camisa(double precio, int cantidad, Calidad calidad, bool isMangaC, bool isCuelloMao)
            : base(precio, cantidad, calidad)
        {
            this.IsCuelloMao = isCuelloMao;
            this.IsMangaCorta = isMangaC;
        }

    }
}
