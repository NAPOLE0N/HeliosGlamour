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
    
    public partial class Suscripcion_Usuario
    {
        public int Id { get; set; }
        public Nullable<int> FK_Suscripcion { get; set; }
        public Nullable<int> FK_Usuario { get; set; }
    
        public virtual Suscripcion Suscripcion { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
