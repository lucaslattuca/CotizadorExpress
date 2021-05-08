namespace CotizadorExpress_Examen
{
    partial class Cotizador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTienda = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.linkHistorial = new System.Windows.Forms.LinkLabel();
            this.lblNombreV = new System.Windows.Forms.Label();
            this.lblCodigoV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCuello = new System.Windows.Forms.CheckBox();
            this.checkChupin = new System.Windows.Forms.CheckBox();
            this.checkMangaC = new System.Windows.Forms.CheckBox();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.radioStandar = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListCotizaciones = new System.Windows.Forms.Label();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTienda.Location = new System.Drawing.Point(493, 18);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(0, 32);
            this.lblTienda.TabIndex = 0;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDireccion.Location = new System.Drawing.Point(291, 94);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(0, 25);
            this.lblDireccion.TabIndex = 1;
            // 
            // linkHistorial
            // 
            this.linkHistorial.AutoSize = true;
            this.linkHistorial.Location = new System.Drawing.Point(732, 123);
            this.linkHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkHistorial.Name = "linkHistorial";
            this.linkHistorial.Size = new System.Drawing.Size(163, 17);
            this.linkHistorial.TabIndex = 2;
            this.linkHistorial.TabStop = true;
            this.linkHistorial.Text = "Historial de Cotizaciones";
            this.linkHistorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHistorial_LinkClicked);
            // 
            // lblNombreV
            // 
            this.lblNombreV.AutoSize = true;
            this.lblNombreV.Location = new System.Drawing.Point(221, 156);
            this.lblNombreV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreV.Name = "lblNombreV";
            this.lblNombreV.Size = new System.Drawing.Size(0, 17);
            this.lblNombreV.TabIndex = 3;
            // 
            // lblCodigoV
            // 
            this.lblCodigoV.AutoSize = true;
            this.lblCodigoV.Location = new System.Drawing.Point(221, 186);
            this.lblCodigoV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoV.Name = "lblCodigoV";
            this.lblCodigoV.Size = new System.Drawing.Size(0, 17);
            this.lblCodigoV.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCuello);
            this.groupBox1.Controls.Add(this.checkChupin);
            this.groupBox1.Controls.Add(this.checkMangaC);
            this.groupBox1.Controls.Add(this.radioPantalon);
            this.groupBox1.Controls.Add(this.radioCamisa);
            this.groupBox1.Location = new System.Drawing.Point(56, 232);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(541, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // checkCuello
            // 
            this.checkCuello.AutoSize = true;
            this.checkCuello.Location = new System.Drawing.Point(337, 23);
            this.checkCuello.Margin = new System.Windows.Forms.Padding(4);
            this.checkCuello.Name = "checkCuello";
            this.checkCuello.Size = new System.Drawing.Size(100, 21);
            this.checkCuello.TabIndex = 15;
            this.checkCuello.Text = "Cuello Mao";
            this.checkCuello.UseVisualStyleBackColor = true;
            this.checkCuello.CheckedChanged += new System.EventHandler(this.checkCuello_CheckedChanged);
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Location = new System.Drawing.Point(209, 73);
            this.checkChupin.Margin = new System.Windows.Forms.Padding(4);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(74, 21);
            this.checkChupin.TabIndex = 14;
            this.checkChupin.Text = "Chupín";
            this.checkChupin.UseVisualStyleBackColor = true;
            this.checkChupin.CheckedChanged += new System.EventHandler(this.checkChupin_CheckedChanged);
            // 
            // checkMangaC
            // 
            this.checkMangaC.AutoSize = true;
            this.checkMangaC.Location = new System.Drawing.Point(209, 25);
            this.checkMangaC.Margin = new System.Windows.Forms.Padding(4);
            this.checkMangaC.Name = "checkMangaC";
            this.checkMangaC.Size = new System.Drawing.Size(111, 21);
            this.checkMangaC.TabIndex = 13;
            this.checkMangaC.Text = "Manga Corta";
            this.checkMangaC.UseVisualStyleBackColor = true;
            this.checkMangaC.CheckedChanged += new System.EventHandler(this.checkMangaC_CheckedChanged);
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Location = new System.Drawing.Point(8, 71);
            this.radioPantalon.Margin = new System.Windows.Forms.Padding(4);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(85, 21);
            this.radioPantalon.TabIndex = 12;
            this.radioPantalon.TabStop = true;
            this.radioPantalon.Text = "Pantalón";
            this.radioPantalon.UseVisualStyleBackColor = true;
            this.radioPantalon.CheckedChanged += new System.EventHandler(this.radioPantalon_CheckedChanged);
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Location = new System.Drawing.Point(8, 23);
            this.radioCamisa.Margin = new System.Windows.Forms.Padding(4);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(75, 21);
            this.radioCamisa.TabIndex = 11;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            this.radioCamisa.CheckedChanged += new System.EventHandler(this.radioCamisa_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStock);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Location = new System.Drawing.Point(56, 379);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(541, 70);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(185, 31);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(104, 17);
            this.lblStock.TabIndex = 12;
            this.lblStock.Text = "____________";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(8, 31);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(149, 17);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Unidades Disponibles:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioPremium);
            this.groupBox3.Controls.Add(this.radioStandar);
            this.groupBox3.Location = new System.Drawing.Point(56, 466);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(221, 92);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad de la Prenda";
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(127, 38);
            this.radioPremium.Margin = new System.Windows.Forms.Padding(4);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(84, 21);
            this.radioPremium.TabIndex = 17;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            // 
            // radioStandar
            // 
            this.radioStandar.AutoSize = true;
            this.radioStandar.Location = new System.Drawing.Point(12, 38);
            this.radioStandar.Margin = new System.Windows.Forms.Padding(4);
            this.radioStandar.Name = "radioStandar";
            this.radioStandar.Size = new System.Drawing.Size(87, 21);
            this.radioStandar.TabIndex = 16;
            this.radioStandar.TabStop = true;
            this.radioStandar.Text = "Standard";
            this.radioStandar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(393, 572);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(204, 79);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(49, 38);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(127, 32);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "_______";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "$";
            // 
            // lblListCotizaciones
            // 
            this.lblListCotizaciones.AutoSize = true;
            this.lblListCotizaciones.Location = new System.Drawing.Point(684, 156);
            this.lblListCotizaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListCotizaciones.MaximumSize = new System.Drawing.Size(0, 600);
            this.lblListCotizaciones.Name = "lblListCotizaciones";
            this.lblListCotizaciones.Size = new System.Drawing.Size(0, 17);
            this.lblListCotizaciones.TabIndex = 10;
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnCotizacion.Location = new System.Drawing.Point(56, 608);
            this.btnCotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(199, 43);
            this.btnCotizacion.TabIndex = 11;
            this.btnCotizacion.Text = "Cotizar";
            this.btnCotizacion.UseVisualStyleBackColor = true;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizar);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCantidad);
            this.groupBox5.Controls.Add(this.lblCantidad);
            this.groupBox5.Controls.Add(this.txtPrecio);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(285, 466);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(312, 92);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Precio unitario y cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(205, 34);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(97, 22);
            this.txtCantidad.TabIndex = 22;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(137, 37);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(33, 33);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(72, 22);
            this.txtPrecio.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "$";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(16, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "Nueva Tienda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnTienda);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(353, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tienda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Código de Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre del Vendedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(108, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dirección:";
            // 
            // Cotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 734);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCotizacion);
            this.Controls.Add(this.lblListCotizaciones);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCodigoV);
            this.Controls.Add(this.lblNombreV);
            this.Controls.Add(this.linkHistorial);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTienda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cotizador";
            this.Text = "Cotizador Express";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.LinkLabel linkHistorial;
        private System.Windows.Forms.Label lblNombreV;
        private System.Windows.Forms.Label lblCodigoV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblListCotizaciones;
        private System.Windows.Forms.CheckBox checkCuello;
        private System.Windows.Forms.CheckBox checkChupin;
        private System.Windows.Forms.CheckBox checkMangaC;
        private System.Windows.Forms.RadioButton radioPantalon;
        private System.Windows.Forms.RadioButton radioCamisa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.RadioButton radioStandar;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

