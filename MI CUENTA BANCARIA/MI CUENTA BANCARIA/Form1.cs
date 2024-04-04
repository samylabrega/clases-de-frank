using System.Transactions;

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

        private void Finalizar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            // Agrega aqu� el c�digo para finalizar la aplicaci�n o realizar otras acciones necesarias
            Application.Exit();
        }

        private void Procesar_Click_1(object sender, EventArgs e)
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
                    MessageBox.Show($"Transacci�n #{numeroTransaccion}\nFecha: {DateTime.Now}\nBalance anterior: {balanceAnterior}\nDep�sito: {deposito}\nRetiro: {retiro}\nNuevo balance: {saldo}");


                    numeroTransaccion++;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores num�ricos v�lidos para dep�sito y retiro.");
                }
            }
        }

        private void Nuevo_Click_1(object sender, EventArgs e)
        {
            Depositos.Text = "";
            Retiros.Text = "";
            Balance.Text = "";
            Transaccion.Text = "";
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

     

       
    }
}