using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using log4net;

namespace hospital.Caja.Forms
{
    
    public partial class Login : Form
    {
<<<<<<< HEAD
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

=======
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
>>>>>>> 5d354ff92e331237db608f63ef4768bf4b3c42c0
        public Login()
        {
            InitializeComponent();
        }
        private string UsuarioP;
        public string Usuario { get { return txtUser.Text; } }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
          
>>>>>>> 5d354ff92e331237db608f63ef4768bf4b3c42c0
            CajaBDEntities cajaBD = new CajaBDEntities();
            
            Home home = new Home(txtUser.Text);
            
            FacturaImpresion fi = new FacturaImpresion();
            
            var result = cajaBD.ppLogin(txtUser.Text, txtPassword.Text).FirstOrDefault();
            Thread thread = new Thread(() =>
            {
                Application.Run(home);
            });
            if (result != null)
            {
                log.Info("Inicio de sesion exitoso para el usuario: " + txtUser.Text);
                MessageBox.Show(result); // Accede a la propiedad "Message"

                // Si el inicio de sesión es exitoso, realiza las acciones necesarias
                if (result == "Inicio de sesion existoso!")
                {
                    string u = txtUser.Text;
                    log.Info(txtUser.Text+" ha iniciado sesion.");
                    this.Close();
                    thread.Start();

                }
                else
                {
                    log.Info(result);
                }

            }
            else
            {
                log.Error("Inicio de sesion fallido: " + txtUser.Text);
            }


        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
