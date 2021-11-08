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
        linea_blancaEntities contexto = new linea_blancaEntities();
        categoria cat = new categoria();
        private List<categoria> categorias = new List<categoria>();
        private int idcategoria = 0;
        public FrmCategorias()
        {
            InitializeComponent();
        }
        private void initializeForm()
        {
            btnCrear.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = true;
            txtNombre.ReadOnly = true;
            dgbCategorias.Enabled = false;
            btnClearFilters.Visible = false;

        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            fillDatagrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            initializeForm();
            txtNombre.Enabled = true;
            btnCrear.Enabled = true;
            clear();
        }
        private void clear()
        {
            txtNombre.Clear();

        }
        public void fillDatagrid()
        {
            categoria cate = new categoria();
            var catego = contexto.categorias.ToList();
            dgbCategorias.DataSource = catego;
            dgbCategorias.Columns[2].Visible = false;
            dgbCategorias.Enabled = true;
            
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            categoria categoria = new categoria();

            try
            {
                categoria.nombre = txtNombre.Text;
                contexto.categorias.Add(categoria);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                categoria ca = contexto.categorias.FirstOrDefault(x => x.id_categoria == idcategoria);
                ca.nombre = txtNombre.Text;
                if (contexto.SaveChanges()== 1)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿De verdad quieres eliminar la categoria?", "Eliminar la categoria",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    categoria cr = contexto.categorias.FirstOrDefault(x => x.id_categoria == idcategoria);
                    


                    //Eliminamos
                    contexto.categorias.Remove(cr);

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

        private void dgbCategorias_Click(object sender, EventArgs e)
        {
            idcategoria = int.Parse(dgbCategorias.SelectedRows[0].Cells[0].Value.ToString());
            txtNombre.Text = dgbCategorias.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBuscar.Text != "")
            {
                btnClearFilters.Visible = true;
            }
        }
    }
}
