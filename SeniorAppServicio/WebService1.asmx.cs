using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;



namespace SeniorAppServicio
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        static SqlConnection conn = new SqlConnection("Data Source=35.199.113.172;Initial Catalog=Integracion;User ID=SA;password=4dminD1234");
        [WebMethod]
        public DataTable LoadData(string query, string[] parameter, object[] values, string table) {
            conn.Open();
            var cmd = new SqlCommand(query, conn);
            if (parameter != null)
                for (var i = 0; i < parameter.Length; i++)
                    cmd.Parameters.AddWithValue(parameter[i], values[i]);
            var dr = cmd.ExecuteReader();
            
            var dt = new DataTable(table);
            dt.Load(dr);
            dr.Dispose();
            conn.Close();
            return dt;
        }
        [WebMethod]
        static public void Insertar(string query)
        {
            var cmd = new SqlCommand();
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        /*[WebMethod]
        public DataTable MostrarProd()
        {
            DataTable table = new DataTable();
            table = objetoCD.Mostrar();
            return tabla; 
        }

        public void Editar ( string query, string [] parameter, object[] values)
        {
            conn.Connection = conn.abrirConexion();
            conn.commandtext = "InsetarUsuarios";
            coon.CommandType = CommandType.StoredProcedure;
            conn.parameters.additiveValue("@id_apoderado", id_apoderado);
            conn.parameters.additiveValue("@usuario", usuario);
            conn.parameters.additiveValue("@mail", mail);
            conn.parameters.additiveValue("@passwd", passwd);
            conn.executeNonQuery(); 
        }
        */


    }
}
