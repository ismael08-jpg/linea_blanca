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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {   
            InitializeComponent();
            initializeForm();
        }

        linea_blancaEntities contexto = new linea_blancaEntities();
        categoria cat = new categoria();
        private List<categoria> categorias = new List<categoria>();
        private int idcategoria = 0;

        private void initializeForm()
        {
            btnCrear.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;

            txtNombre.Enabled = false;
            btnClearFilters.Visible = false;

        }
        

      
        private void clear()
        {
            txtNombre.Clear();

        }
       

        public void fillDatagrid(bool isFiltering = false)
        {
            categoria cate = new categoria();

            dgbCategorias.DataSource = null;
            if (isFiltering)
            {
                var catego = (from c in contexto.categoria
                                where c.nombre.Contains(txtBuscar.Text)
                                select c).ToList();
                dgbCategorias.DataSource = catego;
            }
            else
            {
                var catego = contexto.categoria.ToList();
                dgbCategorias.DataSource = catego;
                txtBuscar.Clear();
            }
            dgbCategorias.Columns[2].Visible = false;
        }




        private void FrmCategorias_Load_1(object sender, EventArgs e)
        {
            switch (GlovalEntries.role)
            {
                case 1://IS admin
                    btnEditar.Visible = true;
                    btnEliminar.Visible = true;
                    break;
                case 2: //Almacen
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    break;
                case 3: //Vendedor
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    break;
            }

            fillDatagrid();
            btnClearFilters.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            initializeForm();
            txtNombre.Enabled = true;
            btnCrear.Enabled = true;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;

            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿De verdad quieres eliminar la categoria?", "Eliminar la categoria",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    categoria cr = contexto.categoria.FirstOrDefault(x => x.id_categoria == idcategoria);



                    //Eliminamos
                    contexto.categoria.Remove(cr);

                    if (contexto.SaveChanges() == 1)
                    {
                        MessageBox.Show("Eliminado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                catch (Exception message)
                {
                    MessageBox.Show("Hubo un error " + message);
                }
            }
            clear();
            initializeForm();
            fillDatagrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                categoria ca = contexto.categoria.FirstOrDefault(x => x.id_categoria == idcategoria);
                ca.nombre = txtNombre.Text;
                if (contexto.SaveChanges() == 1)
                {
                    MessageBox.Show("Modificado con exito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error " + message);
            }
            clear();
            initializeForm();
            fillDatagrid();
        }

        private void dgbCategorias_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCrear.Enabled = false;

            idcategoria = int.Parse(dgbCategorias.SelectedRows[0].Cells[0].Value.ToString());
            txtNombre.Text = dgbCategorias.SelectedRows[0].Cells[1].Value.ToString();
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

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            categoria categoria = new categoria();

            try
            {
                categoria.nombre = txtNombre.Text;
                contexto.categoria.Add(categoria);
                if (contexto.SaveChanges() == 1)
                {
                    MessageBox.Show("Categoria guardada con exito");
                }

                clear();
                fillDatagrid();
                dgbCategorias.DataSource = null;
            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error al tratar de crear la categoria :/" + message.ToString());
            }
            fillDatagrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            fillDatagrid(true);
            btnClearFilters.Visible = false;
        }
    }
}
