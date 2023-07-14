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
    public partial class FormPacienteCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public FormPacienteCore()
        {
            InitializeComponent();
        }

        private void FormPacienteCore_Load(object sender, EventArgs e)
        {
            dataGridViewPaciente.DataSource = objneg.N_Listar_Paciente();
        }

        private void dataGridViewPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewPaciente.CurrentCell.RowIndex;
            txtIDPaciente.Text = dataGridViewPaciente[0, fila].Value.ToString();
            txtNombrePaciente.Text = dataGridViewPaciente[1, fila].Value.ToString();
            txtDNIPaciente.Text = dataGridViewPaciente[2, fila].Value.ToString();
            txtDireccionPaciente.Text = dataGridViewPaciente[3, fila].Value.ToString();
            txtTelefonopac.Text = dataGridViewPaciente[4, fila].Value.ToString();
            txtGrupoSanguineoPac.Text = dataGridViewPaciente[5, fila].Value.ToString();
            txtEdadPac.Text = dataGridViewPaciente[6, fila].Value.ToString();
            txtSexoPaciente.Text = dataGridViewPaciente[7, fila].Value.ToString();
        }

        void insertar()
        {
            objent.Nombre_Paciente = txtNombrePaciente.Text;
            objent.DNI = Convert.ToInt32(txtDNIPaciente.Text);
            objent.sexo = txtSexoPaciente.Text;
            objent.direccion = txtDireccionPaciente.Text;
            objent.telefono = Convert.ToInt32(txtTelefonopac.Text);
            objent.edad = Convert.ToInt32(txtEdadPac.Text);
            objent.grupo_sanguineo = txtGrupoSanguineoPac.Text;
            

            dataGridViewPaciente.DataSource = objneg.N_Insertar_Paciente(objent);
        }

        void Modificar()
        {
            objent.Nombre_Paciente = txtNombrePaciente.Text;
            objent.DNI = Convert.ToInt32(txtDNIPaciente.Text);
            objent.sexo = txtSexoPaciente.Text;
            objent.direccion = txtDireccionPaciente.Text;
            objent.telefono = Convert.ToInt32(txtTelefonopac.Text);
            objent.edad = Convert.ToInt32(txtEdadPac.Text);
            objent.grupo_sanguineo = txtGrupoSanguineoPac.Text;
           

            dataGridViewPaciente.DataSource = objneg.N_Actualizar_Paciente(objent);
        }


        void eliminar()
        {
            objent.ID_Paciente = int.Parse(txtIDPaciente.Text);
            dataGridViewPaciente.DataSource = objneg.N_Eliminar_Paciente(objent);
            foreach (DataGridViewRow row in dataGridViewPaciente.Rows)
            {
                if (row.Cells["ID_Paciente"].Value.ToString() == txtIDPaciente.Text)
                {
                    dataGridViewPaciente.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void Limpiar()
        {
            txtIDPaciente.Text = "";
            txtNombrePaciente.Text = "";
            txtDNIPaciente.Text = "";
            txtDireccionPaciente.Text = "";
            txtTelefonopac.Text = "";
            txtGrupoSanguineoPac.Text = "";
            txtEdadPac.Text = "";
            txtSexoPaciente.Text = "";

            dataGridViewPaciente.DataSource = objneg.N_Listar_Paciente();
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtNombrePaciente.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    insertar();
                    Limpiar();

                }
            }
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtNombrePaciente.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Modificar();
                    Limpiar();

                }
            }
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (txtIDPaciente.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtNombrePaciente.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    eliminar();
                    Limpiar();

                }
            }

        }
    }
}
