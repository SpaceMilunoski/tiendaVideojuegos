using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaVideojuegos
{
    class Usuario
    {
        static int id;
        static String nombre;
        static String rol;
        public Usuario()
        {

        }
        public Usuario(int idI,String nombreI, String rolI)
        {
            id = idI;
            nombre = nombreI;
            rol = rolI;
        }
        public static int getId()
        {
            return id;
        }
        public static void setId(int idI)
        {
            id = idI;
        }
        public static String getNombre()
        {
            return nombre;
        }
        public static void setNombre(String nombreI)
        {
            nombre = nombreI;
        }
        public static String getRol()
        {
            return rol;
        }
        public static void setRol(String rolI)
        {
            rol = rolI;
        }
    }
   

}
