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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProduct inicio = new AdminProduct();
            inicio.Show();
            this.Close();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            dgvBusqueda.DataSource = Conexion.llenado("SELECT * FROM `inventario` WHERE `titulo` LIKE '%" + tbProducto.Text + "%';");
        }
    }
}
