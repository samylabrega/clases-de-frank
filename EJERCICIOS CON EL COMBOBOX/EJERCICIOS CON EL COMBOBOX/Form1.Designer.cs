namespace EJERCICIOS_CON_EL_COMBOBOX
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Primervalor = new System.Windows.Forms.TextBox();
            this.Segundovalor = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Finalizar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // Primervalor
            // 
            this.Primervalor.Location = new System.Drawing.Point(154, 68);
            this.Primervalor.Name = "Primervalor";
            this.Primervalor.Size = new System.Drawing.Size(100, 20);
            this.Primervalor.TabIndex = 3;
            this.Primervalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // Segundovalor
            // 
            this.Segundovalor.Location = new System.Drawing.Point(154, 117);
            this.Segundovalor.Name = "Segundovalor";
            this.Segundovalor.Size = new System.Drawing.Size(100, 20);
            this.Segundovalor.TabIndex = 4;
            this.Segundovalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(154, 167);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(100, 20);
            this.Resultado.TabIndex = 5;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(51, 233);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(97, 31);
            this.Calcular.TabIndex = 6;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(51, 270);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(97, 31);
            this.Nuevo.TabIndex = 7;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(51, 307);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(97, 31);
            this.Finalizar.TabIndex = 8;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicar",
            "Dividir",
            "Potencia"});
            this.comboBox1.Location = new System.Drawing.Point(193, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Escoja la operacion aritmetica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Segundovalor);
            this.Controls.Add(this.Primervalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EL CONTROL COMBOBOX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Primervalor;
        private System.Windows.Forms.TextBox Segundovalor;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}

