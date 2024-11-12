using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Controlador
{
    public class Conexion
    {
        public static string cadena;

        static Conexion()
        {
            try
            {
                Console.WriteLine("Intentando obtener la cadena de conexión...");
                cadena = ConfigurationManager.ConnectionStrings["Controlador.Properties.Settings.DBSistemaSiempreBellaConnectionString"].ConnectionString;

                if (string.IsNullOrEmpty(cadena))
                {
                    throw new NullReferenceException("La cadena de conexión no ha sido inicializada correctamente.");
                }

                Console.WriteLine("Cadena de conexión obtenida correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al inicializar la conexión: " + ex.Message);
                throw new Exception("Error al inicializar la conexión: " + ex.Message, ex);
            }
        }

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
