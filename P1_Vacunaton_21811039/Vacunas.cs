//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Vacunas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vacunas()
        {
            this.Usuario = new HashSet<Usuario>();
            this.VacunaXCiudadanos = new HashSet<VacunaXCiudadanos>();
        }
    
        public string CodVacuna { get; set; }
        public string nombre { get; set; }
        public string fabricante { get; set; }
        public Nullable<System.DateTime> fechaEmision { get; set; }
        public Nullable<System.DateTime> fechaVencimiento { get; set; }
        public string numerolote { get; set; }
        public string estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VacunaXCiudadanos> VacunaXCiudadanos { get; set; }
    }
}
