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
    
    public partial class Favoritos
    {
        public int Id { get; set; }
        public Nullable<int> FK_Local { get; set; }
        public Nullable<int> FK_Usuario { get; set; }
    
        public virtual Local Local { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
