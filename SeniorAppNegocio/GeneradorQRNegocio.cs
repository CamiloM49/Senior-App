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
        static public string ResultadoQR;
        public void generaciontoken(){
            GeneradorQRNegocio genqr = new GeneradorQRNegocio();
            string url = "https://localhost:44393/api/Token";
            TokenDTO objt = new TokenDTO();
            GeneradorQRNegocio genqr2 = new GeneradorQRNegocio();
            TokenAleatorioNegocio tokeng = new TokenAleatorioNegocio();
            tokeng.tokenfinal();
            objt.Token_id = tokeng.tokenf;
            objt.Id_portador = LoginNegocio.Idporta;
            objt.Valido = true;
            string resultado = genqr2.Send<TokenDTO>(url, objt, "POST");
            ResultadoQR = tokeng.tokenf;
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
