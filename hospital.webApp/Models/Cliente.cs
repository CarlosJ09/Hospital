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
    
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public int Cedula { get; set; }
        public int Telefono { get; set; }
        public Nullable<int> Poliza { get; set; }
        public string Email { get; set; }
    }
}
