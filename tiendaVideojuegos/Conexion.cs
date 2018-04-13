using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace tiendaVideojuegos
{
    class Conexion{
        static MySqlCommand consulta;
        static DataTable dt;
        static MySqlDataAdapter da;
       public static MySqlConnection conexion;
       public static void conectar(){
            MySqlConnectionStringBuilder datos = new MySqlConnectionStringBuilder();
            datos.Server = "localhost";
            datos.UserID = "root";
            datos.Password = "1234";
            datos.Database = "tiendavideojuegos";
            conexion = new MySqlConnection(datos.ToString());
            try {
                conexion.Open();
               
            } catch(MySqlException e) {

            }
        }
        static void desconectar() {
            conexion.Close();
        }
       public static DataTable llenado(String datos) {
            conectar();
            consulta = new MySqlCommand(datos,conexion);
            da = new MySqlDataAdapter(consulta);
            dt = new DataTable();
            da.Fill(dt);
            desconectar();
            return dt;
        }
        public static void comandos(String query) {
            conectar();
            consulta = new MySqlCommand(query,conexion);
            consulta.ExecuteReader();
            desconectar();
        }
        public static bool Login(String usuario , String pasword)
        {
            bool acceso = false;
            String query;
            query = "select * from empleados where Usuario = '"+usuario+"';";
            conectar();
            consulta = new MySqlCommand(query, conexion);
            MySqlDataReader reader = consulta.ExecuteReader();
            //desconectar();
            if (reader.Read())
            {
                if (reader.GetString(4) == usuario && reader.GetString(5) == pasword)
                {
                    acceso = true;
                    Usuario.setId(reader.GetInt32(0));
                    Usuario.setNombre(reader.GetString(1));
                    reader.Close();
                    query = "select Rol from rol where IDempleado = " + Usuario.getId() + ";";
                    conectar();
                    consulta = new MySqlCommand(query, conexion);
                    reader = consulta.ExecuteReader();
                    //desconectar();
                    if (reader.Read())
                    {
                        Usuario.setRol(reader.GetString(0));
                        reader.Close();
                    }
                }
            }
            return acceso;
        }

        public static bool existe(String usuario)
        {
            bool existente = false;
            String query;
            query = "select * from empleados where Usuario = '" + usuario + "';";
            conectar();
            consulta = new MySqlCommand(query, conexion);
            MySqlDataReader reader = consulta.ExecuteReader();
            //desconectar();
            if (reader.Read())
            {
                existente = true;
            }
            return existente;
        }


    }
}
