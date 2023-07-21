using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;
using Modelo;

namespace Datos
{
    public class D_personas
    {
        public DataTable dtPersona(string ctexto)
        {
            SqlDataReader Rspta;
            DataTable dtPersona = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con = Conexion.GetInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("sp_getPersona", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = ctexto;
                con.Open();
                Rspta = cmd.ExecuteReader();
                dtPersona.Load(Rspta);
                return dtPersona;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        } 
        public string insertXupdatePersona(int Opcion , M_persona persona)
        {
            string rspta = string.Empty;
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.GetInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("sp_insertxUpdatePersona",con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.Add("@Opcion",SqlDbType.Int).Value= Opcion;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = persona.id;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = persona.nombre;
                cmd.Parameters.Add("@ApPaterno", SqlDbType.VarChar).Value = persona.apPaterno;
                cmd.Parameters.Add("@ApMaterno", SqlDbType.VarChar).Value = persona.apMaterno;
                cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = persona.Edad;
                cmd.Parameters.Add("@Fecha_nac", SqlDbType.VarChar).Value = persona.Fecha_nac;
                con.Open();
                rspta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo realizar el proceso del registro";
            }
            catch (Exception ex)
            {

                rspta=ex.Message;
            }
            finally
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return rspta;
        }
    }
}
