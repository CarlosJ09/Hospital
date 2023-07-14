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
    public partial class FacturaImpresion : Form
    {
        public FacturaImpresion()
        {
            InitializeComponent();
        }

        private void FacturaImpresion_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            CajaBDEntities cajaBD = new CajaBDEntities();
            var ultimafactura = cajaBD.FACTURA.OrderByDescending(f => f.Cod_Factura).FirstOrDefault();
            int cod_ultima_factura = ultimafactura.Cod_Factura;
            // TODO: This line of code loads data into the 'dataset.FACTURA' table. You can move, or remove it, as needed.
            this.fACTURATableAdapter.Fill(this.dataset.FACTURA,cod_ultima_factura);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
