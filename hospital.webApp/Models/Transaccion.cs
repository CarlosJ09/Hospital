//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hospital.webApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaccion
    {
        public int IdFactura { get; set; }
        public string NombreCompletoCliente { get; set; }
        public string NombreServicio { get; set; }
        public int CodigoFactura { get; set; }
        public decimal Monto { get; set; }
        public decimal DescuentoSeguro { get; set; }
        public decimal TotalFacturado { get; set; }
        public decimal TotalSeguro { get; set; }
        public decimal TotalBalance { get; set; }
        public System.DateTime Fecha { get; set; }
        public string NombreCompletoEmpleado { get; set; }
        public decimal Importe { get; set; }
        public Nullable<bool> TransaccionConfirmada { get; set; }
    }
}
