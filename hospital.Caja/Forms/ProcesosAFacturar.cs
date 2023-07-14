using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital.Caja
{
    
    public partial class ProcesosAFacturar : Form
    {
        private string userp;
        private string[] rProcesos;
        private bool formclosed = false;
        public ProcesosAFacturar(string user)
        {
            InitializeComponent();

            userp = user;
        }

        private void ProcesosAFacturar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.dataset.DataTable2);
            

        }

        private void dgvProcesos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna1, columna2;
            DataGridViewRow selectedRow = dgvProcesos.SelectedRows[0];
            DataGridViewRow row = dgvProcesos.Rows[e.RowIndex];
            // Verifica si todas las celdas de la fila seleccionada contienen valores no nulos ni vacíos
            bool filaNoVacia = true;
            try
            {
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    if (cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        btnFacturar.Enabled = false;
                        filaNoVacia = false;
                        break;
                    }
                }

                if (filaNoVacia)
                {
                    columna1 = row.Cells["clCliente"].Value.ToString();
                    columna2 = row.Cells["clDescripcion"].Value.ToString();
                    btnFacturar.Enabled = true;
                }
                else
                {
                    columna1 = "0";
                    columna2 = "0";
                }


                string[] registros = { columna1, columna2 };
                rProcesos = registros;
            }
            catch(Exception er)
            {
                MessageBox.Show("Por favor, seleccione una fila. (No una celda)", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            CajaBDEntities caja = new CajaBDEntities();
            string nombre = rProcesos[0];
            var cliente = caja.CLIENTE.FirstOrDefault(c => c.Nombre_Cliente == nombre);
            FacturacionOnline fo = new FacturacionOnline(userp,cliente.Id_Cliente);
            fo.FormClosed += Fo_FormClosed;
            btnFacturar.Enabled = !btnFacturar.Enabled;
            fo.ShowDialog();

           
            

        }

        private void Fo_FormClosed(object sender, FormClosedEventArgs e)
        {
            formclosed = true;
        }
    }
}
