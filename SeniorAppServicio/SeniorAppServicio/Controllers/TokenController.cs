using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeniorAppServicio.Controllers
{
    public class TokenController : ApiController
    {
       
        [HttpPost]
        public IHttpActionResult Add(Models.Request.Request model)
        { 
            using (Models.tokenmodel db = new Models.tokenmodel())
                {
         var oToken = new Models.token();
          
                oToken.token_id = model.Token_id;
                oToken.valido = model.Valido;
                oToken.id_portador = model.Id_portador;
                db.token.Add(oToken);
                db.SaveChanges();
}
            return Ok("Se ha obtenido el token con exito");
    }}}


