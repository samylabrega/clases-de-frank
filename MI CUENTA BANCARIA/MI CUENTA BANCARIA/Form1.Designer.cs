namespace MI_CUENTA_BANCARIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            Transaccion = new ComboBox();
            Depositos = new TextBox();
            Retiros = new TextBox();
            Balance = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Procesar = new Button();
            Nuevo = new Button();
            Finalizar = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(42, 63);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "CUENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 128, 255);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(42, 106);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "DEPOSITO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 128, 255);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(42, 151);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "RETIROS ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(128, 128, 255);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(42, 200);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 3;
            label4.Text = "BALANCE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(128, 128, 255);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(311, 60);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 7;
            label5.Text = "NO.TRANSACCION";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "SAMY", "PARKER", "MAICOL", "CARLOS" });
            comboBox1.BackColor = SystemColors.ControlLightLight;
            comboBox1.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            comboBox1.ForeColor = SystemColors.ActiveCaptionText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 31);
            comboBox1.TabIndex = 9;
            // 
            // Transaccion
            // 
            Transaccion.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4" });
            Transaccion.FormattingEnabled = true;
            Transaccion.Location = new Point(469, 63);
            Transaccion.Name = "Transaccion";
            Transaccion.Size = new Size(121, 23);
            Transaccion.TabIndex = 11;
            // 
            // Depositos
            // 
            Depositos.BackColor = SystemColors.ControlLightLight;
            Depositos.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            Depositos.ForeColor = SystemColors.ActiveCaptionText;
            Depositos.Location = new Point(157, 103);
            Depositos.Name = "Depositos";
            Depositos.Size = new Size(100, 28);
            Depositos.TabIndex = 12;
            // 
            // Retiros
            // 
            Retiros.BackColor = SystemColors.ControlLightLight;
            Retiros.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            Retiros.ForeColor = SystemColors.ActiveCaptionText;
            Retiros.Location = new Point(157, 151);
            Retiros.Name = "Retiros";
            Retiros.Size = new Size(100, 28);
            Retiros.TabIndex = 13;
            // 
            // Balance
            // 
            Balance.BackColor = SystemColors.ControlLightLight;
            Balance.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            Balance.ForeColor = SystemColors.ActiveCaptionText;
            Balance.Location = new Point(157, 200);
            Balance.Name = "Balance";
            Balance.Size = new Size(100, 28);
            Balance.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(469, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(132, 23);
            dateTimePicker1.TabIndex = 15;
//            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Procesar
            // 
            Procesar.BackColor = Color.FromArgb(128, 128, 255);
            Procesar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Procesar.ForeColor = SystemColors.ControlLightLight;
            Procesar.Location = new Point(86, 277);
            Procesar.Name = "Procesar";
            Procesar.Size = new Size(109, 37);
            Procesar.TabIndex = 16;
            Procesar.Text = "Procesar";
            Procesar.UseVisualStyleBackColor = false;
            Procesar.Click += Procesar_Click_1;
            // 
            // Nuevo
            // 
            Nuevo.BackColor = Color.FromArgb(128, 128, 255);
            Nuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Nuevo.ForeColor = SystemColors.ControlLightLight;
            Nuevo.Location = new Point(285, 277);
            Nuevo.Name = "Nuevo";
            Nuevo.Size = new Size(94, 37);
            Nuevo.TabIndex = 17;
            Nuevo.Text = "Nuevo";
            Nuevo.UseVisualStyleBackColor = false;
            Nuevo.Click += Nuevo_Click_1;
            // 
            // Finalizar
            // 
            Finalizar.BackColor = Color.FromArgb(128, 128, 255);
            Finalizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Finalizar.ForeColor = SystemColors.ControlLightLight;
            Finalizar.Location = new Point(469, 277);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(121, 37);
            Finalizar.TabIndex = 18;
            Finalizar.Text = "Finalizar";
            Finalizar.UseVisualStyleBackColor = false;
            Finalizar.Click += Finalizar_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(128, 128, 255);
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(311, 98);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 19;
            label6.Text = "FECHA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(Finalizar);
            Controls.Add(Nuevo);
            Controls.Add(Procesar);
            Controls.Add(dateTimePicker1);
            Controls.Add(Balance);
            Controls.Add(Retiros);
            Controls.Add(Depositos);
            Controls.Add(Transaccion);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
    //        Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Procesar_Click;
        private Button Nuevo_Click;
        private Button Finalizar_Click;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox Transaccion;
        private TextBox Depositos;
        private TextBox Retiros;
        private TextBox Balance;
        private DateTimePicker dateTimePicker1;
        private Button Procesar;
        private Button Nuevo;
        private Button Finalizar;
        private Label label6;
        //private Button Procesar_Click;
        //private Button Nuevo_Click;
    }
}
