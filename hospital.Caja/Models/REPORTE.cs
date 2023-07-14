using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Caja.Models
{
    public partial class REPORTE
    {
        public int Id_Indice { get; set; }
        public int Id_Cliente { get; set; }
        public int Cod_Factura { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public Nullable<decimal> Total_Facturado { get; set; }
        public Nullable<decimal> Total_Seguro { get; set; }
        public Nullable<decimal> Tota_Importe { get; set; }
        public Nullable<decimal> Total_Balance { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}
