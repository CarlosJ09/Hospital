using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad_CORE_USER.Models
{
    public partial class Cuentas
    {
        public int ID_Cuenta { get; set; }
        public int NumeroSeguroSocial { get; set; }
        public string Nombre_Paciente_Cuenta { get; set; }
        public int Telefono_Paciente_Cuenta { get; set; }
        public string MedicoAsignado { get; set; }
        public string CondicionMedica { get; set; }
        public string PlanTratamiento { get; set; }
    }
}
