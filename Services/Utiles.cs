using CotizadorExpress_Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen.Services
{
    static class Utiles
    {
        public static Boolean ValidarCampo(string dato, string tipo)
        {
            switch (tipo)
            {
                case "int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch (Exception) { return false; }
                case "double":
                    try
                    {
                        Convert.ToDouble(dato);
                        return true;
                    }
                    catch (Exception) { return false; }
                case "string":
                    if (!string.IsNullOrWhiteSpace(dato))
                    {
                        try
                        {
                            Convert.ToString(dato.Trim());
                            return true;
                        }
                        catch (Exception) { return false; }
                    }
                    else return false;
                default:
                    return false;
            }
        }

        public static int ValidarStock(string tipo, bool especial)
        {
            switch (tipo)
            {
                case "Manga Larga":
                    if (especial)
                        return 150;
                    else
                        return 350;
                case "Manga Corta":
                    if (especial)
                        return 200;
                    else
                        return 300;
                case "Pantalon":
                    if (especial)
                        return 1500;
                    else
                        return 500;
                default:
                    return 0;
            }
        }

    }
}
