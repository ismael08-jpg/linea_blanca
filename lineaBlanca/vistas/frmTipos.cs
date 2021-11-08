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
    public partial class frmTipos : Form
    {
        linea_blancaEntities context = new linea_blancaEntities();
        tipo t = new tipo();
        private List<categoria> cate = new List<categoria>();
        private int idtipo = 0;

        public frmTipos()
        {
            InitializeComponent();
        }
        private void initializeform()
        {
            btnCrear.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnClearFilters.Visible = false;
            dgbTipos.Enabled = false;
        }
        private void clear()
        {
            txtNombre.Clear();
            comboCategorias.SelectedIndex = 1;
            dgbTipos.DataSource = null;
            dgbTipos.Enabled = true;
        }
        public void fillDatagrid()
        {
            tipo tipo = new tipo();
            dgbTipos.DataSource = null;
            var tipos = context.tipoes.ToList();
            dgbTipos.DataSource = tipos;
            txtBuscar.Clear();
            dgbTipos.Columns[3].Visible = false;
            dgbTipos.Columns[4].Visible = false;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                tipo tipo = new tipo();
                tipo.id_categoria = int.Parse(comboCategorias.SelectedValue.ToString());
                tipo.nombre = txtNombre.Text;
                context.tipoes.Add(tipo);
                if (context.SaveChanges() == 1)
                {
                    MessageBox.Show("¡Tipo guardado con éxito!");
                }
                clear();
                fillDatagrid();
                
            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error al tratar de crear el tipo :/" + message.ToString());
            }
            fillcombocategorias();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                tipo ti = context.tipoes.FirstOrDefault(x => x.id_tipo == idtipo);
                ti.nombre = txtNombre.Text;
                ti.id_categoria = int.Parse(comboCategorias.SelectedValue.ToString());
                if (context.SaveChanges() == 1)
                {
                    MessageBox.Show("Modificado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error " + message);
            }
            clear();
            initializeform();
            fillDatagrid();
        }
        public void fillcombocategorias()
        {
            comboCategorias.DataSource = null;
            comboCategorias.DataSource = context.categorias.ToList();
            comboCategorias.DisplayMember = "nombre";
            comboCategorias.ValueMember = "id_categoria";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            fillDatagrid();
            if (txtBuscar.Text != "")
            {
                btnClearFilters.Visible = true;
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            fillDatagrid();
            btnClearFilters.Visible = false;
        }

        private void dgbTipos_Click(object sender, EventArgs e)
        {
            btnCrear.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            idtipo = int.Parse(dgbTipos.SelectedRows[0].Cells[0].Value.ToString());

            txtNombre.Text = dgbTipos.SelectedRows[0].Cells[1].Value.ToString();
            comboCategorias.Text = ((categoria)dgbTipos.SelectedRows[0].Cells[3].Value).nombre;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿De verdad quieres eliminar el crédito?", "Eliminar el crédito",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    tipo ti = context.tipoes.FirstOrDefault(x => x.id_tipo == idtipo);
                    context.tipoes.Remove(ti);
                    if (context.SaveChanges() == 1)
                    {
                        MessageBox.Show("Eliminado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception message)
                {
                    MessageBox.Show("Hubo un error " + message);
                }
                fillcombocategorias();
                clear();
                initializeform();
                fillDatagrid();


            }
        }

        private void frmTipos_Load(object sender, EventArgs e)
        {
            fillcombocategorias();
            fillDatagrid();
        }
    }
}
