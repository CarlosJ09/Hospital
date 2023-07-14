using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad_CORE_USER.Models
{
    public partial class Autorizacion
    {
        public int ID_Autorizacion { get; set; }
        public DateTime Fecha_Autorizacion { get; set; }
        public string Descripcion_Autorizacion { get; set; }
        public string Estado_Autorizacion { get; set; }
    }
}
