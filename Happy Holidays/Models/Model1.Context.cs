﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Happy_Holidays.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hotelesEntities : DbContext
    {
        public hotelesEntities()
            : base("name=hotelesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<act_hotel> act_hotel { get; set; }
        public virtual DbSet<actividades> actividades { get; set; }
        public virtual DbSet<cadenas> cadenas { get; set; }
        public virtual DbSet<ciudades> ciudades { get; set; }
        public virtual DbSet<hoteles> hoteles { get; set; }
    }
}