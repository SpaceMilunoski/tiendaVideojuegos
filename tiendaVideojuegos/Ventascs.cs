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
    public partial class Ventascs : Form
    {
        public Ventascs()
        {
            InitializeComponent();
            dgvVentas.DataSource = Conexion.llenado("SELECT * FROM registroventas;");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = Conexion.llenado("SELECT * FROM `registroventas` WHERE `IDventa` = '" + tbIDventa.Text + "';");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = Conexion.llenado("SELECT * FROM registroventas;");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.comandos("call eliminarVenta(" + dgvVentas.CurrentRow.Cells[0].Value.ToString() + ");");
                dgvVentas.DataSource = Conexion.llenado("SELECT * FROM registroventas;");
            }
            catch(Exception er)
            {
                MessageBox.Show("No ha selecionado ningun elemento ", "Error");
            }

        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProduct administrar = new AdminProduct();
            administrar.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
