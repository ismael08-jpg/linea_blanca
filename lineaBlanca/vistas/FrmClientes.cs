using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;


namespace lineaBlanca.vistas
{
    public partial class FrmClientes : Form
    {
        linea_blancaEntities contexto = new linea_blancaEntities();
        private int idCliente = 0;

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            switch (GlovalEntries.role)
            {
                case 1: // The user is Admin
                    btnEliminar.Visible = true;
                    btnEditar.Visible = true;
                    break;
                case 2: // The user is Almacen
                    btnEliminar.Visible = false;
                    btnEditar.Visible = false;
                    break;
                case 3: // The user is Vendedor
                    btnEliminar.Visible = false;
                    btnEditar.Visible = false;
                    break;
            }
        }

        public FrmClientes()
        {
            InitializeComponent();
            inicializarForm();
            fillDatagrid();
            btnClearFilters.Visible = false;
            refreshAll();
            
        }

        public void refreshAll()
        {
            foreach (var entity in contexto.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        public void inicializarForm()
        {
            txtTelefono.Enabled = false;
            txtDui.Enabled = false;
            txtNombre.Enabled = false;
            txtNit.Enabled = false;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
        }

        public void clear()
        {
            txtTelefono.Clear();
            txtDui.Clear();
            txtNit.Clear();
            txtNombre.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clear();
            txtTelefono.Enabled = true;
            txtDui.Enabled = true;
            txtNombre.Enabled = true;
            txtNit.Enabled = true;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public void fillDatagrid(bool isFiltering = false)
        {
            cliente cliente = new cliente();
            dgbClientes.DataSource = null;
            if (isFiltering)
            {
                var clientes = (from c in contexto.cliente
                                 where c.nombre.Contains(txtBuscar.Text)
                                 || c.dui.Contains(txtBuscar.Text)
                                 || c.nit.Contains(txtBuscar.Text)
                                 select c).ToList();
                dgbClientes.DataSource = clientes;
            }
            else
            {
                var telefonos = contexto.cliente.ToList();
                dgbClientes.DataSource = telefonos;
                txtBuscar.Clear();
            }

            dgbClientes.Columns["credito"].Visible = false;
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            fillDatagrid(true);
            btnClearFilters.Visible = false;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDui.Text != "" && txtNit.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
            {
                cliente cliente = new cliente();
                try
                {
                    cliente.nombre = txtNombre.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.dui = txtDui.Text;
                    cliente.nit = txtNit.Text;

                    contexto.cliente.Add(cliente);
                    if (contexto.SaveChanges() == 1)
                    {
                        MessageBox.Show("El cliente " + cliente.nombre + " fue agregado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    fillDatagrid();
                    clear();
                    inicializarForm();
                }
                catch(Exception message)
                {
                    MessageBox.Show(message.ToString(), "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requerido para agregar el cliente, por favor llenelos.", "No se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgbClientes_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            txtTelefono.Enabled = true;
            txtDui.Enabled = true;
            txtNombre.Enabled = true;
            txtNit.Enabled = true;


            this.idCliente = int.Parse(dgbClientes.SelectedRows[0].Cells[0].Value.ToString());
            txtNombre.Text = dgbClientes.SelectedRows[0].Cells[1].Value.ToString();
            txtTelefono.Text = dgbClientes.SelectedRows[0].Cells[2].Value.ToString();
            txtDui.Text = dgbClientes.SelectedRows[0].Cells[3].Value.ToString();
            txtNit.Text = dgbClientes.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtDui.Text != "" && txtNit.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
            {
                
                try
                {
                    cliente cliente = contexto.cliente.FirstOrDefault(x => x.id_cliente == idCliente);

                    cliente.nombre = txtNombre.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.dui = txtDui.Text;
                    cliente.nit = txtNit.Text;

                    if (contexto.SaveChanges() == 1)
                    {
                        MessageBox.Show("El cliente " + cliente.nombre + " fue modificado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    clear();
                    inicializarForm();
                    fillDatagrid(true);
                }
                catch (Exception message)
                {
                    MessageBox.Show(message.ToString(), "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requerido para editar el cliente, por favor llenelos.", "No se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Estas seguro que desea eliminar el cliente?", "No se podrá recuperar.",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try
                {
                    cliente cliente = contexto.cliente.FirstOrDefault(x => x.id_cliente == idCliente);

                    if (cliente.credito.Count() == 0)
                    {
                        contexto.cliente.Remove(cliente);

                        if (contexto.SaveChanges() == 1)
                        {
                            MessageBox.Show("¡Eliminado con éxito!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL cliiente ya está ligado a uno o varios créditos, no se puede eliminar \n remuevelo de los créditos primero",
                            "NO se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception message)
                {
                    MessageBox.Show(message.ToString(), "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                clear();
                inicializarForm();
                fillDatagrid(true);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }

            
        }
    }
}
