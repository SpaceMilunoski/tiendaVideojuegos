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

        private void btnAceptar_Click(object sender, EventArgs e) {
            Conexion.comandos("call tiendavideojuegos.quitarPiezas("+lbId.Text+","+tbPiezasComprar.Text+");");
            dgvVenta.DataSource = Conexion.llenado("SELECT * FROM `inventario` WHERE `titulo` LIKE '%" + tbBuscar.Text + "%';");
        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e) {
            lbId.Text= dgvVenta.CurrentRow.Cells[0].Value.ToString();
            lbTitulo.Text = dgvVenta.CurrentRow.Cells[1].Value.ToString();
            lbPrecioU.Text=dgvVenta.CurrentRow.Cells[3].Value.ToString();
            lbPiezas.Text= dgvVenta.CurrentRow.Cells[7].Value.ToString();

        }

        private void tbPiezasComprar_TextChanged(object sender, EventArgs e) {
            try {
                int piezas;
                Double precio, precioIva;
                piezas = Convert.ToInt32(tbPiezasComprar.Text);
                precio = Convert.ToDouble(lbPrecioU.Text);
                precioIva = (piezas * precio) * 1.16;
                lbPrecioIva.Text = precioIva.ToString();
            } catch(Exception ) {
                lbPrecioIva.Text = "";
            }
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
