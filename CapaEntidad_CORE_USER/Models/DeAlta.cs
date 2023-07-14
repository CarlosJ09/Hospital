using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad_CORE_USER.Models
{
    public partial class DeAlta
    {
        public int ID_Alta { get; set; }
        public DateTime Fecha_Hora_Alta { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
    }
}
