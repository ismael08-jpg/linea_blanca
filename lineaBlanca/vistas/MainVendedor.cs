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
    public partial class MainVendedor : Form
    {
        FrmCredito frmCre = new FrmCredito();
        FrmInicio frmInicio = new FrmInicio();
        FrmPagos frmPagos = new FrmPagos();
        FrmReportes frmRepos = new FrmReportes();
        FrmClientes frmClientes = new FrmClientes();
        FrmUsuarios frmUsuarios = new FrmUsuarios();
        public MainVendedor()
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

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            if (btnCreditos.Checked)
            {
                frmCre.MdiParent = this;
                frmCre.Show();
                frmCre.Focus();

            }
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            if (btnPagos.Checked)
            {
                frmPagos.MdiParent = this;
                frmPagos.Show();
                frmPagos.Focus();
            }
        }

       

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (btnClientes.Checked)
            {
                frmClientes.MdiParent = this;
                frmClientes.Show();
                frmClientes.Focus();
            }
        }

    }
}
