using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lineaBlanca.vistas;

namespace lineaBlanca
{
    public partial class Login : Form
    {
        linea_blancaEntities contexto = new linea_blancaEntities();
        Main main = new Main();
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;


            try
            {
                //consulta para sacar el nivel en base al usuario y contraseña
                int role = (from c in contexto.usuario
                               where c.username == user
                               && c.pass_word == password
                               select c.rol).FirstOrDefault();

                int userId = (from c in contexto.usuario
                               where c.username == user
                               && c.pass_word == password
                               select c.id_usuario).FirstOrDefault();

                switch (role)
                {
                    case 1:
                        //the user role is admin
                        GlovalEntries.idUSer = userId;
                        GlovalEntries.role = role;
                        this.Hide();
                        main.Show();
                        break;
                    case 2:
                        //the user role is almacen
                        break;
                    case 3:
                        //the user role is vendedor
                        GlovalEntries.idUSer = userId;
                        GlovalEntries.role = role;
                        this.Hide();
                        main.Show();
                        break;
                    default:
                        MessageBox.Show(this, "Error de usuario o contraseña",
                        "Error de autenticación", MessageBoxButtons.OK);
                        txtPassword.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error" + ex.Message);
            }
        }
    }
}
