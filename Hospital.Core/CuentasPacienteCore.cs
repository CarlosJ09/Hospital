using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad_CORE_USER;
using CapaNegocio_CoreUSER;

namespace Hospital.Core
{
    public partial class CuentasPacienteCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public CuentasPacienteCore()
        {
            InitializeComponent();
        }

        private void CuentasPacienteCore_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_Listar_Cuentas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            txtIDCuenta.Text = dataGridView1[0, fila].Value.ToString();
            txtSeguro.Text = dataGridView1[1, fila].Value.ToString();
            txtNombrePaciente.Text = dataGridView1[2, fila].Value.ToString();
            txtTelefono.Text = dataGridView1[3, fila].Value.ToString();
            txtMedicoAsig.Text = dataGridView1[4, fila].Value.ToString();
            txtCondicionMedica.Text = dataGridView1[5, fila].Value.ToString();
            txtPlan.Text = dataGridView1[6, fila].Value.ToString();
        }

    }
}
