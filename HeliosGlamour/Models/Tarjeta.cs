//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeliosGlamour.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarjeta
    {
        public int Id { get; set; }
        public string Tarjeta1 { get; set; }
        public Nullable<int> CVV { get; set; }
        public string MES { get; set; }
        public string Year { get; set; }
        public Nullable<int> FK_Cliente { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
