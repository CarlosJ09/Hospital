//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hospital.Caja
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURA
    {
        public int Id_Factura { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Servicio { get; set; }
        public int Cod_Factura { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> Des_Seguro { get; set; }
        public Nullable<decimal> Pagado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Id_Empleado { get; set; }
        public Nullable<decimal> Importe { get; set; }
    }
}