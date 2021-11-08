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
    public partial class FrmPagos : Form
    {
        linea_blancaEntities contexto = new linea_blancaEntities();
        public FrmPagos()
        {
            InitializeComponent();
            autoCompletar();
        }

        void autoCompletar()
        {
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();

            var clientes = contexto.clientes.ToList();

            foreach (cliente cl in clientes)
            {
                list.Add(cl.nombre);
            }

            txtClientes.AutoCompleteCustomSource = list;
        }
    }
}
