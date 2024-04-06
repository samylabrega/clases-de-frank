using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOS_CON_EL_LISTBOX
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            // Asociar los manejadores de eventos a los botones 
            Agregar.Click += Agregar_Click;
            Ordenar.Click += Ordenar_Click;
            BorrarUno.Click += BorrarUno_Click;
            BorrarTodo.Click += BorrarTodo_Click;
            Salir.Click += Salir_Click;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            // Agregar el nombre al ListBox 
            string nuevoNombre = Nombre.Text;
            if (!string.IsNullOrEmpty(nuevoNombre))
            {
                Lista.Items.Add(nuevoNombre);
                Nombre.Clear();
            }
        }

        private void Ordenar_Click(object sender, EventArgs e)
        {
            // Ordenar los elementos en el ListBox 
            Lista.Sorted = true;
        }

        private void BorrarUno_Click(object sender, EventArgs e)
        {
            // Borrar el nombre seleccionado del ListBox 
            if (Lista.SelectedIndex != -1)
            {
                Lista.Items.RemoveAt(Lista.SelectedIndex);
            }
        }

        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            // Borrar todos los elementos del ListBox 
            Lista.Items.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación 
            this.Close();
        }
    }
}