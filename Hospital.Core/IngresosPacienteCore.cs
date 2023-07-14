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
    public partial class IngresosPacienteCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public IngresosPacienteCore()
        {
            InitializeComponent();
        }

        private void IngresosPacienteCore_Load(object sender, EventArgs e)
        {
            dataGridViewIngreso.DataSource = objneg.N_Listar_Ingreso();
        }

        private void dataGridViewAlta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewIngreso.CurrentCell.RowIndex;
            txtIDIngreso.Text = dataGridViewIngreso[0, fila].Value.ToString();
            txtID_Paciente.Text = dataGridViewIngreso[1, fila].Value.ToString();
            txtIDDoctor.Text = dataGridViewIngreso[2, fila].Value.ToString();
            txtFechaIngreso.Text = dataGridViewIngreso[3, fila].Value.ToString();
            txtMotivoIngreso.Text = dataGridViewIngreso[4, fila].Value.ToString();
           
        }

        void insertar()
        {
            objent.ID_Paciente = Convert.ToInt32(txtID_Paciente.Text);
            objent.ID_Doctor = Convert.ToInt32(txtIDDoctor.Text);
            objent.Fecha_Hora_Ingreso = Convert.ToDateTime(txtIDDoctor.Text);
            objent.Motivo_Ingres = txtMotivoIngreso.Text;

            dataGridViewIngreso.DataSource = objneg.N_Insertar_Ingreso(objent);
        }

        void Modificar()
        {

            objent.ID_ingreso = Convert.ToInt32(txtIDIngreso);
            objent.ID_Paciente = Convert.ToInt32(txtID_Paciente.Text);
            objent.ID_Doctor = Convert.ToInt32(txtIDDoctor.Text);
            objent.Fecha_Hora_Ingreso = Convert.ToDateTime(txtIDDoctor.Text);
            objent.Motivo_Ingres = txtMotivoIngreso.Text;

            dataGridViewIngreso.DataSource = objneg.N_Actualizar_Ingreso(objent);
        }


        void eliminar()
        {
            objent.ID_Paciente = int.Parse(txtIDIngreso.Text);
            dataGridViewIngreso.DataSource = objneg.N_Eliminar_Ingreso(objent);
            foreach (DataGridViewRow row in dataGridViewIngreso.Rows)
            {
                if (row.Cells["ID_ingreso"].Value.ToString() == txtIDIngreso.Text)
                {
                    dataGridViewIngreso.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void Limpiar()
        {
            txtIDIngreso.Text = "";
            txtID_Paciente.Text = "";
            txtIDDoctor.Text = "";
            txtFechaIngreso.Text = "";
            txtMotivoIngreso.Text = "";

            dataGridViewIngreso.DataSource = objneg.N_Listar_Ingreso();
        }
    }
}
