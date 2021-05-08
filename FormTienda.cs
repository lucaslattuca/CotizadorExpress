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
    public partial class FormTienda : Form
    {
        public string nombreTienda { get; set; }
        public string direccion { get; set; }
        public string nombreVendedor { get; set; }
        public string codigoVendedor { get; set; }

        public FormTienda()
        {
            InitializeComponent();
        }

        private void btnCrearTienda_Click(object sender, EventArgs e)
        {
            nombreTienda = txtTienda.Text;
            direccion = txtDireccion.Text;
            nombreVendedor = txtNombreV.Text;
            codigoVendedor = txtCodigoV.Text;

            this.Close();
        }

    }
}
