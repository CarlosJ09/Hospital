using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad_CORE_USER.Models
{
    public partial class Ingreso
    {
        public int ID_ingreso { get; set; }
        public DateTime Fecha_Hora_Ingreso { get; set; }
        public string Motivo_Ingreso { get; set; }
    }
}
