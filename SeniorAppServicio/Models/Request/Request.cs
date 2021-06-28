using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeniorAppServicio.Models.Request
{
    public class Request
    {
        public string Token_id { get; set; }
        public Boolean Valido { get; set; }
        public int Id_portador { get; set; }
    }
}