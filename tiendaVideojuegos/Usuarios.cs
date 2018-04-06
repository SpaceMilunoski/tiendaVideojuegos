using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiendaVideojuegos
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            dgvUsuario.DataSource = Conexion.llenado("Select empleados.* , rol.Rol from empleados inner join rol on rol.IDempleado = empleados.IDempleado;");
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProduct inicio = new AdminProduct();
            inicio.Show();
            this.Close();
        }

        private void btnAgregarCompradas_Click(object sender, EventArgs e)
        {
            Conexion.comandos("call agregarusuario("+tbId.Text+", '"+tbNombre.Text+"', '"+tbApellidos.Text+"', "+tbEdad.Text+", '"+tbUsuario.Text+"', '"+tbPass.Text+"', '"+cbRol.Text+"');");
            dgvUsuario.DataSource = Conexion.llenado("Select empleados.* , rol.Rol from empleados inner join rol on rol.IDempleado = empleados.IDempleado;");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = Conexion.llenado("Select empleados.* , rol.Rol from empleados inner join rol on rol.IDempleado = empleados.IDempleado;");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.comandos("call tiendavideojuegos.eliminarEmpleado("+dgvUsuario.CurrentRow.Cells[0].Value.ToString()+");");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String[] datos = new String[10];
            for (int i = 0; i <= dgvUsuario.ColumnCount - 1; i++)
            {
                datos[i] = dgvUsuario.CurrentRow.Cells[i].Value.ToString();
            }
            Conexion.comandos("call tiendavideojuegos.actualizarEmpleado("+datos[0]+ ", '" + datos[1] + "', '" + datos[2] + "'," + datos[3] + ", '" + datos[4] + "', '" + datos[5] + "', '" + datos[6] + "');");
            dgvUsuario.DataSource = Conexion.llenado("Select empleados.* , rol.Rol from empleados inner join rol on rol.IDempleado = empleados.IDempleado;");
        }
    }
}
