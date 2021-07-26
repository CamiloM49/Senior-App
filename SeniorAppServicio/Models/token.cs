using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class Token
    {
        public int IdToken { get; set; }
        public string TokenId { get; set; }
        public bool Valido { get; set; }
        public int IdPortador { get; set; }

        public virtual Portador IdPortadorNavigation { get; set; }
    }
}
