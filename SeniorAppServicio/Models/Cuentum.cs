using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class Cuentum
    {
        public int IdApoderado { get; set; }
        public string Usuario { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Passwd { get; set; }
        public string TipoCuenta { get; set; }

        public virtual Apoderado Apoderado { get; set; }
    }
}
