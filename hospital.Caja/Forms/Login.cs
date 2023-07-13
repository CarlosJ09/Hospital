using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace hospital.Caja.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CajaBDEntities cajaBD = new CajaBDEntities();
            FacturacionOnline fo = new FacturacionOnline();
            Home home = new Home();
            FacturaImpresion fi = new FacturaImpresion();
            var result = cajaBD.ppLogin(txtUser.Text, txtPassword.Text).FirstOrDefault();
            Thread thread = new Thread(() =>
            {
                Application.Run(home);
            });
            if (result != null)
            {
                MessageBox.Show(result); // Accede a la propiedad "Message"

                // Si el inicio de sesión es exitoso, realiza las acciones necesarias
                if (result == "Inicio de sesion existoso!")
                {
                    this.Close();
                    thread.Start();
                    
                }
            }


        }
    }
}
