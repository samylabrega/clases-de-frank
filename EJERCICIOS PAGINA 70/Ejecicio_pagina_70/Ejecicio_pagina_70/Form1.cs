using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecicio_pagina_70
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Asocia los manejadores de eventos 
            Suma.CheckedChanged += Operacion_CheckedChanged;
            Resta.CheckedChanged += Operacion_CheckedChanged;
            Multiplicacion.CheckedChanged += Operacion_CheckedChanged;
            Division.CheckedChanged += Operacion_CheckedChanged;
            Potencia.CheckedChanged += Operacion_CheckedChanged;
            Limpiar.CheckedChanged += Operacion_CheckedChanged;
            Salir.CheckedChanged += Operacion_CheckedChanged;
        }

        private void Operacion_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                // Verifica qué RadioButton está seleccionado 
                switch (radioButton.Name)
                {
                    case "Suma":
                        RealizarOperacion("Suma");
                        break;
                    case "Resta":
                        RealizarOperacion("Resta");
                        break;
                    case "Multiplicacion":
                        RealizarOperacion("Multiplicacion");
                        break;
                    case "Division":
                        RealizarOperacion("Division");
                        break;
                    case "Potencia":
                        RealizarOperacion("Potencia");
                        break;
                    case "Limpiar":
                        LimpiarCampos();
                        break;
                    case "Salir":
                        CerrarFormulario();
                        break;
                }
            }
        }

        private void RealizarOperacion(string operacion)
        {
            double primerValor, segundoValor, resultado = 0;

            if (double.TryParse(Primervalor.Text, out primerValor) && double.TryParse(Segundovalor.Text, out segundoValor))
            {
                switch (operacion)
                {
                    case "Suma":
                        resultado = primerValor + segundoValor;
                        break;
                    case "Resta":
                        resultado = primerValor - segundoValor;
                        break;
                    case "Multiplicacion":
                        resultado = primerValor * segundoValor;
                        break;
                    case "Division":
                        if (segundoValor != 0)
                            resultado = primerValor / segundoValor;
                        else
                            MessageBox.Show("No se puede dividir por cero."); 
                            break;
                    case "Potencia":
                        resultado = Math.Pow(primerValor, segundoValor);
                        break;
                }

                Resultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
            }
        }

        private void LimpiarCampos()
        {
            Primervalor.Clear();
            Segundovalor.Clear();
            Resultado.Clear();
        }

        private void CerrarFormulario()
        {
            this.Close();
        }
    }
}