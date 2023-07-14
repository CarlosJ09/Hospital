using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Caja.Models
{
    public partial class CLIENTE
    {
        public int Id_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Cedula_Cliente { get; set; }
        public Nullable<int> Id_Seguro { get; set; }
        public string Poliza { get; set; }
        public string Telefono { get; set; }
    }
}
