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
    
    public partial class token
    {
        public int id_token { get; set; }
        public string token_id { get; set; }
        public bool valido { get; set; }
        public int id_portador { get; set; }
    
        public virtual portador portador { get; set; }
    }
}
