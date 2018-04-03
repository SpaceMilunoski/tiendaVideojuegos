using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaVideojuegos
{
    class Usuario
    {
        int id;
        String nombre;
        String rol;
        public Usuario()
        {

        }
        public Usuario(int id,String nombre, String rol)
        {
            this.id = id;
            this.nombre = nombre;
            this.rol = rol;
        }
        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getRol()
        {
            return this.rol;
        }
        public void setId(String rol)
        {
            this.rol = rol;
        }
    }
   

}
