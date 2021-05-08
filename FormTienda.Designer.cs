namespace CotizadorExpress_Examen
{
    partial class FormTienda
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
            this.btnCrearTienda = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.txtTienda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearTienda
            // 
            this.btnCrearTienda.Location = new System.Drawing.Point(120, 345);
            this.btnCrearTienda.Name = "btnCrearTienda";
            this.btnCrearTienda.Size = new System.Drawing.Size(168, 43);
            this.btnCrearTienda.TabIndex = 0;
            this.btnCrearTienda.Text = "Crear Tienda";
            this.btnCrearTienda.UseVisualStyleBackColor = true;
            this.btnCrearTienda.Click += new System.EventHandler(this.btnCrearTienda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTienda);
            this.groupBox2.Controls.Add(this.txtTienda);
            this.groupBox2.Location = new System.Drawing.Point(26, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 112);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Tienda";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(182, 65);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(149, 41);
            this.txtDireccion.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dirección Tienda";
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienda.Location = new System.Drawing.Point(6, 32);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(131, 20);
            this.lblTienda.TabIndex = 9;
            this.lblTienda.Text = "Nombre tienda";
            // 
            // txtTienda
            // 
            this.txtTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienda.Location = new System.Drawing.Point(182, 32);
            this.txtTienda.Name = "txtTienda";
            this.txtTienda.Size = new System.Drawing.Size(149, 27);
            this.txtTienda.TabIndex = 13;
            this.txtTienda.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreV);
            this.groupBox1.Controls.Add(this.lblVendedor);
            this.groupBox1.Location = new System.Drawing.Point(26, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 86);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Vendedor";
            // 
            // txtCodigoV
            // 
            this.txtCodigoV.Location = new System.Drawing.Point(182, 57);
            this.txtCodigoV.Name = "txtCodigoV";
            this.txtCodigoV.Size = new System.Drawing.Size(149, 22);
            this.txtCodigoV.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código Vendedor";
            // 
            // txtNombreV
            // 
            this.txtNombreV.Location = new System.Drawing.Point(182, 32);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.Size = new System.Drawing.Size(149, 22);
            this.txtNombreV.TabIndex = 14;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(12, 32);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(124, 17);
            this.lblVendedor.TabIndex = 12;
            this.lblVendedor.Text = "Nombre Vendedor";
            // 
            // FormTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCrearTienda);
            this.Name = "FormTienda";
            this.Text = "FormTienda";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTienda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.TextBox txtTienda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreV;
        private System.Windows.Forms.Label lblVendedor;
    }
}