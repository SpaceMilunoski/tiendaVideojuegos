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
            dgvUsuario.DataSource = Conexion.llenado("Select * from empleados;");
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
            dgvUsuario.DataSource = Conexion.llenado("Select * from empleados;");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = Conexion.llenado("Select * from empleados;");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.comandos("call tiendavideojuegos.eliminarEmpleado("+dgvUsuario.CurrentRow.Cells[0].Value.ToString()+");");
        }
    }
}
