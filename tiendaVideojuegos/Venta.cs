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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
            dgvVenta.DataSource = Conexion.llenado("SELECT * FROM `inventario` WHERE `titulo` LIKE '%" + tbBuscar.Text + "%';");
        }

        private void buquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            busqueda.Show();
            this.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            dgvVenta.DataSource = Conexion.llenado("SELECT * FROM `inventario` WHERE `titulo` LIKE '%" + tbBuscar.Text + "%';");
        }
    }
}
