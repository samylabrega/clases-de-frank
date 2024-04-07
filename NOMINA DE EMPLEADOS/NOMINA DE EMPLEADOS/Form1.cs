using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOMINA_DE_EMPLEADOS
{
    public partial class FNOMINA : Form
    {
        double SUELDO, AFP, ARS, TDESC, SUELDONETO, TOTALSUELDO, TOTALAFP, TOTALARS,
DESCUENTOS, TOTALNETO;

        private void BFINALIZAR_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BNUEVO_Click_1(object sender, EventArgs e)
        {
            NUEVO();
        }

        private void BPROCESAR_Click_1(object sender, EventArgs e)
        {
            SALIDAS();
        }

        private void BFINALIZAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BNUEVO_Click(object sender, EventArgs e)
        {
            NUEVO();
        }

        private void BPROCESAR_Click(object sender, EventArgs e)
        {
            PROCESAR();
            SALIDAS();
        }

        private void FNOMINA_Load(object sender, EventArgs e)
        {
            CBDEPARTAMENTO.Text = "ESCJA EL DEPARTAMENTO AL QUE PERTENECE EL EMPLEADO"; 
            CBEMPLEADOS.Text = "ESCOJA EL NOMBRE DEL EMPLEDO";
            TBSUELDO.Text = "0";
        }

        public FNOMINA()
        {
            InitializeComponent();
            CBDEPARTAMENTO.Items.Add("TECNOLOGIA DE LA INFORMACION");
            CBDEPARTAMENTO.Items.Add("CONTABILIDAD");
            CBDEPARTAMENTO.Items.Add("VENTAS");
            CBEMPLEADOS.Items.Add("JOSE DEL VILLAR");
            CBEMPLEADOS.Items.Add("MARIO ALONSO");
            CBEMPLEADOS.Items.Add("FIORDALIZA SODEVILA");
            CBEMPLEADOS.Items.Add("IROINELLIS REYES");
        }
        private void ENTRADAS()
        {
            try
            {
                SUELDO = Convert.ToDouble(TBSUELDO.Text);
            }
            catch
            {
                MessageBox.Show("DEBE INTRODUCIR UN VALOR NUMERICO");
            }
        }
        private void PROCESAR()
        {
            ENTRADAS();
            AFP = SUELDO * 0.0287;
            ARS = SUELDO * 0.0304;
            TDESC = AFP + ARS;
            SUELDONETO = SUELDO - TDESC;
            //CALCULAR ACUMULADORES 
            TOTALSUELDO = TOTALSUELDO + SUELDO;
            TOTALAFP = TOTALAFP + AFP;
            TOTALARS = TOTALARS + ARS;
            DESCUENTOS = DESCUENTOS + TDESC;
            TOTALNETO = TOTALNETO + SUELDONETO;
        }
        private void SALIDAS()
        {
            PROCESAR();
            TBAFP.Text = AFP.ToString();
            TBARS.Text = ARS.ToString();
            TBTDESC.Text = TDESC.ToString();
            TBSNETO.Text = SUELDONETO.ToString();
            TBTOTALSUELDOS.Text = TOTALSUELDO.ToString();
            TBTOTALAFP.Text = TOTALAFP.ToString();
            TBTOTALARS.Text = TOTALARS.ToString();
            TBDESCUENTOS.Text = DESCUENTOS.ToString();
            TBTOTALNETO.Text = TOTALNETO.ToString();
        }
        private void NUEVO()
        {
            CBEMPLEADOS.Text = "ESCOJA EL SIGUIENTE EMPLEADO";
            CBDEPARTAMENTO.Text = "ESCOJA EL DEPARTAMENTO";
            SUELDO = 0;
            AFP = 0;
            ARS = 0;
            TDESC = 0;
            SUELDONETO = 0;
            TBSUELDO.Text = "0";
            TBAFP.Clear();
            TBARS.Clear();
            TBTDESC.Clear();
            TBSNETO.Clear();

        }
       
    }
}
