using PruebaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital.Caja
{
    public partial class FacturacionOnline : Form
    {
        double totalFacturado = 0;
        double totalSeguro = 0;
        double totalImporte = 0;
        double pagarBalance = 0; 
        public FacturacionOnline()
        {
            InitializeComponent();
            

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

        private void Button1_Click(object sender, EventArgs e)
        {
            //WSPrueba.WSBDSoapClient ws = new WSPrueba.WSBDSoapClient();

            //try
            //{
            //    ws.crearFactura("Rafael Pichardo", "40231347119", 1, "9999", "8094401615");
            //}
            //catch(Exception er)
            //{
            //    MessageBox.Show(er.Message);
            //}



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            //int Codigo = int.Parse(txtCodigo.Text);
            //CajaOfflineEntities cajaBDofflineEntities = new CajaOfflineEntities();
            //try
            //{
            //    var servicio = cajaBDofflineEntities.SERVICIOS.FirstOrDefault(s => s.Id_Servicio == Codigo);
            //    txtDescripcion.Text = servicio.Nombre_Servicio;
            //    txtPrecio.Text = servicio.Precio.ToString();

            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show(er.Message);
            //}
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CajaOfflineEntities cajaBDofflineEntities = new CajaOfflineEntities();
           
            var seguro = cajaBDofflineEntities.SEGURO.FirstOrDefault(s => s.Nombre_Seguro == lbl_ShowSeguro.Text);
            float desSeguro = (float)seguro.Des_Porcentaje * float.Parse(txtPrecio.Text);
            float importe = 0.5f * (float.Parse(txtPrecio.Text) - desSeguro);
            desSeguro *= 1.00f;
            importe *= 1.00f;
            string[] fila = { txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, desSeguro.ToString(), importe.ToString() };
            lvwFactura.Items.Add(new ListViewItem(fila));
            calcularTotales();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwFactura.Items)
            {
                // Obtén el valor del campo "ID"
                string Codigo = item.SubItems[0].Text; // Suponiendo que "ID" es la primera columna (índice 0)

                // Verifica si el valor de "ID" coincide con el valor deseado
                if (Codigo == txtEliminar.Text)
                {
                    // Elimina la fila
                    lvwFactura.Items.Remove(item);
                    break; // Opcional: si solo esperas una coincidencia, puedes salir del bucle después de eliminar la fila
                }
            }
            calcularTotales();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FacturacionDiaria formulario = new FacturacionDiaria();

            formulario.ShowDialog();
        }

        private void lblShow_Tel_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblShow_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblShow_Total_Seguro_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lvwFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            CajaBDEntities cajaBDofflineEntities = new CajaBDEntities();
            string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        }
    }
}
