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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
            dgvInicio.DataSource = Conexion.llenado("select * from inventario;");
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            busqueda.Show();
            this.Close();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) {
            dgvInicio.DataSource = Conexion.llenado("select * from inventario;");
        }
    }
}
