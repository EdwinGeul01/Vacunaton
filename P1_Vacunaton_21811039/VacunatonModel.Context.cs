﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P1_Vacunaton_21811039
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VacunatonEntities : DbContext
    {
        public VacunatonEntities()
            : base("name=VacunatonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CentroAsistencia> CentroAsistencia { get; set; }
        public virtual DbSet<Ciudadanos> Ciudadanos { get; set; }
        public virtual DbSet<EnfermedadesBases> EnfermedadesBases { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vacunas> Vacunas { get; set; }
        public virtual DbSet<VacunaXCiudadanos> VacunaXCiudadanos { get; set; }
    }
}