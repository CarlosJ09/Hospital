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
    public partial class ProcedimientoMedico : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public ProcedimientoMedico()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProcedimientoMedico_Load(object sender, EventArgs e)
        {
            dataGridViewProceso.DataSource = objneg.N_Listar_ProcedMedicos();
        }

        private void dataGridViewProceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewProceso.CurrentCell.RowIndex;
            txtIDProcedimiento.Text = dataGridViewProceso[0, fila].Value.ToString();
            txtNombreProce.Text = dataGridViewProceso[1, fila].Value.ToString();
            txtDescProce.Text = dataGridViewProceso[2, fila].Value.ToString();
            txtCategoriaProce.Text = dataGridViewProceso[3, fila].Value.ToString();
            txtCostoProc.Text = dataGridViewProceso[4, fila].Value.ToString();
            txtIDDoctor.Text = dataGridViewProceso[5, fila].Value.ToString();
            txtIDPaciente.Text = dataGridViewProceso[6, fila].Value.ToString();
            txtFechaProce.Text = dataGridViewProceso[7, fila].Value.ToString();
        }

        void insertar()
        {
            objent.Nombre_Proced = txtNombreProce.Text;
            objent.Descripcion_Proced = txtDescProce.Text;
            objent.Categoria_Proced = txtCategoriaProce.Text;
            objent.Costo_Proced = (float)Convert.ToDouble(txtCostoProc.Text);
            objent.ID_Doctor = Convert.ToInt32(txtIDDoctor.Text);
            objent.ID_Paciente = Convert.ToInt32(txtIDPaciente.Text);
            objent.Fecha_Proced = Convert.ToDateTime(txtFechaProce.Text);

            dataGridViewProceso.DataSource = objneg.N_Insertar_ProcedMed(objent);
        }

        void Modificar()
        {
            objent.ID_Procedimiento = Convert.ToInt32(txtIDProcedimiento.Text);
            objent.Nombre_Proced = txtNombreProce.Text;
            objent.Descripcion_Proced = txtDescProce.Text;
            objent.Categoria_Proced = txtCategoriaProce.Text;
            objent.Costo_Proced = (float)Convert.ToDouble(txtCostoProc.Text);
            objent.ID_Doctor = Convert.ToInt32(txtIDDoctor.Text);
            objent.ID_Paciente = Convert.ToInt32(txtIDPaciente.Text);
            objent.Fecha_Proced = Convert.ToDateTime(txtFechaProce.Text);

            dataGridViewProceso.DataSource = objneg.N_Acutualizar_ProcedMed(objent);
        }


        void eliminar()
        {
            objent.ID_Procedimiento = int.Parse(txtIDProcedimiento.Text);
            dataGridViewProceso.DataSource = objneg.N_Eliminar_ProcedMed(objent);
            foreach (DataGridViewRow row in dataGridViewProceso.Rows)
            {
                if (row.Cells["ID_Procedimiento"].Value.ToString() == txtIDProcedimiento.Text)
                {
                    dataGridViewProceso.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void Limpiar()
        {
            txtIDProcedimiento.Text = "";
            txtNombreProce.Text = "";
            txtDescProce.Text = "";
            txtCategoriaProce.Text = "";
            txtCostoProc.Text = "";
            txtIDDoctor.Text = "";
            txtIDPaciente.Text = "";
            txtFechaProce.Text = "";

            dataGridViewProceso.DataSource = objneg.N_Listar_Paciente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtIDProcedimiento.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    insertar();
                    Limpiar();

                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIDProcedimiento.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtIDProcedimiento.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Modificar();
                    Limpiar();

                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDProcedimiento.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtIDProcedimiento.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    eliminar();
                    Limpiar();

                }
            }
        }
    }
}
