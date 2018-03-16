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
    public partial class AdminProduct : Form
    {
        public AdminProduct()
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

        private void btnAgregar_Click(object sender, EventArgs e) {
            Conexion.comandos("INSERT INTO `tiendavideojuegos`.`inventario` (`id`, `titulo`, `descripcion`, `precio`, `genero`, `plataforma`, `clasificacion`, `numexistentes`, `ubicacion`) VALUES (NULL, '" + tbTitulo.Text + "', '" + tbDescripcion.Text + "', '" + tbPrecio.Text + "', '" + cbGenero.SelectedItem.ToString() + "', '" + cbPlataforma.SelectedItem.ToString()+ "', '" + cbClasificacion.SelectedItem.ToString() + "', '" + tbPiezas.Text + "', '" + cbUbicacion.SelectedItem.ToString() + "')");
            dgvInicio.DataSource = Conexion.llenado("select * from inventario;");
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            Conexion.comandos("DELETE FROM `tiendavideojuegos`.`inventario` WHERE `id`='"+dgvInicio.Rows[dgvInicio.CurrentRow.Index].Cells[dgvInicio.CurrentCell.ColumnIndex].Value.ToString() + "'"+";");
            dgvInicio.DataSource = Conexion.llenado("select * from inventario;");
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            String[] datos = new String[10];
            for (int i = 0; i <= dgvInicio.ColumnCount-1; i++) {
                datos[i] = dgvInicio.CurrentRow.Cells[i].Value.ToString();
            }
            Conexion.comandos("UPDATE `tiendavideojuegos`.`inventario` SET `titulo` = '" + datos[1] + "', `descripcion` = '" + datos[2] + "', `precio` = '" + datos[3] + "', `genero` = '" + datos[4] + "', `plataforma` = '" + datos[5] + "', `clasificacion` = '" + datos[6] + "', `numexistentes` = '" + datos[7] + "', `ubicacion` = '" + datos[8] + "' WHERE `inventario`.`id` = '" + datos[0] + "'");
        }

        private void btnAgregarCompradas_Click(object sender, EventArgs e) {
            Conexion.comandos("call tiendavideojuegos.agregarPiezas(" + dgvInicio.CurrentRow.Cells[0].Value.ToString() + "," + tbPiezascompradas.Text + ");");
            tbPiezascompradas.Text = "";
            dgvInicio.DataSource = Conexion.llenado("select * from inventario;");
        }
    }
}
