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
    
    public partial class portador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public portador()
        {
            this.last_location = new HashSet<last_location>();
            this.registro_perdida = new HashSet<registro_perdida>();
        }
    
        public int id_portador { get; set; }
        public string nombre { get; set; }
        public string apdpat { get; set; }
        public string apdmat { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public string rut { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string enfermedades { get; set; }
        public bool prevision { get; set; }
        public string prevision_name { get; set; }
        public string medico_cabecera { get; set; }
        public string alergias { get; set; }
        public string medicamentos_prescritos { get; set; }
        public string contacto_emergencia { get; set; }
        public int id_apoderado { get; set; }
    
        public virtual apoderado apoderado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<last_location> last_location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<registro_perdida> registro_perdida { get; set; }
    }
}
