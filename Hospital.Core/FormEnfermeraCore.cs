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
    public partial class FormEnfermeraCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();

        public FormEnfermeraCore()
        {
            InitializeComponent();
        }

        private void FormEnfermeraCore_Load(object sender, EventArgs e)
        {
            dataGridViewEnfer.DataSource = objneg.N_Listar_Enfermera();
        }

        private void dataGridViewEnfer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewEnfer.CurrentCell.RowIndex;
            txtIDEnfermera.Text = dataGridViewEnfer[0, fila].Value.ToString();
            txtNombreEnfer.Text = dataGridViewEnfer[1, fila].Value.ToString();
            txtApellidoEnfer.Text = dataGridViewEnfer[2, fila].Value.ToString();
            txtFechaNacEnfer.Text = dataGridViewEnfer[3, fila].Value.ToString();
            txtDireccionEnfer.Text = dataGridViewEnfer[4, fila].Value.ToString();
            txtTelefonoEnfer.Text = dataGridViewEnfer[5, fila].Value.ToString();
            txtEspecialidadEnfer.Text = dataGridViewEnfer[6, fila].Value.ToString();

        }

        void insertar()
        {
            objent.Nombre_Enfer = txtNombreEnfer.Text;
            objent.Apellido_Enfer = txtApellidoEnfer.Text;
            objent.Direccion_Enfer = txtDireccionEnfer.Text;
            objent.Telefono_Enfer = Convert.ToInt32(txtTelefonoEnfer.Text);
            objent.Fecha_Naci_Enfer = Convert.ToDateTime(txtFechaNacEnfer.Text);
            objent.Especialidad_Enfer = txtEspecialidadEnfer.Text;


            dataGridViewEnfer.DataSource = objneg.N_Insertar_Enfermera(objent);
        }

        void Modificar()
        {
            objent.Nombre_Enfer = txtNombreEnfer.Text;
            objent.Apellido_Enfer = txtApellidoEnfer.Text;
            objent.Direccion_Enfer = txtDireccionEnfer.Text;
            objent.Telefono_Enfer = Convert.ToInt32(txtTelefonoEnfer.Text);
            objent.Fecha_Naci_Enfer = Convert.ToDateTime(txtFechaNacEnfer.Text);
            objent.Especialidad_Enfer = txtEspecialidadEnfer.Text;


            dataGridViewEnfer.DataSource = objneg.N_Actualizar_Enfermera(objent);
        }


        void eliminar()
        {
            objent.ID_Paciente = int.Parse(txtIDEnfermera.Text);
            dataGridViewEnfer.DataSource = objneg.N_Eliminar_Enfermera(objent);
            foreach (DataGridViewRow row in dataGridViewEnfer.Rows)
            {
                if (row.Cells["ID_Enfermera"].Value.ToString() == txtIDEnfermera.Text)
                {
                    dataGridViewEnfer.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void Limpiar()
        {
            txtIDEnfermera.Text = "";
            txtNombreEnfer.Text = "";
            txtApellidoEnfer.Text = "";
            txtFechaNacEnfer.Text = "";
            txtDireccionEnfer.Text = "";
            txtTelefonoEnfer.Text = "";
            txtEspecialidadEnfer.Text = "";


            dataGridViewEnfer.DataSource = objneg.N_Listar_Enfermera();
        }

        private void btnNuevoEnfer_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrarEnfer_Click(object sender, EventArgs e)
        {
            if (txtIDEnfermera.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtNombreEnfer.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    insertar();
                    Limpiar();

                }
            }
        }

        private void btnModificarEnfer_Click(object sender, EventArgs e)
        {
            if (txtIDEnfermera.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtNombreEnfer.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Modificar();
                    Limpiar();

                }
            }
        }

        private void btnEliminarEnfer_Click(object sender, EventArgs e)
        {
            if (txtIDEnfermera.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtNombreEnfer.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    eliminar();
                    Limpiar();

                }
            }
        }
    }
}
