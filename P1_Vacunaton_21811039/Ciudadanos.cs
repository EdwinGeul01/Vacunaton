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
    
    public partial class Ciudadanos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ciudadanos()
        {
            this.VacunaXCiudadanos = new HashSet<VacunaXCiudadanos>();
            this.EnfermedadesBases = new HashSet<EnfermedadesBases>();
        }
    
        public string IdCiudadano { get; set; }
        public string nombreCompleto { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public Nullable<int> edad { get; set; }
        public string genero { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string estadoCivil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VacunaXCiudadanos> VacunaXCiudadanos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnfermedadesBases> EnfermedadesBases { get; set; }
    }
}
