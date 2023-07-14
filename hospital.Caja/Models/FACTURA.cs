using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Caja.Models
{
    public partial class FACTURA
    {
        public int Id_Factura { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Servicio { get; set; }
        public int Cod_Factura { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> Des_Seguro { get; set; }
        public Nullable<decimal> Pagado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public bool Estado { get; set; }
    }
}
