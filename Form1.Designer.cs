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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblListCotizaciones = new System.Windows.Forms.Label();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.checkMangaC = new System.Windows.Forms.CheckBox();
            this.checkChupin = new System.Windows.Forms.CheckBox();
            this.checkCuello = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioStandar = new System.Windows.Forms.RadioButton();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.lblTienda.Location = new System.Drawing.Point(34, 76);
            this.lblTienda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(174, 26);
            this.lblTienda.TabIndex = 0;
            this.lblTienda.Text = "Nombre Tienda";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDireccion.Location = new System.Drawing.Point(321, 82);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(127, 20);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección Tienda";
            // 
            // linkHistorial
            // 
            this.linkHistorial.AutoSize = true;
            this.linkHistorial.Location = new System.Drawing.Point(549, 100);
            this.linkHistorial.Name = "linkHistorial";
            this.linkHistorial.Size = new System.Drawing.Size(122, 13);
            this.linkHistorial.TabIndex = 2;
            this.linkHistorial.TabStop = true;
            this.linkHistorial.Text = "Historial de Cotizaciones";
            this.linkHistorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHistorial_LinkClicked);
            // 
            // lblNombreV
            // 
            this.lblNombreV.AutoSize = true;
            this.lblNombreV.Location = new System.Drawing.Point(38, 131);
            this.lblNombreV.Name = "lblNombreV";
            this.lblNombreV.Size = new System.Drawing.Size(93, 13);
            this.lblNombreV.TabIndex = 3;
            this.lblNombreV.Text = "Nombre Vendedor";
            // 
            // lblCodigoV
            // 
            this.lblCodigoV.AutoSize = true;
            this.lblCodigoV.Location = new System.Drawing.Point(196, 131);
            this.lblCodigoV.Name = "lblCodigoV";
            this.lblCodigoV.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoV.TabIndex = 4;
            this.lblCodigoV.Text = "Código Vendedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCuello);
            this.groupBox1.Controls.Add(this.checkChupin);
            this.groupBox1.Controls.Add(this.checkMangaC);
            this.groupBox1.Controls.Add(this.radioPantalon);
            this.groupBox1.Controls.Add(this.radioCamisa);
            this.groupBox1.Location = new System.Drawing.Point(42, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblStock);
            this.groupBox2.Location = new System.Drawing.Point(42, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioPremium);
            this.groupBox3.Controls.Add(this.radioStandar);
            this.groupBox3.Location = new System.Drawing.Point(42, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 75);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad de la Prenda";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(295, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 64);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // lblListCotizaciones
            // 
            this.lblListCotizaciones.AutoSize = true;
            this.lblListCotizaciones.Location = new System.Drawing.Point(513, 168);
            this.lblListCotizaciones.Name = "lblListCotizaciones";
            this.lblListCotizaciones.Size = new System.Drawing.Size(0, 13);
            this.lblListCotizaciones.TabIndex = 10;
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Location = new System.Drawing.Point(6, 19);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioCamisa.TabIndex = 11;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Location = new System.Drawing.Point(6, 58);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioPantalon.TabIndex = 12;
            this.radioPantalon.TabStop = true;
            this.radioPantalon.Text = "Pantalón";
            this.radioPantalon.UseVisualStyleBackColor = true;
            // 
            // checkMangaC
            // 
            this.checkMangaC.AutoSize = true;
            this.checkMangaC.Location = new System.Drawing.Point(157, 20);
            this.checkMangaC.Name = "checkMangaC";
            this.checkMangaC.Size = new System.Drawing.Size(87, 17);
            this.checkMangaC.TabIndex = 13;
            this.checkMangaC.Text = "Manga Corta";
            this.checkMangaC.UseVisualStyleBackColor = true;
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Location = new System.Drawing.Point(157, 59);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(61, 17);
            this.checkChupin.TabIndex = 14;
            this.checkChupin.Text = "Chupín";
            this.checkChupin.UseVisualStyleBackColor = true;
            // 
            // checkCuello
            // 
            this.checkCuello.AutoSize = true;
            this.checkCuello.Location = new System.Drawing.Point(253, 19);
            this.checkCuello.Name = "checkCuello";
            this.checkCuello.Size = new System.Drawing.Size(79, 17);
            this.checkCuello.TabIndex = 15;
            this.checkCuello.Text = "Cuello Mao";
            this.checkCuello.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(37, 31);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 26);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "_______";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(6, 25);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(112, 13);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Unidades Disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "____________";
            // 
            // radioStandar
            // 
            this.radioStandar.AutoSize = true;
            this.radioStandar.Location = new System.Drawing.Point(9, 31);
            this.radioStandar.Name = "radioStandar";
            this.radioStandar.Size = new System.Drawing.Size(68, 17);
            this.radioStandar.TabIndex = 16;
            this.radioStandar.TabStop = true;
            this.radioStandar.Text = "Standard";
            this.radioStandar.UseVisualStyleBackColor = true;
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(95, 31);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(65, 17);
            this.radioPremium.TabIndex = 17;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(42, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cotizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCantidad);
            this.groupBox5.Controls.Add(this.lblCantidad);
            this.groupBox5.Controls.Add(this.txtPrecio);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(214, 379);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 75);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calidad de la Prenda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "$";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(25, 27);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(55, 20);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(154, 28);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(74, 20);
            this.txtCantidad.TabIndex = 22;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(103, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Nueva Tienda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Cotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 596);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.RadioButton radioStandar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

