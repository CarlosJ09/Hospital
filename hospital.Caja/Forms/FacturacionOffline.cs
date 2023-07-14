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
    public partial class FacturacionOffline : Form
    {
        private string user;
        public FacturacionOffline(string pUsuario)
        {
            InitializeComponent();
            lblShow_Fecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            
            user = pUsuario;
            CajaBDEntities caja = new CajaBDEntities();
            Login lo = new Login();
            

            var empleado = caja.EMPLEADO.FirstOrDefault(em => em.Usuario == user);
            lblShow_Empleado.Text = empleado.Nombre_Empleado;

        }
        
        public void calcularTotales()
        {

            float TotalFacturado = 0.00f, TotalImporte = 0.00f, TotalSeguro = 0.00f, TotalPagar;
            foreach (ListViewItem item in lvwFactura.Items)
            {

                string Facturado = item.SubItems[2].Text;
                string Importe = item.SubItems[4].Text;
                string Seguro = item.SubItems[3].Text;


                TotalFacturado += float.Parse(Facturado);
                TotalImporte += float.Parse(Importe);
                TotalSeguro += float.Parse(Seguro);


            }

            TotalPagar = TotalFacturado + TotalImporte - TotalSeguro;

            lblShow_Total_Facturado.Text = TotalFacturado.ToString();
            lblShow_Total_Seguro.Text = TotalSeguro.ToString();
            lblShow_Total_Importe.Text = TotalImporte.ToString();
            lblShow_Balance_a_pagar.Text = TotalPagar.ToString();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CajaBDEntities cajaBDofflineEntities = new CajaBDEntities();
            string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlTransaction transaction = sqlConnection.BeginTransaction();
            SqlCommand cmFactura = null;
            SqlCommand cmReporte = new SqlCommand("ppInsertarReporte", sqlConnection,transaction);
            
            
            
            cmReporte.CommandType = CommandType.StoredProcedure;
           
            string selectedText = cbSeguro.Text;
            var seguro = cajaBDofflineEntities.SEGURO.FirstOrDefault(s => s.Nombre_Seguro == selectedText);
            int id_seguro = seguro.Id_Seguro;

            
            
           

            int id_cliente, id_servicio, id_empleado, cod_factura;
            decimal monto, desseguro, TotalSeguro, TotalImporte, TotalFacturado, pagado, TotalPagar;

            var cliente = cajaBDofflineEntities.CLIENTE.FirstOrDefault(c => c.Cedula_Cliente == txtCedula.Text);
            var empleado = cajaBDofflineEntities.EMPLEADO.FirstOrDefault(em => em.Nombre_Empleado == lblShow_Empleado.Text);
            id_cliente = cliente.Id_Cliente;
            id_empleado = empleado.Id_Empleado;

            var ultimaFactura = cajaBDofflineEntities.FACTURA.OrderByDescending(uf => uf.Id_Factura).FirstOrDefault();

            if (ultimaFactura != null)
            {
                cod_factura = ultimaFactura.Id_Factura;
            }
            else
            {
                cod_factura = 1;
            }
            TotalFacturado = decimal.Parse(lblShow_Total_Facturado.Text);
            TotalSeguro = decimal.Parse(lblShow_Total_Seguro.Text);
            TotalPagar = decimal.Parse(lblShow_Balance_a_pagar.Text);
            TotalImporte = decimal.Parse(lblShow_Total_Importe.Text);

            foreach (ListViewItem item in lvwFactura.Items)
            {

                int Codigo_Servicio = int.Parse(item.SubItems[0].Text); // Suponiendo que "ID" es la primera columna (índice 0)
                decimal Precio = decimal.Parse(item.SubItems[2].Text);
                decimal Seguro = decimal.Parse(item.SubItems[3].Text);
                decimal Importe = decimal.Parse(item.SubItems[4].Text);

                id_servicio = Codigo_Servicio;
                monto = Precio;
                desseguro = Seguro;
                pagado = monto - desseguro + Importe;





                sqlConnection.Open();


                cmFactura = new SqlCommand();
                cmFactura.Connection = sqlConnection;
                cmFactura.CommandType = System.Data.CommandType.StoredProcedure;
                cmFactura.CommandText = "ppInsertarFactura";
                cmFactura.Transaction = transaction;

                try
                {
                    cmFactura.Parameters.AddWithValue("@IdCliente", id_cliente);
                    cmFactura.Parameters.AddWithValue("@IdServicio", id_servicio);
                    cmFactura.Parameters.AddWithValue("@Monto", monto);
                    cmFactura.Parameters.AddWithValue("@DesSeguro", desseguro);
                    cmFactura.Parameters.AddWithValue("@Pagado", pagado);
                    cmFactura.Parameters.AddWithValue("@Fecha", DateTime.Today);
                    cmFactura.Parameters.AddWithValue("@IdEmpleado", id_empleado);
                    cmFactura.Parameters.AddWithValue("@Importe", Importe);
                    cmFactura.Parameters.AddWithValue("@Estado", 0);
                    cmFactura.Parameters.AddWithValue("@Cod_Factura", cod_factura);
                    cmFactura.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    transaction.Rollback();
                }
                


               
                

                sqlConnection.Close();





            }
            sqlConnection.Open();

            try
            {
                cmReporte.Parameters.AddWithValue("@Id_Cliente", id_cliente);
                cmReporte.Parameters.AddWithValue("@Cod_Factura", cod_factura);
                cmReporte.Parameters.AddWithValue("@Id_Empleado", id_empleado);
                cmReporte.Parameters.AddWithValue("@Total_Facturado", TotalFacturado);
                cmReporte.Parameters.AddWithValue("@Total_Seguro", TotalSeguro);
                cmReporte.Parameters.AddWithValue("@Tota_Importe", TotalImporte);
                cmReporte.Parameters.AddWithValue("@Fecha", DateTime.Today);

                cmReporte.Parameters.AddWithValue("@Total_Balance", TotalPagar);

                cmReporte.ExecuteNonQuery();
                transaction.Commit();
            }catch (Exception er)
            {
                MessageBox.Show(er.Message);
                transaction.Rollback();
            }
            

            sqlConnection.Close();


        }

        private void FacturacionOffline_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset.SEGURO' table. You can move, or remove it, as needed.
            this.sEGUROTableAdapter.Fill(this.dataset.SEGURO);
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Codigo;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor en el campo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus(); // Opcional: poner el foco en el TextBox para que el usuario pueda ingresar el valor directamente
            }
            else
            {
                Codigo = int.Parse(txtCodigo.Text);
                CajaBDEntities cajaBDofflineEntities = new CajaBDEntities();

                var servicio = cajaBDofflineEntities.SERVICIOS.FirstOrDefault(s => s.Id_Servicio == Codigo);
                txtDescripcion.Text = servicio.Nombre_Servicio;
                txtPrecio.Text = servicio.Precio.ToString();


            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CajaBDEntities cajaBDofflineEntities = new CajaBDEntities();
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, ingrese codigo de servicio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("No ha elegido un servicio.", "Servicio no elegido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var seguro = cajaBDofflineEntities.SEGURO.FirstOrDefault(s => s.Nombre_Seguro == cbSeguro.Text);
                float desSeguro = (float)seguro.Des_Porcentaje * float.Parse(txtPrecio.Text);
                float importe = 0.05f * (float.Parse(txtPrecio.Text) - desSeguro);

                string[] fila = { txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, desSeguro.ToString(), importe.ToString() };
                lvwFactura.Items.Add(new ListViewItem(fila));
                calcularTotales();
            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Por favor, ingrese codigo de servicio a eliminar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                foreach (ListViewItem item in lvwFactura.Items)
                {
                    // Obtén el valor del campo "ID"
                    string Codigo = item.SubItems[0].Text; // Suponiendo que "ID" es la primera columna (índice 0)

                    if (Codigo == txtEliminar.Text)
                    {
                        // Elimina la fila
                        lvwFactura.Items.Remove(item);

                        break; // Opcional: si solo esperas una coincidencia, puedes salir del bucle después de eliminar la fila
                    }
                    // Verifica si el valor de "ID" coincide con el valor deseado
                    bandera = false;
                }
                if (bandera == false)
                {
                    MessageBox.Show("Ese codigo no se encuentra en el tablero.", "Codigo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                calcularTotales();
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            FacturaImpresion fi = new FacturaImpresion();
            fi.ShowDialog();

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Verifica si no es un dígito ni la tecla de retroceso (backspace)
            {
                e.Handled = true; // Cancela el evento para evitar que el carácter se muestre en el TextBox
            }
        }

        private void txtPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Verifica si no es un dígito ni la tecla de retroceso (backspace)
            {
                e.Handled = true; // Cancela el evento para evitar que el carácter se muestre en el TextBox
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Verifica si no es un dígito ni la tecla de retroceso (backspace)
            {
                e.Handled = true; // Cancela el evento para evitar que el carácter se muestre en el TextBox
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Verifica si no es un dígito ni la tecla de retroceso (backspace)
            {
                e.Handled = true; // Cancela el evento para evitar que el carácter se muestre en el TextBox
            }
        }

        private void txtEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Verifica si no es un dígito ni la tecla de retroceso (backspace)
            {
                e.Handled = true; // Cancela el evento para evitar que el carácter se muestre en el TextBox
            }
        }

        private void txtPoliza_TextChanged(object sender, EventArgs e)
        {
            int maxDigits = 14; // Número máximo de dígitos permitidos

            if (txtPoliza.Text.Length > maxDigits)
            {
                txtPoliza.Text = txtPoliza.Text.Substring(0, maxDigits); // Limita la longitud del texto al número máximo de dígitos permitidos
                txtPoliza.SelectionStart = maxDigits; // Establece el cursor al final del texto
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            int maxDigits = 11; // Número máximo de dígitos permitidos

            if (txtTelefono.Text.Length > maxDigits)
            {
                txtTelefono.Text = txtTelefono.Text.Substring(0, maxDigits); // Limita la longitud del texto al número máximo de dígitos permitidos
                txtTelefono.SelectionStart = maxDigits; // Establece el cursor al final del texto
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            int maxDigits = 11; // Número máximo de dígitos permitidos

            if (txtCedula.Text.Length > maxDigits)
            {
                txtCedula.Text = txtCedula.Text.Substring(0, maxDigits); // Limita la longitud del texto al número máximo de dígitos permitidos
                txtCedula.SelectionStart = maxDigits; // Establece el cursor al final del texto
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            CajaBDEntities cajaBDofflineEntities = new CajaBDEntities();
            string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            
            sqlConnection.Open();
            SqlTransaction transaction = sqlConnection.BeginTransaction();
            SqlCommand cmCliente = new SqlCommand("ppInsertarCliente", sqlConnection);
            cmCliente.CommandType = CommandType.StoredProcedure;
            cmCliente.Transaction = transaction;
            string selectedText = cbSeguro.Text;
            var seguro = cajaBDofflineEntities.SEGURO.FirstOrDefault(s => s.Nombre_Seguro == selectedText);
            int id_seguro = seguro.Id_Seguro;

            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text)|| string.IsNullOrWhiteSpace(txtCedula.Text)|| string.IsNullOrWhiteSpace(txtPoliza.Text)|| string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, ingrese los datos del cliente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    cmCliente.Parameters.AddWithValue("@Nombre_Cliente", txtNombreCliente.Text);
                    cmCliente.Parameters.AddWithValue("@Id_Seguro", id_seguro);
                    cmCliente.Parameters.AddWithValue("@Cedula_Cliente", txtCedula.Text);
                    cmCliente.Parameters.AddWithValue("@Poliza", txtPoliza.Text);
                    cmCliente.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                    cmCliente.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Cliente Agregado");
                    txtCedula.Enabled = !txtCedula.Enabled;
                    txtPoliza.Enabled = !txtPoliza.Enabled;
                    txtNombreCliente.Enabled = !txtNombreCliente.Enabled;
                    txtTelefono.Enabled = !txtTelefono.Enabled;
                    cbSeguro.Enabled = !cbSeguro.Enabled;
                    txtCodigo.Enabled = !txtCodigo.Enabled;
                }
                catch (Exception er)
                {
                    transaction.Rollback();
                    MessageBox.Show(er.Message);
                }

                sqlConnection.Close();
            }
            
        }
    }
}
