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
    public partial class FormUsuarios : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            txtIDUsuario.Text = dataGridView1[0, fila].Value.ToString();
            txtNombreUsuario.Text = dataGridView1[1, fila].Value.ToString();
            txtContraseñaUsuario.Text = dataGridView1[2, fila].Value.ToString();
            txtRolUsuario.Text = dataGridView1[3, fila].Value.ToString();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_Listar_Usuarios();
        }

        
        void insertar ()
        {
            objent.Nombre_Usuario = txtNombreUsuario.Text;
            objent.Contraseña = txtContraseñaUsuario.Text;
            objent.Nombre_Rol = txtRolUsuario.Text;

            dataGridView1.DataSource = objneg.N_Insertar_Usuario(objent);
        } 

        void Modificar()
        {
            objent.ID_Usuario =int.Parse(txtIDUsuario.Text);
            objent.Nombre_Usuario = txtNombreUsuario.Text;
            objent.Contraseña = txtContraseñaUsuario.Text;
            objent.Nombre_Rol = txtRolUsuario.Text;

            dataGridView1.DataSource = objneg.N_Actualizar_Usuario(objent);
        }


        void eliminar()
        {
            objent.ID_Usuario = int.Parse(txtIDUsuario.Text);
            dataGridView1.DataSource = objneg.N_Eliminar_Usuario(objent);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                   if (row.Cells["ID_Usuario"].Value.ToString() == txtIDUsuario.Text)
                   {
                      dataGridView1.Rows.RemoveAt(row.Index);
                      break;
                   }
            }
        }

        void Limpiar()
        {
            txtIDUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseñaUsuario.Text = "";
            txtRolUsuario.Text = "";

            dataGridView1.DataSource = objneg.N_Listar_Usuarios();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtIDUsuario.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtNombreUsuario.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    insertar();
                    Limpiar();

                }
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtIDUsuario.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtNombreUsuario.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Modificar();
                    Limpiar();

                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDUsuario.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtNombreUsuario.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    eliminar();
                    Limpiar();

                }
            }
        }
    }
}
