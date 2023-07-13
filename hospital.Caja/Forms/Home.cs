using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital.Caja.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnOpenFacturar_Click(object sender, EventArgs e)
        {
            FacturacionOnline f = new FacturacionOnline();
            f.ShowDialog();
        }

        private void btnOpenProcesos_Click(object sender, EventArgs e)
        {
            ProcesosAFacturar p = new ProcesosAFacturar();
            p.ShowDialog();
        }

        private void btnOpenMontoInicial_Click(object sender, EventArgs e)
        {
            MontoInicial m = new MontoInicial();
            m.ShowDialog();
        }

        private void btnOpenCuadre_Click(object sender, EventArgs e)
        {

            Cuadre m = new Cuadre();
            m.ShowDialog();
        }
    }
}
