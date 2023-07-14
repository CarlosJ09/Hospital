using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Caja.Models
{
    public partial class SERVICIOS
    {
        public int Id_Servicio { get; set; }
        public string Nombre_Servicio { get; set; }
        public Nullable<decimal> Precio { get; set; }
    }
}
