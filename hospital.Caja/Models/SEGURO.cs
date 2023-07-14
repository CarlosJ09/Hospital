using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Caja.Models
{
    public partial class SEGURO
    {
        public int Id_Seguro { get; set; }
        public string Nombre_Seguro { get; set; }
        public Nullable<decimal> Des_Porcentaje { get; set; }
    }
}
