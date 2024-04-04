namespace EJERCICIO_PAGINA_79
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
            this.Calcular = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Luis = new System.Windows.Forms.ComboBox();
            this.Vendedor = new System.Windows.Forms.Label();
            this.Ventas = new System.Windows.Forms.Label();
            this.Sueldos = new System.Windows.Forms.Label();
            this.Comisiones = new System.Windows.Forms.Label();
            this.ITBISES = new System.Windows.Forms.Label();
            this.Totales = new System.Windows.Forms.Label();
            this.Venta = new System.Windows.Forms.TextBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.Comision = new System.Windows.Forms.TextBox();
            this.ITBIS = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calcular.ForeColor = System.Drawing.SystemColors.Control;
            this.Calcular.Location = new System.Drawing.Point(136, 400);
            this.Calcular.Margin = new System.Windows.Forms.Padding(2);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(50, 15);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.Limpiar.Location = new System.Drawing.Point(443, 400);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(50, 15);
            this.Limpiar.TabIndex = 1;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Salir.Location = new System.Drawing.Point(705, 400);
            this.Salir.Margin = new System.Windows.Forms.Padding(2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(50, 15);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // Luis
            // 
            this.Luis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Luis.FormattingEnabled = true;
            this.Luis.Location = new System.Drawing.Point(106, 58);
            this.Luis.Margin = new System.Windows.Forms.Padding(2);
            this.Luis.Name = "Luis";
            this.Luis.Size = new System.Drawing.Size(151, 21);
            this.Luis.TabIndex = 3;
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSize = true;
            this.Vendedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Vendedor.Location = new System.Drawing.Point(51, 60);
            this.Vendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Size = new System.Drawing.Size(53, 13);
            this.Vendedor.TabIndex = 4;
            this.Vendedor.Text = "Vendedor";
            // 
            // Ventas
            // 
            this.Ventas.AutoSize = true;
            this.Ventas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ventas.Location = new System.Drawing.Point(51, 123);
            this.Ventas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(35, 13);
            this.Ventas.TabIndex = 5;
            this.Ventas.Text = "Venta";
            // 
            // Sueldos
            // 
            this.Sueldos.AutoSize = true;
            this.Sueldos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sueldos.Location = new System.Drawing.Point(51, 175);
            this.Sueldos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sueldos.Name = "Sueldos";
            this.Sueldos.Size = new System.Drawing.Size(40, 13);
            this.Sueldos.TabIndex = 6;
            this.Sueldos.Text = "Sueldo";
            // 
            // Comisiones
            // 
            this.Comisiones.AutoSize = true;
            this.Comisiones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Comisiones.Location = new System.Drawing.Point(51, 223);
            this.Comisiones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Comisiones.Name = "Comisiones";
            this.Comisiones.Size = new System.Drawing.Size(49, 13);
            this.Comisiones.TabIndex = 7;
            this.Comisiones.Text = "Comision";
            // 
            // ITBISES
            // 
            this.ITBISES.AutoSize = true;
            this.ITBISES.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ITBISES.Location = new System.Drawing.Point(51, 270);
            this.ITBISES.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ITBISES.Name = "ITBISES";
            this.ITBISES.Size = new System.Drawing.Size(34, 13);
            this.ITBISES.TabIndex = 8;
            this.ITBISES.Text = "ITBIS";
            // 
            // Totales
            // 
            this.Totales.AutoSize = true;
            this.Totales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Totales.Location = new System.Drawing.Point(51, 315);
            this.Totales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Totales.Name = "Totales";
            this.Totales.Size = new System.Drawing.Size(31, 13);
            this.Totales.TabIndex = 9;
            this.Totales.Text = "Total";
            // 
            // Venta
            // 
            this.Venta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Venta.Location = new System.Drawing.Point(106, 120);
            this.Venta.Margin = new System.Windows.Forms.Padding(2);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(68, 20);
            this.Venta.TabIndex = 10;
            // 
            // Sueldo
            // 
            this.Sueldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sueldo.Location = new System.Drawing.Point(106, 175);
            this.Sueldo.Margin = new System.Windows.Forms.Padding(2);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(68, 20);
            this.Sueldo.TabIndex = 11;
            // 
            // Comision
            // 
            this.Comision.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Comision.Location = new System.Drawing.Point(106, 223);
            this.Comision.Margin = new System.Windows.Forms.Padding(2);
            this.Comision.Name = "Comision";
            this.Comision.Size = new System.Drawing.Size(68, 20);
            this.Comision.TabIndex = 12;
            // 
            // ITBIS
            // 
            this.ITBIS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ITBIS.Location = new System.Drawing.Point(106, 270);
            this.ITBIS.Margin = new System.Windows.Forms.Padding(2);
            this.ITBIS.Name = "ITBIS";
            this.ITBIS.Size = new System.Drawing.Size(68, 20);
            this.ITBIS.TabIndex = 13;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total.Location = new System.Drawing.Point(106, 315);
            this.Total.Margin = new System.Windows.Forms.Padding(2);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(68, 20);
            this.Total.TabIndex = 14;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(703, 58);
            this.Codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(0, 13);
            this.Codigo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(453, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(507, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.ITBIS);
            this.Controls.Add(this.Comision);
            this.Controls.Add(this.Sueldo);
            this.Controls.Add(this.Venta);
            this.Controls.Add(this.Totales);
            this.Controls.Add(this.ITBISES);
            this.Controls.Add(this.Comisiones);
            this.Controls.Add(this.Sueldos);
            this.Controls.Add(this.Ventas);
            this.Controls.Add(this.Vendedor);
            this.Controls.Add(this.Luis);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Calcular);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Luis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.ComboBox Luis;
        private System.Windows.Forms.Label Vendedor;
        private System.Windows.Forms.Label Ventas;
        private System.Windows.Forms.Label Sueldos;
        private System.Windows.Forms.Label Comisiones;
        private System.Windows.Forms.Label ITBISES;
        private System.Windows.Forms.Label Totales;
        private System.Windows.Forms.TextBox Venta;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.TextBox Comision;
        private System.Windows.Forms.TextBox ITBIS;
        private System.Windows.Forms.TextBox Total;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

