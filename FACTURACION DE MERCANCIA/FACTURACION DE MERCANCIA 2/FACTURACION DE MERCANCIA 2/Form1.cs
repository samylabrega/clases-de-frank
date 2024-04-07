using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURACION_DE_MERCANCIA_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int numeroFactura { get; set; }
        public double cantidad { get; set; }
        public double precio { get; set; }
        public double subtotal { get; set; }
        public double itbs { get; set; }
        public double total { get; set; }
        public double totalArticulos { get; set; }
        public double totalVentas { get; set; }
        public double totalItbs { get; set; }
        public double totalFacturas { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            numeroFactura = 1;
            txtNFactura.Text = Convert.ToString(numeroFactura);
            txtNFactura.Enabled = false;
            txtSubtotal.Enabled = false;
            txtITBS.Enabled = false;
            txtTotal.Enabled = false;
            txtCantidad.Text = "0";
            txtPrecio.Text = "0";
            cbArticulo.Text = "Escojer un articulo";
        }
        public void Entradas()
        {
            try
            {
                cantidad = Convert.ToDouble(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entrada Invalida, Intente otra vez.");
                Console.WriteLine(ex.ToString());
            }
        }
        public void calcularFacturas()
        {
            Entradas();
            subtotal = cantidad * precio;
            itbs = subtotal * 0.18;
            total = subtotal + itbs;
            //Total Ariticulos [EN GENERAL]
            totalArticulos = total + cantidad;
            totalVentas = totalVentas + subtotal;
            totalItbs = totalItbs + itbs;
            totalFacturas = totalFacturas + total;
            lbl_TG.Text = "Total Articulos: " +
           Convert.ToString(totalArticulos);
            lbl_TV.Text = "Total Ventas: " +
           Convert.ToString(totalVentas);
            lbl_itbis.Text = "Total ITBS: " + Convert.ToString(totalItbs);
            lbl_TF.Text = "Total Facturas: " +
           Convert.ToString(totalFacturas);
            txtSubtotal.Text = "Total Subtotal: " +
           Convert.ToString(subtotal);
            txtITBS.Text =  Convert.ToString(itbs);
            txtTotal.Text =  Convert.ToString(total);
        }
        public void Salidas()
        {
            calcularFacturas();
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtITBS.Text = Convert.ToString(itbs);
            txtTotal.Text = Convert.ToString(total);
        }
        public void nuevoArticulo()
        {
            
            cbArticulo.Text = "Escoja otro articulo";       
            txtTotal.Text = "0";
            cantidad = 0;
            txtCantidad.Text = "0"; 
            txtPrecio.Text = "0";
            precio = 0;
            subtotal = 0;
            txtSubtotal.Text = string.Empty;
            txtITBS.Text = string.Empty;
            itbs = 0;
            txtSubtotal.Text = string.Empty;

        }
        
                public void nuevaFactura()
        {
            nuevoArticulo();
            numeroFactura++;
            txtNFactura.Text = Convert.ToString(numeroFactura);
            totalArticulos = 0;
            totalVentas = 0;
            totalItbs = 0;
            totalFacturas = 0;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NF_Click(object sender, EventArgs e)
        {

        }

        private void btn_CF_Click(object sender, EventArgs e)
        {

            Entradas();
            //Formulas();
            Salidas();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_NA_Click(object sender, EventArgs e)
        {
            nuevoArticulo();
        }
    }
}
