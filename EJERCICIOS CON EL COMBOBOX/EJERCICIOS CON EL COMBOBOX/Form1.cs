using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOS_CON_EL_COMBOBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Asociar los manejadores de eventos a los botones y TextBox 
            Calcular.Click += Calcular_Click;
            Nuevo.Click += Nuevo_Click;
            Finalizar.Click += Finalizar_Click;

            // Configurar el ComboBox 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Asociar el manejador de eventos KeyPress para permitir solo números
            Primervalor.KeyPress += SoloNumeros_KeyPress;
            Segundovalor.KeyPress += SoloNumeros_KeyPress;
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            // Obtener los valores y la operación seleccionada 
            double primerValor, segundoValor, resultado = 0;

            if (double.TryParse(Primervalor.Text, out primerValor) &&
double.TryParse(Segundovalor.Text, out segundoValor))
            {
                // Realizar la operación seleccionada 
                switch (comboBox1.SelectedItem?.ToString())
                {
                    case "Suma":
                        resultado = primerValor + segundoValor;
                        break;
                    case "Resta":
                        resultado = primerValor - segundoValor;
                        break;
                    case "Multiplicar":
                        resultado = primerValor * segundoValor;
                        break;
                    case "Dividir":
                        if (segundoValor != 0)
                            resultado = primerValor / segundoValor;
                        else
                            MessageBox.Show("No se puede dividir por cero."); 
                        break;
                    case "Potencia":
                        resultado = Math.Pow(primerValor, segundoValor);
                        break;
                    default:
                        MessageBox.Show("Seleccione una operación válida.");
                        break;
                }

                // Mostrar el resultado 
                Resultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            // Limpiar los campos 
            Primervalor.Clear();
            Segundovalor.Clear();
            Resultado.Clear();
            comboBox1.SelectedIndex = -1; // Limpiar la selección del ComboBox
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación 
            Close();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs
e)
        {
            // Permitir solo dígitos numéricos, el punto decimal y la tecla deretroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.')
> -1))
            {
                e.Handled = true;
            }
        }
    }
}