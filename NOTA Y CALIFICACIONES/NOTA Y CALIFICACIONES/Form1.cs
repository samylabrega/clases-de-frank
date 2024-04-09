using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTA_Y_CALIFICACIONES
{
    public partial class Form1 : Form
    {


        private Random random = new Random();
        private List<string> matriculas = new List<string> {
"Matricula1", "Matricula2", "Matricula3" };
        private List<string> materias = new List<string> { "Materia1",
"Materia2", "Materia3" };
        private List<string> profesores = new List<string> {
"Profesor1", "Profesor2", "Profesor3" };

        public Form1()
        {
            InitializeComponent();

            // Asociar manejadores de eventos a los botones 
            Procesar.Click += Procesar_Click;
            OtraNota.Click += OtraNota_Click;
            Nuevo.Click += Nuevo_Click;
            Salir.Click += Salir_Click;

            // Configurar propiedades de los campos 
            Clasificacion.ReadOnly = true;
            Registro.ReadOnly = true;
            Registro.Text = GenerarNumeroAleatorio().ToString();

            // Llenar ComboBox con datos predefinidos 
            Matricula.DataSource = matriculas;
            Materia.DataSource = materias;
            Profesor.DataSource = profesores;
        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            CalcularClasificacion();
        }

        private void OtraNota_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Registro.Text = GenerarNumeroAleatorio().ToString();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Registro.Text = GenerarNumeroAleatorio().ToString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CalcularClasificacion()
        {
            try
            {
                // Obtener los valores de los campos 
                double primerParcial = Convert.ToDouble(PP.Text);
                double segundoParcial = Convert.ToDouble(SP.Text);
                double practicas = Convert.ToDouble(Practicas.Text);
                double examenFinal = Convert.ToDouble(EF.Text);

                // Calcular total y clasificación 
                double totalNota = primerParcial + segundoParcial +
practicas + examenFinal;

                string clasificacion;

                if (totalNota >= 70)
                    clasificacion = "Aprobado";
                else
                    clasificacion = "Reprobado";

                // Mostrar resultados 
                TN.Text = totalNota.ToString();
                Clasificacion.Text = clasificacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la clasificación: " +
ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los campos 
            PP.Clear();
            SP.Clear();
            Practicas.Clear();
            EF.Clear();
            TN.Clear();
            Clasificacion.Clear();
        }

        private void CerrarFormulario()
        {
            this.Close();
        }

        private int GenerarNumeroAleatorio()
        {
            return random.Next(1000, 9999);
        }
    }
}
