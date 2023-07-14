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
    public partial class HistorialMedicoCore : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public HistorialMedicoCore()
        {
            InitializeComponent();
        }

        private void HistorialMedicoCore_Load(object sender, EventArgs e)
        {
            dataGridViewHistorial.DataSource = objneg.N_Listar_HistorialMedico();
        }

        private void dataGridViewHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewHistorial.CurrentCell.RowIndex;
            txtIDHistorial.Text = dataGridViewHistorial[0, fila].Value.ToString();
            txtIDPacienteHist.Text = dataGridViewHistorial[1, fila].Value.ToString();
            txtAnteMedicos.Text = dataGridViewHistorial[2, fila].Value.ToString();
            txtTratamientoAct.Text = dataGridViewHistorial[3, fila].Value.ToString();
            txtHistEnfermedad.Text = dataGridViewHistorial[4, fila].Value.ToString();
            txtResultPrueba.Text = dataGridViewHistorial[5, fila].Value.ToString();
            txtEnfermedadesHere.Text = dataGridViewHistorial[6, fila].Value.ToString();
            txtEstadoHist.Text = dataGridViewHistorial[7, fila].Value.ToString();
            txtIDEnfermeHist.Text = dataGridViewHistorial[8, fila].Value.ToString();
        }

        void insertar()
        {
            objent.ID_Paciente = Convert.ToInt32(txtIDPacienteHist.Text);
            objent.Antecedentes_Medicos = txtAnteMedicos.Text;
            objent.Tratamiento_Actual = txtTratamientoAct.Text;
            objent.Historial_Enfermedades = txtHistEnfermedad.Text;
            objent.Resultado_PruebaMedica = txtResultPrueba.Text;
            objent.Enfermedades_Hereditarias = txtEnfermedadesHere.Text;
            objent.Estado = txtEstadoHist.Text;
            objent.ID_Enfermera = Convert.ToInt32(txtIDEnfermeHist.Text);

            dataGridViewHistorial.DataSource = objneg.N_Insertar_HistorialMedico(objent);
        }

        void Modificar()
        {
            objent.ID_Paciente = Convert.ToInt32(txtIDPacienteHist.Text);
            objent.Antecedentes_Medicos = txtAnteMedicos.Text;
            objent.Tratamiento_Actual = txtTratamientoAct.Text;
            objent.Historial_Enfermedades = txtHistEnfermedad.Text;
            objent.Resultado_PruebaMedica = txtResultPrueba.Text;
            objent.Enfermedades_Hereditarias = txtEnfermedadesHere.Text;
            objent.Estado = txtEstadoHist.Text;
            objent.ID_Enfermera = Convert.ToInt32(txtIDEnfermeHist.Text);


            dataGridViewHistorial.DataSource = objneg.N_Actualizar_HistorialMedico(objent);
        }


        void eliminar()
        {
            objent.ID_Paciente = int.Parse(txtIDHistorial.Text);
            dataGridViewHistorial.DataSource = objneg.N_Eliminar_HistorialMedico(objent);
            foreach (DataGridViewRow row in dataGridViewHistorial.Rows)
            {
                if (row.Cells["ID_Historial"].Value.ToString() == txtIDHistorial.Text)
                {
                    dataGridViewHistorial.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }

        void Limpiar()
        {
            txtIDHistorial.Text = "";
            txtIDPacienteHist.Text = "";
            txtAnteMedicos.Text = "";
            txtTratamientoAct.Text = "";
            txtHistEnfermedad.Text = "";
            txtResultPrueba.Text = "";
            txtEnfermedadesHere.Text = "";
            txtEstadoHist.Text = "";
            txtIDEnfermeHist.Text = "";

            dataGridViewHistorial.DataSource = objneg.N_Listar_HistorialMedico();
        }

        private void btnNuevoHisto_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrarHisto_Click(object sender, EventArgs e)
        {
            if (txtIDHistorial.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a" + txtIDHistorial.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    insertar();
                    Limpiar();

                }
            }
        }

        private void btnModificarHisto_Click(object sender, EventArgs e)
        {
            if (txtIDHistorial.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a" + txtIDHistorial.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Modificar();
                    Limpiar();

                }
            }

        }

        private void btnEliminarHisto_Click(object sender, EventArgs e)
        {
            if (txtIDHistorial.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a" + txtIDHistorial.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    eliminar();
                    Limpiar();

                }
            }

        }
    }
}
