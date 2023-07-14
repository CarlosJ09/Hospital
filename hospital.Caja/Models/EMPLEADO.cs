using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Caja.Models
{
    public partial class EMPLEADO
    {
        public int Id_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Cedula_Empleado { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
