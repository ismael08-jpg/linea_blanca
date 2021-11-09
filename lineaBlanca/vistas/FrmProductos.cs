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
    public partial class FrmProductos : Form
    {
        private string auxiliar;
        linea_blancaEntities context = new linea_blancaEntities();
        producto producto = new producto();
        private int idproducto = 0;
        bool comboReady = false;
        public FrmProductos()
        {
            
            InitializeComponent();
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCProductos_ValueChanged(object sender, EventArgs e)
        {



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            fillDatagrid();
            //comboReady = false;
            //fillcomboCategoria();
            clear();

            btnCrear.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtprecio.Enabled = true;
            comboCategorias.Enabled = true;
            comboTipos.Enabled = true;
            txtCProductos.Enabled = true;
            
        }

        private void clear()
        {
            txtNombre.Clear();
            txtprecio.Clear();
            //comboCategorias.SelectedIndex = -1;
            //comboTipos.SelectedIndex= -1;
            txtCProductos.ResetText();
        }

        private void inicializeForm()
        {
            btnCrear.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;

            txtNombre.Enabled = false;
            txtprecio.Enabled = false;
            comboCategorias.Enabled = false;
            comboTipos.Enabled = false;
            txtCProductos.Enabled = false;

        }

        public void fillDatagrid(bool isFiltering = false)
        {
            
            dgbProductos.DataSource = null;
            if (isFiltering)
            {
                var productos = (from c in context.producto
                                where c.nombre.Contains(txtBuscar.Text)
                                select c).ToList();
                dgbProductos.DataSource = productos;
            }
            else
            {
                var productos = context.producto.ToList();
                dgbProductos.DataSource = productos;
                txtBuscar.Clear();
            }

            dgbProductos.Columns[3].Visible = false;
            dgbProductos.Columns[5].Visible = false;
            dgbProductos.Columns[6].Visible = false;
        }


        public void fillcomboCategoria()
        {
            comboCategorias.DataSource = context.categoria.ToList();
            comboCategorias.DisplayMember = "nombre";
            comboCategorias.ValueMember = "id_categoria";
            comboCategorias.SelectedIndex = 1;
            auxiliar = comboCategorias.SelectedValue.ToString();
            comboReady = true;
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
                    context.producto.Add(producto);
                    context.SaveChanges();

                }
                MessageBox.Show(auxcproducto + " cantidad de productos creados exitosamente!");
            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error al tratar de crear  el producto :/" + message.ToString());
            }

            fillDatagrid();
            inicializeForm();
            clear();
        }

        private void dgbTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void dgbTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                producto producto = context.producto.FirstOrDefault(x => x.id_producto == idproducto);
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
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error " + message);
            }
            fillDatagrid();
            inicializeForm();
            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(this, "¿Estas seguro de eliminar el siguiente producto?", "Eliminar el producto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    producto producto = context.producto.FirstOrDefault(x => x.id_producto == idproducto);
                    MessageBox.Show(idproducto.ToString());

                    if (producto.credito == null)
                    {
                        context.producto.Remove(producto);
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
            inicializeForm();
            clear();
        }

        private void dgbProductos_Click(object sender, EventArgs e)
        {
            if (dgbProductos.SelectedRows[0].Cells[0].Value.ToString() != "")
            {
                comboTipos.DataSource = context.tipo.ToList();
                comboTipos.DisplayMember = "nombre";
                comboTipos.ValueMember = "id_tipo";

                btnCrear.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;

                txtCProductos.Enabled = false;
                txtNombre.Enabled = true;
                txtprecio.Enabled = true;
                comboCategorias.Enabled = true;
                comboTipos.Enabled = true;

                idproducto = int.Parse(dgbProductos.SelectedRows[0].Cells[0].Value.ToString());
                txtNombre.Text = dgbProductos.SelectedRows[0].Cells[1].Value.ToString();
                txtprecio.Text = dgbProductos.SelectedRows[0].Cells[2].Value.ToString();
                comboTipos.Text = ((tipo)dgbProductos.SelectedRows[0].Cells[6].Value).nombre;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            fillDatagrid(true);
            if (txtBuscar.Text != "")
            {
                btnClearFilters.Visible = true;
            }
            else
            {
                btnClearFilters.Visible = false;
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            fillDatagrid(true);
            btnClearFilters.Visible = false;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            fillDatagrid();
            comboReady = false;
            fillcomboCategoria();
            inicializeForm();
            btnClearFilters.Visible = false;
        }

        private void comboCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (comboReady)
                {
                    comboTipos.DataSource = null;
                    auxiliar = comboCategorias.SelectedValue.ToString();
                    List<tipo> newlist = new List<tipo>();
                    var aux1 = context.tipo.ToList();
                    var aux2 = context.tipo.ToList();
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
            } catch (Exception message)
            {
                MessageBox.Show("Hubo un error" + message.ToString());
            }
        }

        private void comboTipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
