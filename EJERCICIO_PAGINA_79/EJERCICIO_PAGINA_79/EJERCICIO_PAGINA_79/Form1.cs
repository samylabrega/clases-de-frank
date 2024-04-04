using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_PAGINA_79
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            // Asociar manejadores de eventos a los botones 
            Calcular.Click += Calcular_Click;
            Limpiar.Click += Limpiar_Click;
            Salir.Click += Salir_Click;

            // Generar un número aleatorio para el código 
            Codigo.Text = random.Next(1000, 9999).ToString();

            // Configurar propiedades de los campos 
            //Vendedor.DropDownStyle = ComboBoxStyle.DropDownList; // No editable
            //Totales.ReadOnly = true;
            //ITBISES.ReadOnly = true;
            //Comisiones.ReadOnly = true;
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            CalcularNomina();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CalcularNomina()
        {
            try
            {
                // Obtener los valores de los campos 
                //string vendedorSeleccionado = Vendedor.SelectedItem?.ToString();
                double sueldo = Convert.ToDouble(Sueldos.Text);
                double venta = Convert.ToDouble(Venta.Text);

                // Calcular comisión 
                double comision = (venta >= 100000) ? venta * 0.1 : venta * 0.05;

                // Calcular ITBIS 
                double itbis = venta * 0.18;

                // Calcular el total 
                double total = sueldo + venta + comision + itbis;

                // Mostrar los resultados en los campos correspondientes 
                Comisiones.Text = comision.ToString("C");
                ITBISES.Text = itbis.ToString("C");
                Totales.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la nómina: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los campos 
            Codigo.Text = random.Next(1000, 9999).ToString();
            //Vendedor.SelectedIndex = -1;
            //Sueldos.Clear();
            //Venta.Clear();
            //Totales.Clear();
            //ITBISES.Clear();
            //Comisiones.Clear();
        }

        private void CerrarFormulario()
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
