using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelo;

namespace Negocio
{
    public class N_personas
    {
        public static DataTable getPersonas(string cTexto)
        {
            D_personas datos = new D_personas();
            return datos.dtPersona(cTexto);
        }

        public static string insertXupdate(int Opcion, M_persona persona)
        {
            D_personas datos = new D_personas();
            return datos.insertXupdatePersona(Opcion, persona);
        }

        public static string DeletePersona(int id)
        {
            D_personas datos = new D_personas();
            return datos.delete_persona(id);
        }
    }
}
