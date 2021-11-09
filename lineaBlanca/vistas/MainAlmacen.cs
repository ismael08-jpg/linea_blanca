using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lineaBlanca.vistas
{
    public partial class MainAlmacen : Form
    {
        FrmCredito frmCre = new FrmCredito();
        FrmInicio frmInicio = new FrmInicio();
        FrmPagos frmPagos = new FrmPagos();
        FrmReportes frmRepos = new FrmReportes();
        FrmClientes frmClientes = new FrmClientes();
        FrmUsuarios frmUsuarios = new FrmUsuarios();
        FrmCategorias frmCategorias = new FrmCategorias();
        FrmTipos frmTipos = new FrmTipos();
        FrmProductos frmProductos = new FrmProductos();
        
        public MainAlmacen()
        {
            InitializeComponent();

            frmInicio.MdiParent = this;
            frmInicio.Show();
            frmInicio.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (btnInicio.Checked)
            {
                frmInicio.Focus();

            }
        }

        
      
        private void btnLogout_Click(object sender, EventArgs e)
        {  
            if (MessageBox.Show(this, "¿Estas seguro que desea salir", "¿Cerrar sesión?",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                GlovalEntries.idUSer = 0;
                GlovalEntries.nombre = "";
                GlovalEntries.role = 0;
                Login login = new Login();
                this.Close();
                login.Show();
            }
        }

        private void btnTipos_Click(object sender, EventArgs e)
        {
            if (btnTipos.Checked)
            {
                frmTipos.MdiParent = this;
                frmTipos.Show();
                frmTipos.Focus();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            if (btnCategorias.Checked)
            {
                frmCategorias.MdiParent = this;
                frmCategorias.Show();
                frmCategorias.Focus();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (btnProductos.Checked)
            {
                frmProductos.MdiParent = this;
                frmProductos.Show();
                frmProductos.Focus();
            }
        }
    }
}
