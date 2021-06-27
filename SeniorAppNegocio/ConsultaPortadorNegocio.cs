using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeniorAppNegocio
{
    public class ConsultaPortadorNegocio

    {
        public SeniorAppDB.SeniorAppDB db = new SeniorAppDB.SeniorAppDB();
        public void detalleportador(string id_token) {
            LoginNegocio logincon = new LoginNegocio();
            
            var informacionportado = db.token.Join(db.portador, tok => tok.id_portador,por=> por.id_portador, (tok,por) => new {tok,por});
        }

    }
}
