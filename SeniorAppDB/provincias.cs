//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeniorAppDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class provincias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public provincias()
        {
            this.comunas = new HashSet<comunas>();
        }
    
        public int provincia_id { get; set; }
        public string provincia_nombre { get; set; }
        public int region_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comunas> comunas { get; set; }
        public virtual regiones regiones { get; set; }
    }
}
