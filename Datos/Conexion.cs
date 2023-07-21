using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "Crud_C#";
            this.Servidor = "MASTERG";
            this.Usuario = "masterG";
            this.Clave = "12345";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = $"Server={this.Servidor}; Database={this.Base}; User Id={this.Usuario}; Password={this.Clave}";
            }
            catch (Exception Ex)
            {
                Cadena = null;
                throw Ex;
            }

            return Cadena;
        }

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();//se armara una nueva conexion
            }

            return Con;
        }
    }
}
