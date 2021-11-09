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
    public partial class FrmUsuarios : Form
    {
        linea_blancaEntities contexto = new linea_blancaEntities();
        private int idUsuario = 0;
        


        public FrmUsuarios()
        {
            InitializeComponent();
            inicializarForm();
            fillDatagrid();
            btnClearFilters.Visible = false;
            btnChangePasword.Visible = false;
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
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword2.Enabled = false;
            txtNombre.Enabled = false;
            comboCargo.Enabled = false;
           
       

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
        }

        public void clear()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtPassword2.Clear();
            comboCargo.SelectedIndex = 0;
            txtNombre.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clear();
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtPassword2.Enabled = true;
            txtNombre.Enabled = true;
            comboCargo.Enabled = true;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnChangePasword.Text = "Cambiar contraseña";
            btnChangePasword.Visible = false;
        }

        public void fillDatagrid(bool isFiltering = false)
        {
            
            dgbUsuarios.DataSource = null;
            if (isFiltering)
            {
                var usuarios = (from c in contexto.usuario
                                 where c.nombre.Contains(txtBuscar.Text)
                                 || c.nombre.Contains(txtBuscar.Text)
                                 || c.username.Contains(txtBuscar.Text)
                                 select c).ToList();
                dgbUsuarios.DataSource = usuarios;
            }
            else
            {
                var usuarios = contexto.usuario.ToList();
                dgbUsuarios.DataSource = usuarios;
                txtBuscar.Clear();
            }

            dgbUsuarios.Columns["credito"].Visible = false;
            dgbUsuarios.Columns["rol"].Visible = false;
            dgbUsuarios.Columns["pass_word"].Visible = false;
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
            } else
            {
                btnClearFilters.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtPassword2.Text != "" && txtNombre.Text != "" && txtUserName.Text != "")
            {
                if (txtPassword.Text == txtPassword2.Text)
                {
                    usuario usuario = new usuario();
                    try
                    {
                        usuario.nombre = txtNombre.Text;
                        usuario.username = txtUserName.Text;
                        usuario.pass_word = txtPassword.Text;
                        usuario.cargo = comboCargo.Text;

                        if (usuario.cargo == "Administrador")
                            usuario.rol = 1;
                        else if (usuario.cargo == "Almacen")
                            usuario.rol = 2;
                        else if (usuario.cargo == "Vendedor")
                            usuario.rol = 3;



                        contexto.usuario.Add(usuario);
                        if (contexto.SaveChanges() == 1)
                        {
                            MessageBox.Show("El Usuario " + usuario.nombre + " fue agregado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        fillDatagrid();
                        clear();
                        inicializarForm();
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString(), "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no cinciden", "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requerido para agregar el usuario, por favor llenelos.", "No se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgbClientes_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            txtUserName.Enabled = true;
            txtNombre.Enabled = true;
            comboCargo.Enabled = true;
            
            


            this.idUsuario = int.Parse(dgbUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            txtNombre.Text = dgbUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            txtUserName.Text = dgbUsuarios.SelectedRows[0].Cells[2].Value.ToString();
            comboCargo.Text = dgbUsuarios.SelectedRows[0].Cells[3].Value.ToString();

            txtPassword.Enabled = false;
            txtPassword2.Enabled = false;
            btnChangePasword.Visible = true; 
            btnChangePasword.Text = "Cambiar contraseña";
            //txtPassword.Text = dgbUsuarios.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            try
            {
                usuario usuario = contexto.usuario.FirstOrDefault(x => x.id_usuario == idUsuario);

                if (txtPassword.Enabled 
                    && txtPassword2.Enabled 
                    && txtPassword.Text != "" 
                    && txtPassword2.Text != "" 
                    && txtNombre.Text != "" 
                    && txtUserName.Text != "") 
                {
                    
                    if(txtPassword.Text == txtPassword2.Text)
                    {
                        usuario.nombre = txtNombre.Text;
                        usuario.username = txtUserName.Text;
                        usuario.cargo = comboCargo.Text;
                        usuario.pass_word = txtPassword.Text;

                        if (usuario.cargo == "Administrador")
                            usuario.rol = 1;
                        else if (usuario.cargo == "Almacen")
                            usuario.rol = 2;
                        else if (usuario.cargo == "Vendedor")
                            usuario.rol = 3;

                        if (contexto.SaveChanges() == 1)
                        {
                            MessageBox.Show("El usuario " + usuario.nombre + " fue modificado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        clear();
                        inicializarForm();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "No se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtPassword2.Clear();
                    }

                }
                else if (txtNombre.Text != "" && txtUserName.Text != "")
                {

                    
                        usuario.nombre = txtNombre.Text;
                        usuario.username = txtUserName.Text;
                        usuario.cargo = comboCargo.Text;
                   

                        if (usuario.cargo == "Administrador")
                            usuario.rol = 1;
                        else if (usuario.cargo == "Almacen")
                            usuario.rol = 2;
                        else if (usuario.cargo == "Vendedor")
                            usuario.rol = 3;

                        if (contexto.SaveChanges() == 1)
                        {
                            MessageBox.Show("El usuario " + usuario.nombre + " fue modificado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    clear();
                    inicializarForm();
                }
                else
                {
                    MessageBox.Show("2Todos los campos son requerido para editar el usuario, por favor llenelos.", "No se pudo crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



          
                fillDatagrid(true);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.ToString(), "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Estas seguro que desea eliminar el usuario?", "No se podrá recuperar.",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try
                {
                    usuario usuario = contexto.usuario.FirstOrDefault(x => x.id_usuario == idUsuario);

                    if (usuario.credito.Count() == 0)
                    {
                        contexto.usuario.Remove(usuario);

                        if (contexto.SaveChanges() == 1)
                        {
                            MessageBox.Show("¡Eliminado con éxito!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL usuario ya está ligado a uno o varios créditos, no se puede eliminar \n remuevelo de los créditos primero",
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

        private void btnChangePasword_Click(object sender, EventArgs e)
        {
            

            if(btnChangePasword.Text == "Cancelar")
            {
                txtPassword.Enabled = false;
                txtPassword2.Enabled = false;
                btnChangePasword.Text = "Cambiar contraseña";
            } else
            {
                txtPassword.Enabled = true;
                txtPassword2.Enabled = true;
                btnChangePasword.Text = "Cancelar";
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
