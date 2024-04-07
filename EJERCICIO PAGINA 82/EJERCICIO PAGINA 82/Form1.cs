using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_PAGINA_82
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Asociar manejadores de eventos a los botones 
            Aplicar.Click += Aplicar_Click;
            Limpiar.Click += Limpiar_Click;
            Salida.Click += Salida_Click;
        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            CalcularFuncionSeleccionada();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Salida_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CalcularFuncionSeleccionada()
        {
            double numero, resultado = 0;

            if (double.TryParse(textBox1.Text, out numero))
            {
                if (Seno.Checked)
                    resultado = Math.Sin(numero);
                else if (Coseno.Checked)
                    resultado = Math.Cos(numero);
                else if (Tangente.Checked)
                    resultado = Math.Tan(numero);
                else if (Arcotangente.Checked)
                    resultado = Math.Atan(numero);
                else if (Logaritmo.Checked)
                    resultado = Math.Log10(numero);
                else if (Raizcuadrada.Checked)
                    resultado = Math.Sqrt(numero);
                else if (Acoseno.Checked)
                    resultado = Math.Acos(numero);
                else if (Aseno.Checked)
                    resultado = Math.Asin(numero);

                textBox2.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            // Desmarcar todos los radio buttons 
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
        }

        private void CerrarFormulario()
        {
            this.Close();
        }
    }
}