using System;
using System.Collections.Generic;

using System.Data;
using CapaConexion;
using CapaDTO;

namespace CapaNegocio
{



    public class NegocioCliente
    {
        private Conexion conec1;

        public Conexion Conec1
        {
            get { return conec1; }
            set { conec1 = value; }
        }

        public void configurarConexion()
        {
            this.Conec1 = new Conexion();
            this.Conec1.NombreBaseDeDatos = "Integracion";
            this.Conec1.NombreTabla = "cuenta";
           // this.Conec1.CadenaConexion = "Data Source=tamponi-pc;Initial Catalog=prueba;Integrated Security=True";
            this.Conec1.CadenaConexion = "Data Source=35.199.113.172;Initial Catalog=Integracion;User ID=SA;password=4dminD1234";

        }

        public DataSet retornaClienteDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM cuenta";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresacuenta(Cliente cuenta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO cuenta (rut,nombre) "+
                                     " VALUES ('" + cuenta.Rut + "','" +
                                      cuenta.Nombre + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();
           
        }

        public void actualizarCliente(Cliente cuenta)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE cuenta set nombre = '" +
                                     cuenta.Nombre + "' WHERE rut = '"+
                                     cuenta.Rut +"';" ;
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarCliente(String rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM cuenta "+
                                    " WHERE rut = '"+rut+"';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Cliente> retornaCliente()
        {
            List<Cliente> auxListadoCliente = new List<Cliente>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM cuenta";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Cliente auxCliente = new Cliente();
                auxCliente.Rut = (String) dr["rut"];
                auxCliente.Nombre = (String)dr["nombre"];
                auxListadoCliente.Add(auxCliente);
            } //Fin for


            return auxListadoCliente;
        }

        public Cliente buscaCliente(String rut)
        {
            Cliente auxCliente = new Cliente();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM cuenta "+
                                    " WHERE rut = '" + rut+"';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxCliente.Rut = (String) dt.Rows[0]["rut"];
                auxCliente.Nombre = (String)dt.Rows[0]["nombre"];
            }
            catch (Exception ex)
            {
                auxCliente.Rut = String.Empty;
                auxCliente.Nombre = String.Empty;
            }

            return auxCliente;
        }

        public Cliente retornaPosicionCliente(int posicion)
        {
            Cliente auxCliente = new Cliente();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM cuenta ";
                                    
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxCliente.Rut = (String)dt.Rows[posicion]["rut"];
                auxCliente.Nombre = (String)dt.Rows[posicion]["nombre"];
            }
            catch (Exception ex)
            {
                auxCliente.Rut = String.Empty;
                auxCliente.Nombre = String.Empty;
            }

            return auxCliente;
        }







    }//Fin clase

} //Fin namespace
