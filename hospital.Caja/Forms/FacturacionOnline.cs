using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospital.Caja.WSPrueba;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using static hospital.Caja.Dataset;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.Reporting.WinForms;
using hospital.Caja.DatasetTableAdapters;
using hospital.Caja.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace hospital.Caja
{

    public partial class FacturacionOnline : Form
    {
        private string user;
        private int idcliente;
<<<<<<< HEAD
=======
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
>>>>>>> 980f3f36a289d297b9bd8a8931c6f8e50111d27c

        public FacturacionOnline(string pUsuario, int IdCliente)
        {
            InitializeComponent();
            lblShow_Fecha.Text =  DateTime.Today.ToString("dd/MM/yyyy");
            user = pUsuario;
            CajaBDEntities caja = new CajaBDEntities();
            idcliente = IdCliente;


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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CajaBDEntities cajaBDofflineEntities = new CajaBDEntities();
            string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmFactura = null;
            SqlCommand cmReporte = new SqlCommand("ppInsertarReporte",sqlConnection);
            sqlConnection.Open(); 
            SqlTransaction transaction = sqlConnection.BeginTransaction();
            cmReporte.CommandType = CommandType.StoredProcedure;
            cmReporte.Transaction = transaction;
            

           

            int id_cliente, id_servicio, id_empleado, cod_factura;
            decimal monto, desseguro, TotalSeguro, TotalImporte, TotalFacturado, pagado,TotalPagar;

            var cliente = cajaBDofflineEntities.CLIENTE.FirstOrDefault(c => c.Nombre_Cliente == lblShow_Cliente.Text);
            var empleado = cajaBDofflineEntities.EMPLEADO.FirstOrDefault(em => em.Nombre_Empleado == lblShow_Empleado.Text);
            id_cliente = cliente.Id_Cliente;
            id_empleado = empleado.Id_Empleado;

            var ultimaFactura = cajaBDofflineEntities.FACTURA.OrderByDescending(uf => uf.Id_Factura).FirstOrDefault();

            if(ultimaFactura != null)
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
            try
            {
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


                    cmFactura = new SqlCommand();
                    cmFactura.Connection = sqlConnection;
                    cmFactura.CommandText = "ppInsertarFactura";
                    cmFactura.CommandType = System.Data.CommandType.StoredProcedure;
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
                       
                        MessageBox.Show("Factura Registrada. Presione Imprimir");
                        log.Info("Factura Registrada");

                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ocurrio un error: " + er.Message);
                        log.Error("Ocurrio un error: " + er.Message);
                    }



                }


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
                    
                }
                catch (Exception er)
                {
                    log.Error("Ocurrio un error: " + er.Message);
                }

                transaction.Commit();
            }
            catch (Exception er)
            {
                transaction.Rollback();
            }
            
            





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
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) )
            {
                MessageBox.Show("Por favor, ingrese codigo de servicio.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if( string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("No ha elegido un servicio.", "Servicio no elegido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var seguro = cajaBDofflineEntities.SEGURO.FirstOrDefault(s => s.Nombre_Seguro == lbl_ShowSeguro.Text);
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
                if(bandera == false)
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
            
            
           
           /* FacturaAdapter = facturaAdapter.GetData(cod_ultima_factura);

            report.Name = "Dataset";
            report.Value = FacturaAdapter;*/ 

          //  reportv
        }

        private void lblEliminar_Click(object sender, EventArgs e)
        {

        }

        private void lblShow_Empleado_Click(object sender, EventArgs e)
        {

        }

        private void lblFacturado_Por_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lvwFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FacturacionOnline_Load(object sender, EventArgs e)
        {
            CajaBDEntities caja = new CajaBDEntities();
            int idc = idcliente;
            var cliente = caja.CLIENTE.FirstOrDefault(c => c.Id_Cliente == idc);
            var seguro = caja.SEGURO.FirstOrDefault(c => c.Id_Seguro == cliente.Id_Seguro);

            string poliza, Nombre, Telefono, Seguro;
            poliza = cliente.Poliza;
            Telefono = cliente.Telefono;
            Nombre = cliente.Nombre_Cliente;
            Seguro = seguro.Nombre_Seguro;

            lblShow_Cliente.Text = Nombre;
            lbl_ShowSeguro.Text = Seguro;
            lblShow_Tel.Text = Telefono;
            lblShow_Poliza.Text = poliza;

        }
    }
}
