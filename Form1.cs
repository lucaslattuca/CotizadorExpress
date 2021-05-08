using CotizadorExpress_Examen.Enums;
using CotizadorExpress_Examen.Models;
using CotizadorExpress_Examen.Services;
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
        Tienda tienda = new Tienda();
        List<Cotizacion> cotizaciones = new List<Cotizacion>();
        int nroCotizacion = 1;
        public Cotizador()
        {
            InitializeComponent();
        }

        private void btnCotizar(object sender, EventArgs e)
        {
            Calidad calidad = Calidad.STANDAR;
            Pantalon pantalon = null;
            Camisa camisa = null;
            bool ischupin = checkChupin.Checked;
            bool isMangaC = checkMangaC.Checked;
            bool iscuelloMao = checkCuello.Checked;
            //validaciones
            bool validarPrecio = Utiles.ValidarCampo(txtPrecio.Text, "double");
            bool validarCantidad = Utiles.ValidarCampo(txtCantidad.Text, "int");

            if (!validarCantidad)
                txtCantidad.BackColor = Color.Red;
            else txtCantidad.BackColor = Color.White;

            if (!validarPrecio)
                txtPrecio.BackColor = Color.Red;
            else txtPrecio.BackColor = Color.White;

            if (!validarPrecio || !validarCantidad)
            {
                MessageBox.Show("Los datos ingresados no son válidos");
            }
            else if (!radioCamisa.Checked && !radioPantalon.Checked)
            {
                MessageBox.Show("Seleccione algun tipo de prenda");
            }
            else
            {
                //obtener precio
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                double total = precio * cantidad;

                //verificaciones
                if (radioCamisa.Checked)
                {
                    if (checkMangaC.Checked)
                    {
                        precio -= precio * 0.1;
                        total -= total * 0.1;
                    }
                    if (checkCuello.Checked)
                    {
                        precio += precio * 0.03;
                        total += total * 0.03;
                    }
                }
                else if (checkChupin.Checked)
                {
                    precio -= precio * 0.12;
                    total -= total * 0.12;
                }

                if (radioPremium.Checked)
                {
                    precio += precio * 0.3;
                    total += total * 0.3;
                    calidad = Calidad.PREMIUM;
                }
                if (cantidad > Convert.ToInt32(txtCantidad.Text))
                    MessageBox.Show("La cantidad no puede superar el stock");
                else
                    lblTotal.Text = total.ToString();

                Cotizacion cotizacion = new Cotizacion();
                cotizacion.Fecha = DateTime.Now;
                cotizacion.Numero = nroCotizacion++;
                cotizacion.Resultado = total;
                cotizacion.CodigoVendedor = tienda.Vendedor != null ? tienda.Vendedor.Codigo : "";

                if (radioCamisa.Checked)
                {
                    camisa = new Camisa(precio, cantidad, calidad, isMangaC, iscuelloMao);
                    cotizacion.Prenda = camisa;
                }
                else if (radioPantalon.Checked)
                {
                    pantalon = new Pantalon(precio, cantidad, calidad, ischupin);
                    cotizacion.Prenda = pantalon;
                }

                cotizaciones.Add(cotizacion);
            }
        }

        private void linkHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblListCotizaciones.Text = null;
            foreach (var c in cotizaciones)
            {
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n Fecha: {c.Fecha}";
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n Nro de Cotizacion: {c.Numero}";
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n Monto: ${c.Resultado}";
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n Código Vendedor: {c.CodigoVendedor}";
                lblListCotizaciones.Text = $"{lblListCotizaciones.Text} \n -------------------------------------";
            }
        }

        private void checkMangaC_CheckedChanged(object sender, EventArgs e)
        {
            stockTotal();
        }

        private void checkCuello_CheckedChanged(object sender, EventArgs e)
        {
            stockTotal();
        }

        private void checkChupin_CheckedChanged(object sender, EventArgs e)
        {
            stockTotal();
        }
        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            stockTotal();
        }

        private void radioPantalon_CheckedChanged(object sender, EventArgs e)
        {
            stockTotal();
        }

        private void btnTienda(object sender, EventArgs e)
        {

            FormTienda form = new FormTienda();
            Vendedor vendedor = new Vendedor();
            form.ShowDialog();

            tienda.Nombre = lblTienda.Text = form.nombreTienda;
            tienda.Direccion = lblDireccion.Text = form.direccion;
            vendedor.Nombre = lblNombreV.Text = form.nombreVendedor;
            vendedor.Codigo = lblCodigoV.Text = form.codigoVendedor;
            tienda.Vendedor = vendedor;
            lblListCotizaciones.Text = "";
            nroCotizacion = 0;
            cotizaciones = new List<Cotizacion>();
        }

        public void stockTotal()
        {
            if (radioPantalon.Checked)
            {
                checkCuello.Checked = false;
                checkMangaC.Checked = false;
                if (checkChupin.Checked)
                    lblStock.Text = Utiles.ValidarStock("Pantalon", true).ToString();
                else
                    lblStock.Text = Utiles.ValidarStock("Pantalon", false).ToString();
            }
            else if (radioCamisa.Checked)
            {
                checkChupin.Checked = false;
                if (checkCuello.Checked && checkMangaC.Checked)
                {
                    lblStock.Text = Utiles.ValidarStock("Manga Corta", true).ToString();
                }
                else if (!checkCuello.Checked && checkMangaC.Checked)
                {
                    lblStock.Text = Utiles.ValidarStock("Manga Corta", false).ToString();
                }
                else if (checkCuello.Checked && !checkMangaC.Checked)
                {
                    lblStock.Text = Utiles.ValidarStock("Manga Larga", true).ToString();
                }
                else if (!checkCuello.Checked && !checkMangaC.Checked)
                {
                    lblStock.Text = Utiles.ValidarStock("Manga Larga", false).ToString();
                }
            }
            else
                lblStock.Text = "______";

        }
    }
}
