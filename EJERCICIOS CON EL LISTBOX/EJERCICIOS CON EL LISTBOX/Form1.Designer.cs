namespace EJERCICIOS_CON_EL_LISTBOX
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
            this.Agregar = new System.Windows.Forms.Button();
            this.Ordenar = new System.Windows.Forms.Button();
            this.BorrarUno = new System.Windows.Forms.Button();
            this.BorrarTodo = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(441, 76);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(108, 35);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // Ordenar
            // 
            this.Ordenar.Location = new System.Drawing.Point(441, 117);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(108, 35);
            this.Ordenar.TabIndex = 1;
            this.Ordenar.Text = "Ordenar";
            this.Ordenar.UseVisualStyleBackColor = true;
            // 
            // BorrarUno
            // 
            this.BorrarUno.Location = new System.Drawing.Point(441, 158);
            this.BorrarUno.Name = "BorrarUno";
            this.BorrarUno.Size = new System.Drawing.Size(108, 35);
            this.BorrarUno.TabIndex = 2;
            this.BorrarUno.Text = "Borrar Uno";
            this.BorrarUno.UseVisualStyleBackColor = true;
            // 
            // BorrarTodo
            // 
            this.BorrarTodo.Location = new System.Drawing.Point(441, 199);
            this.BorrarTodo.Name = "BorrarTodo";
            this.BorrarTodo.Size = new System.Drawing.Size(108, 35);
            this.BorrarTodo.TabIndex = 3;
            this.BorrarTodo.Text = "Borrar Todo";
            this.BorrarTodo.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(441, 240);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(108, 35);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Items.AddRange(new object[] {
            "MICHAEL",
            "SASIRL",
            "RAYMOND",
            "CARLOS",
            "JOSE ",
            "PEDRO ",
            "JULIAN ",
            "NATTI"});
            this.Lista.Location = new System.Drawing.Point(198, 119);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(208, 160);
            this.Lista.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(198, 84);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(208, 26);
            this.Nombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ESCRIBE LOS NOMBRES AQUI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.BorrarTodo);
            this.Controls.Add(this.BorrarUno);
            this.Controls.Add(this.Ordenar);
            this.Controls.Add(this.Agregar);
            this.Name = "Form1";
            this.Text = "EJERCICIO CON EL LISTBOX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Ordenar;
        private System.Windows.Forms.Button BorrarUno;
        private System.Windows.Forms.Button BorrarTodo;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label1;
    }
}

