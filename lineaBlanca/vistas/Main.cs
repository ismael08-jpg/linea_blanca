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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDashboard_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDashboard.Checked)
            {
                dashboardView1.Show();
                productoView1.Hide();
                creditoView1.Hide();
            }
        }

        private void BtnPagos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreditos_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCreditos.Checked)
            {
                dashboardView1.Hide();
                productoView1.Hide();
                creditoView1.Show();
            }
        }

        private void btnProductos_CheckedChanged(object sender, EventArgs e)
        {
            if (btnProductos.Checked)
            {
                dashboardView1.Hide();
                productoView1.Show();
                creditoView1.Hide();
            }
        }

        private void productoView1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardView1_Load(object sender, EventArgs e)
        {

        }
    }
}
