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
    public partial class FrmAlmacen : Form
    {
        FrmCategorias FrmCategorias = new FrmCategorias();
        frmTipos frmtipos = new frmTipos();
        frmProducto frmProducto = new frmProducto();
        public FrmAlmacen()
        {
            InitializeComponent();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            if (btnPro.Checked)
            {
                frmProducto.MdiParent = this;
                frmProducto.Show();
                frmProducto.Focus();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            if (btnCategorias.Checked)
            {
                FrmCategorias.MdiParent = this;
                FrmCategorias.Show();
                FrmCategorias.Focus();
            }
        }

        private void btnTipos_Click(object sender, EventArgs e)
        {
            if (btnTipos.Checked)
            {
                frmtipos.MdiParent = this;
                frmtipos.Show();
                frmtipos.Focus();
            }

        }
    }
}
