namespace FACTURACION_DE_MERCANCIA_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_articulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_ITBS = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_NF = new System.Windows.Forms.Label();
            this.lbl_FF = new System.Windows.Forms.Label();
            this.lbl_TG = new System.Windows.Forms.Label();
            this.lbl_TA = new System.Windows.Forms.Label();
            this.lbl_TV = new System.Windows.Forms.Label();
            this.lbl_itbis = new System.Windows.Forms.Label();
            this.lbl_TF = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtITBS = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNFactura = new System.Windows.Forms.TextBox();
            this.btn_CF = new System.Windows.Forms.Button();
            this.btn_NA = new System.Windows.Forms.Button();
            this.btn_NF = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.cbArticulo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_articulo
            // 
            this.lbl_articulo.AutoSize = true;
            this.lbl_articulo.Location = new System.Drawing.Point(70, 88);
            this.lbl_articulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_articulo.Name = "lbl_articulo";
            this.lbl_articulo.Size = new System.Drawing.Size(61, 13);
            this.lbl_articulo.TabIndex = 0;
            this.lbl_articulo.Text = "ARTICULO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(711, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(70, 134);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(62, 13);
            this.lbl_cantidad.TabIndex = 2;
            this.lbl_cantidad.Text = "CANTIDAD";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(70, 192);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(47, 13);
            this.lbl_precio.TabIndex = 3;
            this.lbl_precio.Text = "PRECIO";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(70, 253);
            this.lbl_subtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(64, 13);
            this.lbl_subtotal.TabIndex = 4;
            this.lbl_subtotal.Text = "SUBTOTAL";
            // 
            // lbl_ITBS
            // 
            this.lbl_ITBS.AutoSize = true;
            this.lbl_ITBS.Location = new System.Drawing.Point(70, 306);
            this.lbl_ITBS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ITBS.Name = "lbl_ITBS";
            this.lbl_ITBS.Size = new System.Drawing.Size(34, 13);
            this.lbl_ITBS.TabIndex = 5;
            this.lbl_ITBS.Text = "ITBIS";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(70, 366);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(42, 13);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "TOTAL";
            // 
            // lbl_NF
            // 
            this.lbl_NF.AutoSize = true;
            this.lbl_NF.Location = new System.Drawing.Point(584, 29);
            this.lbl_NF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NF.Name = "lbl_NF";
            this.lbl_NF.Size = new System.Drawing.Size(108, 13);
            this.lbl_NF.TabIndex = 7;
            this.lbl_NF.Text = "NUMERO FACTURA";
            this.lbl_NF.Click += new System.EventHandler(this.lbl_NF_Click);
            // 
            // lbl_FF
            // 
            this.lbl_FF.AutoSize = true;
            this.lbl_FF.Location = new System.Drawing.Point(595, 73);
            this.lbl_FF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FF.Name = "lbl_FF";
            this.lbl_FF.Size = new System.Drawing.Size(95, 13);
            this.lbl_FF.TabIndex = 8;
            this.lbl_FF.Text = "FECHA FACTURA";
            // 
            // lbl_TG
            // 
            this.lbl_TG.AutoSize = true;
            this.lbl_TG.Location = new System.Drawing.Point(496, 134);
            this.lbl_TG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TG.Name = "lbl_TG";
            this.lbl_TG.Size = new System.Drawing.Size(124, 13);
            this.lbl_TG.TabIndex = 9;
            this.lbl_TG.Text = "TOTALES GENERALES";
            // 
            // lbl_TA
            // 
            this.lbl_TA.AutoSize = true;
            this.lbl_TA.Location = new System.Drawing.Point(544, 208);
            this.lbl_TA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TA.Name = "lbl_TA";
            this.lbl_TA.Size = new System.Drawing.Size(106, 13);
            this.lbl_TA.TabIndex = 10;
            this.lbl_TA.Text = "TOTAL ARTICULOS";
            // 
            // lbl_TV
            // 
            this.lbl_TV.AutoSize = true;
            this.lbl_TV.Location = new System.Drawing.Point(544, 269);
            this.lbl_TV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TV.Name = "lbl_TV";
            this.lbl_TV.Size = new System.Drawing.Size(88, 13);
            this.lbl_TV.TabIndex = 11;
            this.lbl_TV.Text = "TOTAL VENTAS";
            // 
            // lbl_itbis
            // 
            this.lbl_itbis.AutoSize = true;
            this.lbl_itbis.Location = new System.Drawing.Point(544, 328);
            this.lbl_itbis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_itbis.Name = "lbl_itbis";
            this.lbl_itbis.Size = new System.Drawing.Size(72, 13);
            this.lbl_itbis.TabIndex = 12;
            this.lbl_itbis.Text = "TOTAL ITBIS";
            this.lbl_itbis.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbl_TF
            // 
            this.lbl_TF.AutoSize = true;
            this.lbl_TF.Location = new System.Drawing.Point(544, 385);
            this.lbl_TF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TF.Name = "lbl_TF";
            this.lbl_TF.Size = new System.Drawing.Size(95, 13);
            this.lbl_TF.TabIndex = 13;
            this.lbl_TF.Text = "TOTAL FACTURA";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(143, 134);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(101, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(143, 187);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(101, 20);
            this.txtPrecio.TabIndex = 16;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(143, 248);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(161, 20);
            this.txtSubtotal.TabIndex = 17;
            // 
            // txtITBS
            // 
            this.txtITBS.Location = new System.Drawing.Point(143, 314);
            this.txtITBS.Margin = new System.Windows.Forms.Padding(2);
            this.txtITBS.Name = "txtITBS";
            this.txtITBS.Size = new System.Drawing.Size(161, 20);
            this.txtITBS.TabIndex = 18;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(143, 361);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(161, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // txtNFactura
            // 
            this.txtNFactura.Location = new System.Drawing.Point(711, 27);
            this.txtNFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNFactura.Name = "txtNFactura";
            this.txtNFactura.Size = new System.Drawing.Size(156, 20);
            this.txtNFactura.TabIndex = 20;
            // 
            // btn_CF
            // 
            this.btn_CF.Location = new System.Drawing.Point(143, 437);
            this.btn_CF.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CF.Name = "btn_CF";
            this.btn_CF.Size = new System.Drawing.Size(117, 29);
            this.btn_CF.TabIndex = 15;
            this.btn_CF.Text = "CALCULAR FACTURA";
            this.btn_CF.UseVisualStyleBackColor = true;
            this.btn_CF.Click += new System.EventHandler(this.btn_CF_Click);
            // 
            // btn_NA
            // 
            this.btn_NA.Location = new System.Drawing.Point(290, 437);
            this.btn_NA.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NA.Name = "btn_NA";
            this.btn_NA.Size = new System.Drawing.Size(122, 29);
            this.btn_NA.TabIndex = 22;
            this.btn_NA.TabStop = false;
            this.btn_NA.Text = "NUEVO ARTICULO";
            this.btn_NA.UseVisualStyleBackColor = true;
            this.btn_NA.Click += new System.EventHandler(this.btn_NA_Click);
            // 
            // btn_NF
            // 
            this.btn_NF.Location = new System.Drawing.Point(452, 437);
            this.btn_NF.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NF.Name = "btn_NF";
            this.btn_NF.Size = new System.Drawing.Size(119, 29);
            this.btn_NF.TabIndex = 23;
            this.btn_NF.Text = "NUEVA FACTURA";
            this.btn_NF.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(754, 437);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(103, 29);
            this.btn_salir.TabIndex = 24;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cbArticulo
            // 
            this.cbArticulo.FormattingEnabled = true;
            this.cbArticulo.Location = new System.Drawing.Point(143, 81);
            this.cbArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.cbArticulo.Name = "cbArticulo";
            this.cbArticulo.Size = new System.Drawing.Size(296, 21);
            this.cbArticulo.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 542);
            this.Controls.Add(this.cbArticulo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_NF);
            this.Controls.Add(this.btn_NA);
            this.Controls.Add(this.btn_CF);
            this.Controls.Add(this.txtNFactura);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtITBS);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbl_TF);
            this.Controls.Add(this.lbl_itbis);
            this.Controls.Add(this.lbl_TV);
            this.Controls.Add(this.lbl_TA);
            this.Controls.Add(this.lbl_TG);
            this.Controls.Add(this.lbl_FF);
            this.Controls.Add(this.lbl_NF);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_ITBS);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_articulo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Facturacion de Mercancia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_articulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_ITBS;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_NF;
        private System.Windows.Forms.Label lbl_FF;
        private System.Windows.Forms.Label lbl_TG;
        private System.Windows.Forms.Label lbl_TA;
        private System.Windows.Forms.Label lbl_TV;
        private System.Windows.Forms.Label lbl_itbis;
        private System.Windows.Forms.Label lbl_TF;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtITBS;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNFactura;
        private System.Windows.Forms.Button btn_CF;
        private System.Windows.Forms.Button btn_NA;
        private System.Windows.Forms.Button btn_NF;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ComboBox cbArticulo;
    }
}

