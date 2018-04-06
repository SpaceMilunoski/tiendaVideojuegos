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
            dgvVenta.DataSource = Conexion.llenado("SELECT * FROM `inventario`;");
            
        }

        private void buquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            busqueda.Show();
            this.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Usuario.getRol()=="administrador")
            {
                AdminProduct inicio = new AdminProduct();
                inicio.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Permisos insuficientes", "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            dgvVenta.DataSource = Conexion.llenado("SELECT * FROM `inventario` WHERE `titulo` LIKE '%" + tbBuscar.Text + "%';");
            tbBuscar.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (lbId.Text!="")
            {
                if (Convert.ToInt32(lbPiezas.Text) >= Convert.ToInt32(tbPiezasComprar.Text))
                {
                    Conexion.comandos("call insertarVenta(" + lbId.Text + ", " + Usuario.getId() + ", " + tbPiezasComprar.Text + ");");
                    dgvVenta.DataSource = Conexion.llenado("SELECT * FROM `inventario` WHERE `titulo` LIKE '%" + tbBuscar.Text + "%';");
                    tbPiezasComprar.Text = "";
                    lbId.Text = "";
                    lbPiezas.Text = "";
                    lbPrecioIva.Text = "";
                    lbPrecioU.Text = "";
                    lbTitulo.Text = "";

                }
                else
                {
                    MessageBox.Show("Piezas insuficientes", "Error");
                    tbPiezasComprar.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Selecione primero un videojuego", "Error");
            }
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

        private void tbPiezasComprar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbPiezasComprar.Text = "";
            lbId.Text = "";
            lbPiezas.Text = "";
            lbPrecioIva.Text = "";
            lbPrecioU.Text = "";
            lbTitulo.Text = "";
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.cerrarSesion();
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
