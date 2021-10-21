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
    public partial class CreditoView : UserControl
    {
        //linea_blancaEntities contexto = new linea_blancaEntities();
        //producto prod = new producto();
        //List<producto> productos = new List<producto>();
        //decimal total = 0;
        //int LIMTE_PRODUCTOS = 3;

        public CreditoView()
        {
            InitializeComponent();

            //fillComboCliente();
            //fillComboProducto();
            //txtTotal.ReadOnly = true;
            //btnCrear.Enabled = false;
            //btnEditar.Enabled = false;
        }

        public void fillComboCliente()
        {
            //comboCliente.DataSource = null;
            //comboCliente.DataSource = contexto.cliente.ToList();
            //comboCliente.DisplayMember = "nombre";
            //comboCliente.ValueMember = "id_cliente";
        }

        public void fillComboProducto()
        {
            //comboProducto.DataSource = null;
            //comboProducto.DataSource = contexto.producto.ToList();
            //comboProducto.DataSource = (from p in contexto.producto where p.id_credito == null select p).ToList();
            //comboProducto.DisplayMember = "nombre";
            //comboProducto.ValueMember = "id_producto";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //prod = (producto)comboProducto.SelectedItem;

            //int timesAdded = (from p in productos
            //                  where p.id_producto == prod.id_producto
            //                  select p).Count();

            //int cantProducts = (from p in productos select p).Count();

            //if (timesAdded == 0 && cantProducts < LIMTE_PRODUCTOS)
            //{
            //    productos.Add(prod);

            //    dgbProductos.DataSource = null;
            //    dgbProductos.DataSource = productos;
            //    dgbProductos.Columns["id_credito"].Visible = false;
            //    dgbProductos.Columns["id_tipo"].Visible = false;
            //    dgbProductos.Columns["tipo"].Visible = false;
            //    dgbProductos.Columns["credito"].Visible = false;

            //    updateTotal(prod.precio);
            //}
            //else
            //{
            //    string message = "";
            //    if (cantProducts == LIMTE_PRODUCTOS) message = "No se pueden agregar más productos, el limite son " + LIMTE_PRODUCTOS + " productos";
            //    else message = "El producto " + prod.nombre + " ya fue agregado.";
            //    MessageBox.Show(message);
            //}
        }

        public void updateTotal(decimal price)
        {
            total = total + price;
            txtTotal.Text = total.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
