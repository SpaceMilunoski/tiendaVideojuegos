using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void dgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e) {
            lbTitulo.Text = dgvBusqueda.CurrentRow.Cells[1].Value.ToString();
            lbDescripcion.Text = dgvBusqueda.CurrentRow.Cells[3].Value.ToString();
            try
            {
               
                MemoryStream ms = new MemoryStream((byte[])dgvBusqueda.CurrentRow.Cells[9].Value);
                pbPimagen.Image = Image.FromStream(ms); 
               
            }
            catch (Exception ex)
            {
                
            }
            //DataGridViewImageCell cell = dgvBusqueda.CurrentRow.Cells[9].Value as DataGridViewImageCell;
            //pbPimagen.Image = new Image(cell.Value.);
        }
        public Image byteArrayToImage(byte[] byteArrayIn) {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
