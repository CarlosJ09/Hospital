using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.Caja.Models
{
    public partial class MontoInicial
    {
        public int Id { get; set; }
        public decimal Monto_Inicial { get; set; }
        public string Fecha { get; set; }
    }
}
