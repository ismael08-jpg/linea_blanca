﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lineaBlanca
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class linea_blancaEntities : DbContext
    {
        public linea_blancaEntities()
            : base("name=linea_blancaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<credito> credito { get; set; }
        public virtual DbSet<cuota> cuota { get; set; }
        public virtual DbSet<pago> pago { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<tipo> tipo { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
