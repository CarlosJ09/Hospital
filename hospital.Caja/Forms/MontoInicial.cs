using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital.Caja.Forms
{
    public partial class MontoInicial : Form
    {
        public MontoInicial()
        {
            InitializeComponent();
        }

        private void btnGuardarMonto_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
       
            SqlCommand cmMontoInicial = new SqlCommand("ppInsertarMontoInicial", sqlConnection);
            cmMontoInicial.CommandType = CommandType.StoredProcedure;

            SqlTransaction transaction = sqlConnection.BeginTransaction();
            if (string.IsNullOrWhiteSpace(txtMontoInicial.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor en el campo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                cmMontoInicial.Parameters.AddWithValue("@Monto", decimal.Parse(txtMontoInicial.Text));
                cmMontoInicial.Parameters.AddWithValue("@Fecha", DateTime.Today);
                MessageBox.Show("Monto inicial agregado", "Campo vacío", MessageBoxButtons.OK);


            }
        }

        private void txtMontoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b') // Verifica si no es un dígito ni la tecla de retroceso (backspace)
            {
                e.Handled = true; // Cancela el evento para evitar que el carácter se muestre en el TextBox
            }
            if (e.KeyChar == '.' && txtMontoInicial.Text.Contains("."))
            {
                e.Handled = true; // Cancela el evento si se intenta ingresar un segundo separador decimal
            }

        }
    }
}
