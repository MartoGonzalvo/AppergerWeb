//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiApperger.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tratamiento
    {
        public Tratamiento()
        {
            this.Categoria = new HashSet<Categoria>();
            this.Imagen = new HashSet<Imagen>();
            this.Selfie = new HashSet<Selfie>();
            this.Video = new HashSet<Video>();
        }
    
        public int nIdTratamiento { get; set; }
        public Nullable<System.DateTime> dFechaInicio { get; set; }
        public Nullable<System.DateTime> dFechaFin { get; set; }
        public Nullable<bool> bSelfie { get; set; }
        public Nullable<bool> bImagen { get; set; }
        public Nullable<bool> bVideo { get; set; }
        public Nullable<int> nIdPsicologo { get; set; }
        public Nullable<int> nIdPaciente { get; set; }
    
        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<Imagen> Imagen { get; set; }
        public virtual ICollection<Selfie> Selfie { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
        public virtual ICollection<Video> Video { get; set; }
    }
}