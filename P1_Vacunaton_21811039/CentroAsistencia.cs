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
    
    public partial class CentroAsistencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CentroAsistencia()
        {
            this.Usuario = new HashSet<Usuario>();
        }
    
        public string idcentro { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public int numeroPacientes { get; set; }
        public Nullable<int> cantMedicos { get; set; }
        public Nullable<int> cantEnfermeras { get; set; }
        public string estatus { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
