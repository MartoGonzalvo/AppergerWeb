﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiApperger.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class appergerEntities1 : DbContext
    {
        public appergerEntities1()
            : base("name=appergerEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Emocion> Emocions { get; set; }
        public virtual DbSet<Imagen> Imagens { get; set; }
        public virtual DbSet<ImagenTratamiento> ImagenTratamientoes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Selfie> Selfies { get; set; }
        public virtual DbSet<Tratamiento> Tratamientoes { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<VideoTratamiento> VideoTratamientoes { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}