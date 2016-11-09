using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public class conexion
    {
        MySqlConnection conectar = new MySqlConnection();
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=deportes; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }

        public MySqlConnection CerrarConexion()
        {
            conectar.Close();
            return conectar;
        }
    }
}
