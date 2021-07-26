using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {





        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            using (Models.IntegracionContext db = new Models.IntegracionContext())
            {
                var lst = (from d in db.Tokens
                           select d).ToList();
                return Ok(lst);
            }
            //return new string

        }
        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.TokenControlador model)
        {
            using (Models.IntegracionContext db = new Models.IntegracionContext())
            {
                var oToken = new Models.Token();

                oToken.TokenId = model.Token_id;
                oToken.Valido = model.Valido;
                oToken.IdPortador = model.Id_portador;
                db.Tokens.Add(oToken);
                db.SaveChanges();
            }
            return Ok("Se ha obtenido el token con exito");
        }
        [HttpPut]
        public ActionResult Post([FromBody] Models.Request.TokenEditControlador model)
        {
            using (Models.IntegracionContext db = new Models.IntegracionContext())
            {
                Models.Token oToken = db.Tokens.Find(model.Id_token);
                oToken.IdToken = model.Id_token;
                oToken.TokenId = model.Token_id;
                oToken.Valido = model.Valido;
                oToken.IdPortador = model.Id_portador;
                db.Entry(oToken).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok("Se ha obtenido el token con exito");
        }
        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.TokenControlador model)
        {
            using (Models.IntegracionContext db = new Models.IntegracionContext())
            {
                Models.Token oToken = db.Tokens.Find(model.Id_token);
                db.Tokens.Remove(oToken);
                db.SaveChanges();
            }
            return Ok("Se eliminado con exito");
        }
    }
}
