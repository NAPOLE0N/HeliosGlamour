﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AtlasEntities3 : DbContext
    {
        public AtlasEntities3()
            : base("name=AtlasEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Estatus> Estatus { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Favoritos> Favoritos { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Instruccion> Instruccion { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<Local_Empleado> Local_Empleado { get; set; }
        public virtual DbSet<Promocion_Local> Promocion_Local { get; set; }
        public virtual DbSet<Promocion_Usuario> Promocion_Usuario { get; set; }
        public virtual DbSet<Promociones> Promociones { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Servicio_Local> Servicio_Local { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Suscripcion> Suscripcion { get; set; }
        public virtual DbSet<Suscripcion_Local> Suscripcion_Local { get; set; }
        public virtual DbSet<Suscripcion_Usuario> Suscripcion_Usuario { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tarjeta> Tarjeta { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
