namespace NOMINA_DE_EMPLEADOS
{
    partial class FNOMINA
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
            this.BPROCESAR = new System.Windows.Forms.Button();
            this.BNUEVO = new System.Windows.Forms.Button();
            this.BFINALIZAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBDEPARTAMENTO = new System.Windows.Forms.ComboBox();
            this.CBEMPLEADOS = new System.Windows.Forms.ComboBox();
            this.TBSUELDO = new System.Windows.Forms.TextBox();
            this.TBAFP = new System.Windows.Forms.TextBox();
            this.TBARS = new System.Windows.Forms.TextBox();
            this.TBTDESC = new System.Windows.Forms.TextBox();
            this.TBSNETO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBTOTALNETO = new System.Windows.Forms.TextBox();
            this.TBDESCUENTOS = new System.Windows.Forms.TextBox();
            this.TBTOTALARS = new System.Windows.Forms.TextBox();
            this.TBTOTALAFP = new System.Windows.Forms.TextBox();
            this.TBTOTALSUELDOS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BPROCESAR
            // 
            this.BPROCESAR.Location = new System.Drawing.Point(24, 305);
            this.BPROCESAR.Name = "BPROCESAR";
            this.BPROCESAR.Size = new System.Drawing.Size(75, 23);
            this.BPROCESAR.TabIndex = 0;
            this.BPROCESAR.Text = "PROCESAR";
            this.BPROCESAR.UseVisualStyleBackColor = true;
            this.BPROCESAR.Click += new System.EventHandler(this.BPROCESAR_Click_1);
            // 
            // BNUEVO
            // 
            this.BNUEVO.Location = new System.Drawing.Point(146, 305);
            this.BNUEVO.Name = "BNUEVO";
            this.BNUEVO.Size = new System.Drawing.Size(75, 23);
            this.BNUEVO.TabIndex = 1;
            this.BNUEVO.Text = "NUEVO";
            this.BNUEVO.UseVisualStyleBackColor = true;
            this.BNUEVO.Click += new System.EventHandler(this.BNUEVO_Click_1);
            // 
            // BFINALIZAR
            // 
            this.BFINALIZAR.Location = new System.Drawing.Point(279, 305);
            this.BFINALIZAR.Name = "BFINALIZAR";
            this.BFINALIZAR.Size = new System.Drawing.Size(75, 23);
            this.BFINALIZAR.TabIndex = 2;
            this.BFINALIZAR.Text = "FINALIZAR";
            this.BFINALIZAR.UseVisualStyleBackColor = true;
            this.BFINALIZAR.Click += new System.EventHandler(this.BFINALIZAR_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEPARTAMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SUELDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "AFP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ARS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "TOTAL DESCUENTOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "SUELDO NETO";
            // 
            // CBDEPARTAMENTO
            // 
            this.CBDEPARTAMENTO.FormattingEnabled = true;
            this.CBDEPARTAMENTO.Location = new System.Drawing.Point(169, 46);
            this.CBDEPARTAMENTO.Name = "CBDEPARTAMENTO";
            this.CBDEPARTAMENTO.Size = new System.Drawing.Size(175, 21);
            this.CBDEPARTAMENTO.TabIndex = 10;
            // 
            // CBEMPLEADOS
            // 
            this.CBEMPLEADOS.FormattingEnabled = true;
            this.CBEMPLEADOS.Location = new System.Drawing.Point(169, 79);
            this.CBEMPLEADOS.Name = "CBEMPLEADOS";
            this.CBEMPLEADOS.Size = new System.Drawing.Size(175, 21);
            this.CBEMPLEADOS.TabIndex = 11;
            // 
            // TBSUELDO
            // 
            this.TBSUELDO.Location = new System.Drawing.Point(169, 112);
            this.TBSUELDO.Name = "TBSUELDO";
            this.TBSUELDO.Size = new System.Drawing.Size(100, 20);
            this.TBSUELDO.TabIndex = 12;
            // 
            // TBAFP
            // 
            this.TBAFP.Location = new System.Drawing.Point(169, 145);
            this.TBAFP.Name = "TBAFP";
            this.TBAFP.Size = new System.Drawing.Size(100, 20);
            this.TBAFP.TabIndex = 13;
            // 
            // TBARS
            // 
            this.TBARS.Location = new System.Drawing.Point(169, 178);
            this.TBARS.Name = "TBARS";
            this.TBARS.Size = new System.Drawing.Size(100, 20);
            this.TBARS.TabIndex = 14;
            // 
            // TBTDESC
            // 
            this.TBTDESC.Location = new System.Drawing.Point(170, 211);
            this.TBTDESC.Name = "TBTDESC";
            this.TBTDESC.Size = new System.Drawing.Size(100, 20);
            this.TBTDESC.TabIndex = 15;
            // 
            // TBSNETO
            // 
            this.TBSNETO.Location = new System.Drawing.Point(169, 244);
            this.TBSNETO.Name = "TBSNETO";
            this.TBSNETO.Size = new System.Drawing.Size(100, 20);
            this.TBSNETO.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TBTOTALNETO);
            this.groupBox1.Controls.Add(this.TBDESCUENTOS);
            this.groupBox1.Controls.Add(this.TBTOTALARS);
            this.groupBox1.Controls.Add(this.TBTOTALAFP);
            this.groupBox1.Controls.Add(this.TBTOTALSUELDOS);
            this.groupBox1.Location = new System.Drawing.Point(24, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 105);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTALES NOMINA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "TOTAL NETO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "TOTAL ARS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "DESCUENTOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "TOTAL AFP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "TOTAL SUELDOS";
            // 
            // TBTOTALNETO
            // 
            this.TBTOTALNETO.Location = new System.Drawing.Point(442, 49);
            this.TBTOTALNETO.Name = "TBTOTALNETO";
            this.TBTOTALNETO.Size = new System.Drawing.Size(100, 20);
            this.TBTOTALNETO.TabIndex = 4;
            // 
            // TBDESCUENTOS
            // 
            this.TBDESCUENTOS.Location = new System.Drawing.Point(336, 49);
            this.TBDESCUENTOS.Name = "TBDESCUENTOS";
            this.TBDESCUENTOS.Size = new System.Drawing.Size(100, 20);
            this.TBDESCUENTOS.TabIndex = 3;
            // 
            // TBTOTALARS
            // 
            this.TBTOTALARS.Location = new System.Drawing.Point(230, 49);
            this.TBTOTALARS.Name = "TBTOTALARS";
            this.TBTOTALARS.Size = new System.Drawing.Size(100, 20);
            this.TBTOTALARS.TabIndex = 2;
            // 
            // TBTOTALAFP
            // 
            this.TBTOTALAFP.Location = new System.Drawing.Point(124, 49);
            this.TBTOTALAFP.Name = "TBTOTALAFP";
            this.TBTOTALAFP.Size = new System.Drawing.Size(100, 20);
            this.TBTOTALAFP.TabIndex = 1;
            // 
            // TBTOTALSUELDOS
            // 
            this.TBTOTALSUELDOS.Location = new System.Drawing.Point(18, 49);
            this.TBTOTALSUELDOS.Name = "TBTOTALSUELDOS";
            this.TBTOTALSUELDOS.Size = new System.Drawing.Size(100, 20);
            this.TBTOTALSUELDOS.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "FECHA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(419, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // FNOMINA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBSNETO);
            this.Controls.Add(this.TBTDESC);
            this.Controls.Add(this.TBARS);
            this.Controls.Add(this.TBAFP);
            this.Controls.Add(this.TBSUELDO);
            this.Controls.Add(this.CBEMPLEADOS);
            this.Controls.Add(this.CBDEPARTAMENTO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFINALIZAR);
            this.Controls.Add(this.BNUEVO);
            this.Controls.Add(this.BPROCESAR);
            this.Name = "FNOMINA";
            this.Text = "AFP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPROCESAR;
        private System.Windows.Forms.Button BNUEVO;
        private System.Windows.Forms.Button BFINALIZAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBDEPARTAMENTO;
        private System.Windows.Forms.ComboBox CBEMPLEADOS;
        private System.Windows.Forms.TextBox TBSUELDO;
        private System.Windows.Forms.TextBox TBAFP;
        private System.Windows.Forms.TextBox TBARS;
        private System.Windows.Forms.TextBox TBTDESC;
        private System.Windows.Forms.TextBox TBSNETO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBTOTALNETO;
        private System.Windows.Forms.TextBox TBDESCUENTOS;
        private System.Windows.Forms.TextBox TBTOTALARS;
        private System.Windows.Forms.TextBox TBTOTALAFP;
        private System.Windows.Forms.TextBox TBTOTALSUELDOS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

