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
    public partial class FormDeAltaCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public FormDeAltaCore()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormDeAltaCore_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_Listar_DeAlta();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            txtIDAlta.Text = dataGridView1[0, fila].Value.ToString();
            txtIDIngreso.Text = dataGridView1[1, fila].Value.ToString();
            txtFechaAlta.Text = dataGridView1[2, fila].Value.ToString();
            txtDiagnostico.Text = dataGridView1[3, fila].Value.ToString();
            txtTratamiento.Text = dataGridView1[4, fila].Value.ToString();
            txtObservaciones.Text = dataGridView1[5, fila].Value.ToString();

        }


        void Insertar()
        {
            
            objent.ID_ingreso = int.Parse(txtIDIngreso.Text);
            objent.Fecha_Hora_Alta = DateTime.Parse(txtFechaAlta.Text);
            objent.Diagnostico = txtDiagnostico.Text;
            objent.Tratamiento = txtTratamiento.Text;
            objent.Observaciones = txtObservaciones.Text;

            dataGridView1.DataSource = objneg.N_Insertar_DeAlta(objent);
        }

        void Actualizar()
        {
            objent.ID_Alta = int.Parse(txtIDAlta.Text);
            objent.ID_ingreso = int.Parse(txtIDIngreso.Text);
            objent.Fecha_Hora_Alta = DateTime.Parse(txtFechaAlta.Text);
            objent.Diagnostico = txtDiagnostico.Text;
            objent.Tratamiento = txtTratamiento.Text;
            objent.Observaciones = txtObservaciones.Text;

            dataGridView1.DataSource = objneg.N_Actualizar_DeAlta(objent);
        }

        void Eliminar()
        {
            objent.ID_Alta = int.Parse(txtIDAlta.Text);

            dataGridView1.DataSource = objneg.N_Eliminar_DeAlta(objent);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID_Alta"].Value.ToString() == txtIDAlta.Text)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void Limpiar()
        {
            txtIDAlta.Text = "";
            txtIDIngreso.Text = "";
            txtFechaAlta.Text = "";
            txtDiagnostico.Text = "";
            txtTratamiento.Text = "";
            txtObservaciones.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtIDAlta.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtIDAlta.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Insertar();
                    Limpiar();

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIDAlta.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtIDAlta.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Actualizar();
                    Limpiar();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIDAlta.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtIDAlta.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Eliminar();
                    Limpiar();

                }
            }

        }
    }
}
