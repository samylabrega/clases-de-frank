using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTARIO_DE_MERCANCIA
{
    public partial class FINVENTARIO : Form
    {//DECLARAR VARIABLES 
        int NOAJUSTE = 1;
        double COMPRAS, VENTAS, EXISTENCIA;
        public FINVENTARIO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBNAJUSTE.Text = Convert.ToString(NOAJUSTE);
            TBNAJUSTE.Enabled = false;
            TBEXISTENCIA.Enabled = false;
            CBARTICULOS.Text = "ESCOJA EL ARTICULO DESEADO";
            TBCOMPRAS.Text = "0";
            TBVENTAS.Text = "0";
        }
        //CREACION DE METODO ENTRADAS QUE CONIVERTE LOS DATOS DE ENTRADA DESDE EL FORMULARIO
        //Y ASIGNA EL RESULTADO A LAS VARIABLES CORRESPONDIENTES 
        private void ENTRADAS()
        {
            try
            {
                COMPRAS = Convert.ToDouble(TBCOMPRAS.Text);
                VENTAS = Convert.ToDouble(TBVENTAS.Text);
            }
            catch
            {
                MessageBox.Show("LA ENTRADA NO ES VALIDA. TRATE DE NUEVO");
                TBCOMPRAS.Focus();

            }

        }
        //CREACION DEL METODO CALCULOS, CUYO OBJETIVO ES CALCULAR LA EXISTENCIA Y MOSTRAR
            //EL RESULTADO EN EL FORMULARIO 
            private void CALCULOS()
        {
            ENTRADAS();
            EXISTENCIA = (EXISTENCIA + COMPRAS) - VENTAS;

            TBEXISTENCIA.Text = Convert.ToString(EXISTENCIA);

        }
        private void NUEVO()
        {
            NOAJUSTE = NOAJUSTE + 1;
            TBNAJUSTE.Text = Convert.ToString(NOAJUSTE);
            CBARTICULOS.Text = "ESCOJA OTRO ARTICULO";
            TBCOMPRAS.Text = "0";
            TBVENTAS.Text = "0";

        }
        private void BCALCULAR_Click(object sender, EventArgs e)
        {
            CALCULOS();
        }

        private void BNUEVO_Click(object sender, EventArgs e)
        {
            NUEVO();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}