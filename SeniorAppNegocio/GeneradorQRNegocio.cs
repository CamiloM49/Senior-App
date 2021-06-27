using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using SeniorAppDTO;

namespace SeniorAppNegocio
{
    public class GeneradorQRNegocio
    {
        public void generaciontoken(string tokenid, Boolean validoqr, int idportador){
            string url = "http://localhost:34003/api/Persona";

            TokenDTO oToken = new TokenDTO();
            oToken.Token_id = tokenid;
            oToken.Valido = validoqr;
            oToken.Id_portador = idportador;
            


            string resultado = Send<TokenDTO>(url, oToken, "POST");
        }
        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";

            try
            {

                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                result = e.Message;

            }

            return result;
        }
    }
}
