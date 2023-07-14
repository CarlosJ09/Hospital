using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hospital.Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        } 

        //Para poder mover el form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMax.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            BtnMax.Visible = true;

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelhead_MouseDown(object sender, MouseEventArgs e)
        {
          //Para que se mueva el form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPacienteCore frPac = new FormPacienteCore();
            if (this.panel2.Controls.Count > 0) 
            this.panel2.Controls.RemoveAt(0);
            frPac.TopLevel = false;
            frPac.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frPac);
            this.panel2.Tag = frPac;
            frPac.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUsuarios frUser = new FormUsuarios();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frUser.TopLevel = false;
            frUser.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frUser);
            this.panel2.Tag = frUser;
            frUser.Show();
        }

        private void btnPerfilMenu_Click(object sender, EventArgs e)
        {
            PerfilBaseCore frperfil = new PerfilBaseCore();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frperfil.TopLevel = false;
            frperfil.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frperfil);
            this.panel2.Tag = frperfil;
            frperfil.Show();

        }

        private void btnProcedMedMenu_Click(object sender, EventArgs e)
        {
            HistorialMedicoCore frHist = new HistorialMedicoCore();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frHist.TopLevel = false;
            frHist.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frHist);
            this.panel2.Tag = frHist;
            frHist.Show();
        }

        private void btmAnalMenu_Click(object sender, EventArgs e)
        {
            AnalisisCore frAnal = new AnalisisCore();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frAnal.TopLevel = false;
            frAnal.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frAnal);
            this.panel2.Tag = frAnal;
            frAnal.Show();
        }

        private void btnProcedMedi_Click(object sender, EventArgs e)
        {
            ProcedimientoMedico frProced = new ProcedimientoMedico();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frProced.TopLevel = false;
            frProced.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frProced);
            this.panel2.Tag = frProced;
            frProced.Show();
        }

        private void btnIngresosMenu_Click(object sender, EventArgs e)
        {
            IngresosPacienteCore frProced = new IngresosPacienteCore();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frProced.TopLevel = false;
            frProced.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frProced);
            this.panel2.Tag = frProced;
            frProced.Show();
        }

        private void btnAltasPac_Click(object sender, EventArgs e)
        {
            FormDeAltaCore frProced = new FormDeAltaCore();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frProced.TopLevel = false;
            frProced.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frProced);
            this.panel2.Tag = frProced;
            frProced.Show();
        }

        private void btnAutorizacionMenu_Click(object sender, EventArgs e)
        {
            AutorizacionMedicaCore frAutor = new AutorizacionMedicaCore();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frAutor.TopLevel = false;
            frAutor.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frAutor);
            this.panel2.Tag = frAutor;
            frAutor.Show();
        }

        private void btnCuentasMenu_Click(object sender, EventArgs e)
        {
            CuentasPacienteCore frcuent = new CuentasPacienteCore();
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frcuent.TopLevel = false;
            frcuent.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frcuent);
            this.panel2.Tag = frcuent;
            frcuent.Show();
        }
    }
}
