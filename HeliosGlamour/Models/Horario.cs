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
    
    public partial class Horario
    {
        public int Id { get; set; }
        public Nullable<int> Dia { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public int FK_Local { get; set; }
    
        public virtual Local Local { get; set; }
    }
}