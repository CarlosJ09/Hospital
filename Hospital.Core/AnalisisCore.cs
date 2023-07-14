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
    public partial class AnalisisCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public AnalisisCore()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AnalisisCore_Load(object sender, EventArgs e)
        {
            dataGridViewAnalisis.DataSource = objneg.N_Listar_Analisis();
        }

        private void dataGridViewAnalisis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewAnalisis.CurrentCell.RowIndex;
            txtIDAnalisis.Text = dataGridViewAnalisis[0, fila].Value.ToString();
            txtIDPacienteAnalisis.Text = dataGridViewAnalisis[1, fila].Value.ToString();
            txtTipoAnalsis.Text = dataGridViewAnalisis[2, fila].Value.ToString();
            txtFechaAnal.Text = dataGridViewAnalisis[3, fila].Value.ToString();
            txtResultadoAnal.Text = dataGridViewAnalisis[4, fila].Value.ToString();
            txtIDDoctorAnalsis.Text = dataGridViewAnalisis[5, fila].Value.ToString();
            txtObservacionAnal.Text = dataGridViewAnalisis[6, fila].Value.ToString();
            
        }

        void insertar()
        {

            objent.ID_Paciente = Convert.ToInt32(txtIDPacienteAnalisis.Text);
            objent.Tipo_Analisis = txtTipoAnalsis.Text;
            objent.Fecha_Analisis = Convert.ToDateTime(txtFechaAnal.Text);
            objent.Resultado_Analisis = txtResultadoAnal.Text;
            objent.Observaciones_Analisis = txtObservacionAnal.Text;

            dataGridViewAnalisis.DataSource = objneg.N_Insertar_Analisis(objent);
        }

        void Modificar()
        {

            objent.ID_Paciente = Convert.ToInt32(txtIDPacienteAnalisis.Text);
            objent.Tipo_Analisis = txtTipoAnalsis.Text;
            objent.Fecha_Analisis = Convert.ToDateTime(txtFechaAnal.Text);
            objent.Resultado_Analisis = txtResultadoAnal.Text;
            objent.Observaciones_Analisis = txtObservacionAnal.Text;

            dataGridViewAnalisis.DataSource = objneg.N_Actualizar_Analisis(objent);
        }


        void eliminar()
        {
            objent.ID_Analisis = int.Parse(txtIDAnalisis.Text);
            dataGridViewAnalisis.DataSource = objneg.N_Eliminar_Analisis(objent);
            foreach (DataGridViewRow row in dataGridViewAnalisis.Rows)
            {
                if (row.Cells["ID_Analisis"].Value.ToString() == txtIDAnalisis.Text)
                {
                    dataGridViewAnalisis.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void Limpiar()
        {
            txtIDAnalisis.Text = "";
            txtIDPacienteAnalisis.Text = "";
            txtTipoAnalsis.Text = "";
            txtFechaAnal.Text = "";
            txtResultadoAnal.Text = "";
            txtIDDoctorAnalsis.Text = "";
            txtObservacionAnal.Text = "";

            dataGridViewAnalisis.DataSource = objneg.N_Listar_Analisis();
        }

        private void btnNuevoAnalisis_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrarAnal_Click(object sender, EventArgs e)
        {
            if (txtIDAnalisis.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtIDAnalisis.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    insertar();
                    Limpiar();

                }
            }
        }

        private void btnModificarAnal_Click(object sender, EventArgs e)
        {
            if (txtIDAnalisis.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtIDAnalisis.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Modificar();
                    Limpiar();

                }
            }

        }

        private void btnEliminarAnal_Click(object sender, EventArgs e)
        {
            if (txtIDAnalisis.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtIDAnalisis.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    eliminar();
                    Limpiar();

                }
            }

        }
    }
}
