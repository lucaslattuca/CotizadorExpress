using CotizadorExpress_Examen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorExpress_Examen
{
    public partial class Cotizador : Form
    {
        List<Cotizacion> cotizaciones = new List<Cotizacion>();
        public Cotizador()
        {
            InitializeComponent();
        }

        private void linkHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblListCotizaciones.Text = null;
            foreach (var c in cotizaciones)
            {
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n Nombre: {c}";
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n Apellido: {c}";
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n DNI: {c}";
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n -------------------------------------";
            }
        }
    }
}
