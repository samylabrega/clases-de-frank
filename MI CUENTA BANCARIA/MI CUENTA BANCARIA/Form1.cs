using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MI_CUENTA_BANCARIA
{
    public partial class Form1 : Form
    {
        private decimal saldo = 0;
        private int numeroTransaccion = 1;

        public Form1()
        {
            InitializeComponent();
            // Configura el ComboBox para que no sea editable 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            // Agrega opciones al ComboBox 
            comboBox1.Items.AddRange(new object[] { "ADMIN", "Josvir",
"Katte", "Josmar", "Juan", "Aimee" });
            // Establecer el TextBox de Balance como de solo lectura 
            Balance.ReadOnly = true;
        }
        private void Finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            // Agrega aquí el código para finalizar la aplicación o realizar otras acciones necesarias
            Application.Exit();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Depositos.Text = "";
            Retiros.Text = "";
            Balance.Text = "";
            Transaccion.Text = "";
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            {
                if (decimal.TryParse(Depositos.Text, out decimal deposito)
&&
                    decimal.TryParse(Retiros.Text, out decimal retiro))
                {
                    decimal balanceAnterior = saldo;
                    saldo = saldo + deposito - retiro;
                    Balance.Text = saldo.ToString("C");
                    Transaccion.Text = numeroTransaccion.ToString();
                    numeroTransaccion++;
                    MessageBox.Show($"Transacción #{numeroTransaccion}\nFecha: {DateTime.Now}\nBalance anterior: { balanceAnterior}\nDepósito: { deposito}\nRetiro: { retiro}\nNuevo balance: { saldo}"); 


                    numeroTransaccion++;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos para depósito y retiro."); 
                }
            }

        }
    }
}