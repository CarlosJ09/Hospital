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
        private string user;
        public Home(string usuario)
        {
            InitializeComponent();
            user = usuario;
            CajaBDEntities caja = new CajaBDEntities();



            var empleado = caja.EMPLEADO.FirstOrDefault(em => em.Usuario == user);
            label1.Text = "Bienvenido "+empleado.Nombre_Empleado;
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
            FacturacionOffline f = new FacturacionOffline(user);
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

        private void btnOpenReporte_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
