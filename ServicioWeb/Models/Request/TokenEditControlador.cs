using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioWeb.Models.Request
{
    public class TokenControlador
    {
        public int Id_token { get; set; }
        public string Token_id { get; set; }
        public Boolean Valido { get; set; }
        public int Id_portador { get; set; }
    }
}
