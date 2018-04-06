using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tiendaVideojuegos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Conexion.Login(tbUsuario.Text, tbPassword.Text))
            {
                if (Usuario.getRol() == "vendedor")
                {
                    Venta venta = new Venta();
                    venta.Show();
                    this.Close();
                }
                if (Usuario.getRol() == "administrador")
                {
                    AdminProduct admin = new AdminProduct();
                    admin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario sin privilegios para operar este programa","Error");
                    tbUsuario.Text = "";
                    tbPassword.Text = "";
                    Usuario.setId(0);
                    Usuario.setNombre("");
                    Usuario.setRol("");
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                tbUsuario.Text = "";
                tbPassword.Text = "";
                Usuario.setId(0);
                Usuario.setNombre("");
                Usuario.setRol("");
            }
        }
    }
}
