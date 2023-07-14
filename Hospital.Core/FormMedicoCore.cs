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
    public partial class FormMedicoCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public FormMedicoCore()
        {
            InitializeComponent();
        }

        private void FormMedicoCore_Load(object sender, EventArgs e)
        {
            dataGridViewDoctor.DataSource = objneg.N_Listar_Doctor();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void dataGridViewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewDoctor.CurrentCell.RowIndex;
            txtIDDoctor.Text = dataGridViewDoctor[0, fila].Value.ToString();
            txtNombreDoc.Text = dataGridViewDoctor[1, fila].Value.ToString();
            txtFechNacDoc.Text = dataGridViewDoctor[2, fila].Value.ToString();
            txtDireccionDoc.Text = dataGridViewDoctor[3, fila].Value.ToString();
            txtTelefonoDoc.Text = dataGridViewDoctor[4, fila].Value.ToString();
            txtEspecialidadDoc.Text = dataGridViewDoctor[5, fila].Value.ToString();
            txtIDUSER.Text = dataGridViewDoctor[6, fila].Value.ToString();
            
        }

        void insertar()
        {
            
            objent.nombre_Doc = txtNombreDoc.Text;
            objent.Fecha_Naci_DOC = Convert.ToDateTime(txtFechNacDoc.Text);
            objent.Direccion_Med = txtDireccionDoc.Text;
            objent.telefono_Med = txtTelefonoDoc.Text;
            objent.especialidad = txtEspecialidadDoc.Text;
            objent.ID_Usuario = Convert.ToInt32(txtIDUSER.Text);


            dataGridViewDoctor.DataSource = objneg.N_Insertar_Doctor(objent);
        }

        void Modificar()
        {
            objent.nombre_Doc = txtNombreDoc.Text;
            objent.Fecha_Naci_DOC = Convert.ToDateTime(txtFechNacDoc.Text);
            objent.Direccion_Med = txtDireccionDoc.Text;
            objent.telefono_Med = txtTelefonoDoc.Text;
            objent.especialidad = txtEspecialidadDoc.Text;
            objent.ID_Usuario = Convert.ToInt32(txtIDUSER.Text);


            dataGridViewDoctor.DataSource = objneg.N_Actualizar_Doctor(objent);
        }


        void Eliminar()
        {
            objent.ID_Doctor = int.Parse(txtIDDoctor.Text);
            dataGridViewDoctor.DataSource = objneg.N_Eliminar_Doctor(objent);
            foreach (DataGridViewRow row in dataGridViewDoctor.Rows)
            {
                if (row.Cells["ID_Doctor"].Value.ToString() == txtIDDoctor.Text)
                {
                    dataGridViewDoctor.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void Limpiar()
        {
            txtIDDoctor.Text = "";
            txtNombreDoc.Text = "";
            txtFechNacDoc.Text = "";
            txtDireccionDoc.Text = "";
            txtTelefonoDoc.Text = "";
            txtEspecialidadDoc.Text = "";
            txtIDUSER.Text = "";

            dataGridViewDoctor.DataSource = objneg.N_Listar_Doctor();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIDDoctor.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtNombreDoc.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    insertar();
                    Limpiar();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIDDoctor.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtNombreDoc.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Modificar();
                    Limpiar();

                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDDoctor.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtNombreDoc.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Eliminar();
                    Limpiar();

                }
            }

        }
    }
}
