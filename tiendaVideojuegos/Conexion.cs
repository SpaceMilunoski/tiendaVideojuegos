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
       static MySqlConnection conexion;
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
        
    }
}
