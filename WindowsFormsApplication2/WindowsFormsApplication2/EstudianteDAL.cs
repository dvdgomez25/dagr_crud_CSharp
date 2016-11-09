using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    class EstudianteDAL //La capa DAL (Data Access Layer – Capa de Acceso a Datos)
    {
        public static string ultimoCodigo;

        public static int Agregar(Estudiante pEstudiante)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into jugador (id, codigo, nombre, apellido1, apellido2, demarcacion) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                 pEstudiante.Id, pEstudiante.Codigo, pEstudiante.Nombre, pEstudiante.Apellido1, pEstudiante.Apellido2, pEstudiante.Posicion), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Equipo> Buscar()
        {
            List<Equipo> lista = new List<Equipo>();
            MySqlConnection conectar = conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format(
           
           "SELECT equipo.deporte AS deporte, equipo.nombre AS equipo, jugador.id, jugador.nombre, jugador.apellido1, jugador.apellido2, jugador.codigo, jugador.demarcacion FROM jugador INNER JOIN equipo ON jugador.id=equipo.id"), conectar);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Equipo pEquipo = new Equipo();

                pEquipo.deporte = reader.GetString(0);
                pEquipo.nombreEq = reader.GetString(1);
                pEquipo.Id = reader.GetInt32(2);
                pEquipo.Nombre = reader.GetString(3);
                pEquipo.Apellido1 = reader.GetString(4);
                pEquipo.Apellido2 = reader.GetString(5);
                pEquipo.Codigo = reader.GetString(6);
                pEquipo.Posicion = reader.GetString(7);
                
                lista.Add(pEquipo);
            }
            conectar.Close();
            return lista;
        }

        public static Estudiante ObtenerEstudiante(string pId)
        {
            Estudiante pEstudiante = new Estudiante();
            MySqlConnection conectar = conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(String.Format(
                "SELECT id, codigo, nombre, apellido1, apellido2, demarcacion FROM jugador where codigo='{0}'", pId), conectar);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                pEstudiante.Id = reader.GetInt32(0);
                pEstudiante.Codigo = reader.GetString(1);
                pEstudiante.Nombre = reader.GetString(2);
                pEstudiante.Apellido1 = reader.GetString(3);
                pEstudiante.Apellido2 = reader.GetString(4);
                pEstudiante.Posicion = reader.GetString(5);

                ultimoCodigo = pEstudiante.Codigo;

            }

            conectar.Close();
            return pEstudiante;

        }

        public static int Actualizar(Estudiante pEstudiante)
        {
            int retorno = 0;
            MySqlConnection conectar = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Update jugador set id={0}, codigo='{1}', nombre='{2}', apellido1='{3}', apellido2='{4}', demarcacion='{5}' where codigo='{6}'",
                pEstudiante.Id, pEstudiante.Codigo, pEstudiante.Nombre, pEstudiante.Apellido1, pEstudiante.Apellido2, pEstudiante.Posicion, ultimoCodigo), conectar);

            retorno = comando.ExecuteNonQuery();
            conectar.Close();

            return retorno;
        }

        public static int Eliminar(string cod)
        {
            int retorno = 0;
            MySqlConnection conectar = conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From jugador where codigo='{0}'", cod), conectar);

            retorno = comando.ExecuteNonQuery();
            conectar.Close();

            return retorno;

        }
        
    }
}
