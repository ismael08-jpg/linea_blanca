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
    public partial class FrmTipos : Form
    {
        public FrmTipos()
        {
            
            InitializeComponent();
            fillcombocategorias();
            fillDatagrid();
            initializeform();
        }

        linea_blancaEntities context = new linea_blancaEntities();
        tipo t = new tipo();
        private List<categoria> cate = new List<categoria>();
        private int idtipo = 0;

        
        private void initializeform()
        {
            btnCrear.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = false;
            comboCategorias.Enabled = false;

            btnClearFilters.Visible = false;
           
        }
        private void clear()
        {
            txtNombre.Clear();
            comboCategorias.SelectedIndex = 1;
        }
       

        public void fillDatagrid(bool isFiltering = false)
        {

            dgbTipos.DataSource = null;
            if (isFiltering)
            {
                var tipos = (from t in context.tipo
                                where t.nombre.Contains(txtBuscar.Text)
                                select t).ToList();
                dgbTipos.DataSource = tipos;
            }
            else
            {
                
                var tipos = context.tipo.ToList();
                dgbTipos.DataSource = tipos;
                txtBuscar.Clear();
            }

            dgbTipos.Columns[3].Visible = false;
            dgbTipos.Columns[4].Visible = false;
        }



        public void fillcombocategorias()
        {
            comboCategorias.DataSource = null;
            comboCategorias.DataSource = context.categoria.ToList();
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


        private void frmTipos_Load(object sender, EventArgs e)
        {
            fillcombocategorias();
            fillDatagrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnCrear.Enabled = true;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            comboCategorias.Enabled = true;

            fillcombocategorias();
            fillDatagrid();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                tipo tipo = new tipo();
                tipo.id_categoria = int.Parse(comboCategorias.SelectedValue.ToString());
                tipo.nombre = txtNombre.Text;
                context.tipo.Add(tipo);
                if (context.SaveChanges() == 1)
                {
                    MessageBox.Show("¡Tipo guardado con éxito!");
                }
                

            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error al tratar de crear el tipo :/" + message.ToString());
            }
            fillcombocategorias();
            initializeform();
            clear();
            fillDatagrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿De verdad quieres eliminar el crédito?", "Eliminar el crédito",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    tipo ti = context.tipo.FirstOrDefault(x => x.id_tipo == idtipo);
                    context.tipo.Remove(ti);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                tipo ti = context.tipo.FirstOrDefault(x => x.id_tipo == idtipo);
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

        private void dgbTipos_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            comboCategorias.Enabled = true;

            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnCrear.Enabled = false;

            idtipo = int.Parse(dgbTipos.SelectedRows[0].Cells[0].Value.ToString());

            txtNombre.Text = dgbTipos.SelectedRows[0].Cells[1].Value.ToString();
            comboCategorias.Text = ((categoria)dgbTipos.SelectedRows[0].Cells[3].Value).nombre;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
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

        private void btnClearFilters_Click_1(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            fillDatagrid(true);
            btnClearFilters.Visible = false;
        }

        private void FrmTipos_Load_1(object sender, EventArgs e)
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
        }
    }
}
