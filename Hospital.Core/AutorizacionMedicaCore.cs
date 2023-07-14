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
    public partial class AutorizacionMedicaCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public AutorizacionMedicaCore()
        {
            InitializeComponent();
        }

        private void AutorizacionMedicaCore_Load(object sender, EventArgs e)
        {
            dataGridViewAutor.DataSource = objneg.N_Listar_Autorizaciones();
        }

        private void dataGridViewAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewAutor.CurrentCell.RowIndex;
            txtIDAutorizacion.Text = dataGridViewAutor[0, fila].Value.ToString();
            txtIDPaciente.Text = dataGridViewAutor[1, fila].Value.ToString();
            txtIDProced.Text = dataGridViewAutor[2, fila].Value.ToString();
            txtIDdoctor.Text = dataGridViewAutor[3, fila].Value.ToString();
            txtFecha.Text = dataGridViewAutor[4, fila].Value.ToString();
            txtdescripcion.Text = dataGridViewAutor[5, fila].Value.ToString();
            txtEstadoAutori.Text = dataGridViewAutor[6, fila].Value.ToString();

        }

        void InsertarAutorizacion()
        {
            objent.ID_Paciente = int.Parse(txtIDPaciente.Text);
            objent.ID_Procedimiento = int.Parse(txtIDProced.Text);
            objent.ID_Doctor = int.Parse(txtIDdoctor.Text);
            objent.Fecha_Autorizacion = DateTime.Parse(txtFecha.Text);
            objent.Descripcion_Autorizacion = txtdescripcion.Text;
            objent.Estado_Autorizacion = txtEstadoAutori.Text;

            dataGridViewAutor.DataSource = objneg.N_Insertar_Autorizacion(objent);
        }

        void ModificarAutorizacion()
        {
            objent.ID_Paciente = int.Parse(txtIDPaciente.Text);
            objent.ID_Procedimiento = int.Parse(txtIDProced.Text);
            objent.ID_Doctor = int.Parse(txtIDdoctor.Text);
            objent.Fecha_Autorizacion = DateTime.Parse(txtFecha.Text);
            objent.Descripcion_Autorizacion = txtdescripcion.Text;
            objent.Estado_Autorizacion = txtEstadoAutori.Text;

            dataGridViewAutor.DataSource = objneg.N_Actualizar_Autorizacion(objent);
        }

        void EliminarAutorizacion()
        {
            objent.ID_Autorizacion = int.Parse(txtIDAutorizacion.Text);
            dataGridViewAutor.DataSource = objneg.N_Eliminar_Autorizacion(objent);
            foreach (DataGridViewRow row in dataGridViewAutor.Rows)
            {
                if (row.Cells["ID_Autorizacion"].Value.ToString() == txtIDAutorizacion.Text)
                {
                    dataGridViewAutor.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void LimpiarAutorizacion()
        {
            txtIDAutorizacion.Text = "";
            txtIDPaciente.Text = "";
            txtIDProced.Text = "";
            txtIDdoctor.Text = "";
            txtFecha.Text = "";
            txtdescripcion.Text = "";
            txtEstadoAutori.Text = "";

            dataGridViewAutor.DataSource = objneg.N_Listar_Autorizaciones();
        }

        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {
            LimpiarAutorizacion();
        }

        private void btnRegistrarAuto_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtIDAutorizacion.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    InsertarAutorizacion();
                    LimpiarAutorizacion();

                }
            }
        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtIDAutorizacion.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    ModificarAutorizacion();
                    LimpiarAutorizacion();

                }
            }

        }

        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtIDAutorizacion.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    EliminarAutorizacion();
                    LimpiarAutorizacion();

                }
            }

        }
    }
}
