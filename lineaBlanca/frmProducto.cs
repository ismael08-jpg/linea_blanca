using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lineaBlanca
{
    public partial class frmProducto : Form
    {
        private string auxiliar ;
        linea_blancaEntities context = new linea_blancaEntities();
        producto producto = new producto();
        private int idproducto = 0;
        public void fillDatagrid()
        {
            producto pro = new producto();
            var producto = context.productoes.ToList();
            dgbProductos.DataSource = producto;
            dgbProductos.Columns[3].Visible = false;
            dgbProductos.Columns[5].Visible = false;
            dgbProductos.Columns[6].Visible = false;
            dgbProductos.Enabled = true;


        }
        public void fillcomboCategoria()
        {
            comboCategorias.DataSource = context.categorias.ToList();
            comboCategorias.DisplayMember = "nombre";
            comboCategorias.ValueMember = "id_categoria";
            comboCategorias.SelectedIndex = 1;
            auxiliar = comboCategorias.SelectedValue.ToString();
        }
        public frmProducto()
        {
            InitializeComponent();
        }

        private void comboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTipos.DataSource = null;
            auxiliar = comboCategorias.SelectedValue.ToString();
            List<tipo> newlist = new List<tipo>();
            var aux1 = context.tipoes.ToList();
            var aux2 = context.tipoes.ToList();
            for (int i = 0; i < aux1.Count(); i++)
            {
                if (aux2[i].id_categoria.ToString() == auxiliar)
                {
                    newlist.Add(aux2[i]);
                }
            }
            comboTipos.DataSource = null;
            comboTipos.DataSource = newlist;
            comboTipos.DisplayMember = "nombre";
            comboTipos.ValueMember = "id_tipo";
        }


        private void frmProducto_Load(object sender, EventArgs e)
        {
            fillDatagrid();
            fillcomboCategoria();

        }

        private void comboCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            producto producto = new producto();
            try
            {
                int auxcproducto = (int)txtCProductos.Value;
                producto.nombre = txtNombre.Text;
                string aux = txtprecio.Text;
                float auxfloat = float.Parse(aux);
                producto.precio = (decimal)auxfloat;
                producto.id_tipo = int.Parse(comboTipos.SelectedValue.ToString());
                for (int i = 0; i <= auxcproducto; i++)
                {
                    context.productoes.Add(producto);
                    context.SaveChanges();

                }
                MessageBox.Show(auxcproducto + " cantidad de productos creados exitosamente!");
            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error al tratar de crear  el producto :/" + message.ToString());
            }
        }

        private void dgbTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgbTipos_Click(object sender, EventArgs e)
        {
            idproducto = int.Parse(dgbProductos.SelectedRows[0].Cells[0].Value.ToString());
            txtNombre.Text = dgbProductos.SelectedRows[0].Cells[1].Value.ToString();
            txtprecio.Text = dgbProductos.SelectedRows[0].Cells[2].Value.ToString();
            comboTipos.SelectedValue = dgbProductos.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dgbTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                producto producto = context.productoes.FirstOrDefault(x => x.id_producto == idproducto);
                if (producto.id_credito == null) 
                {
                    producto.nombre = txtNombre.Text;
                    string aux = txtprecio.Text;
                    float auxfloat = float.Parse(aux);
                    producto.precio = (decimal)auxfloat;
                    producto.id_tipo = int.Parse(comboTipos.SelectedValue.ToString());
                    context.SaveChanges();

                    MessageBox.Show("Modificado con exito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error! Producto seleccionado ya fue vendido", "Entendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception message)
            {
                MessageBox.Show("Hubo un error " + message);
            }
            fillDatagrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "¿Estas seguro de eliminar el siguiente producto?", "Eliminar el producto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    producto producto = context.productoes.FirstOrDefault(x => x.id_producto == idproducto);
                    MessageBox.Show(idproducto.ToString());
                    
                    if (producto.credito == null)
                    {
                        context.productoes.Remove(producto);
                        context.SaveChanges();
                        MessageBox.Show("Eliminado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error! Producto seleccionado ya fue vendido", "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception message)
                {
                    MessageBox.Show("Hubo un error " + message);
                }
            }
            fillDatagrid();
        }
    }
}
