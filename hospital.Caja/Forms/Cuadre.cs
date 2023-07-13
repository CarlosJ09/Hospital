using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital.Caja.Forms
{
    public partial class Cuadre : Form
    {
        public Cuadre()
        {
            InitializeComponent();
        }

        private void Cuadre_Load(object sender, EventArgs e)
        {
            CajaBDEntities cajaBD = new CajaBDEntities();
            decimal ganancias = 0,suma;
            var ultimasF = cajaBD.REPORTE.Where(f => f.Fecha == DateTime.Today);
            var ultimomonto = cajaBD.MontoInicial.OrderByDescending(u => u.Id).FirstOrDefault();
            

            foreach(var item in ultimasF)
            {
                ganancias += (decimal)item.Total_Balance;
            }

            suma = ganancias + ultimomonto.Monto_Inicial;
            lblMontoInicial.Text = ultimomonto.Monto_Inicial.ToString();
            lblGanancias.Text = ganancias.ToString();
            lblMontoFinal.Text = suma.ToString();
        }

        private void lblMontoInicial_Click(object sender, EventArgs e)
        {

        }
    }
}
