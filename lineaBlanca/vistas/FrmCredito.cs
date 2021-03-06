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
    public partial class FrmCredito : Form
    {
        linea_blancaEntities contexto = new linea_blancaEntities();
        producto prod = new producto();
        private List<producto> productos = new List<producto>();
        private decimal total = 0;
        private int LIMTE_PRODUCTOS = 3;
        private int idCredito = 0;

        public FrmCredito()
        {
            InitializeComponent();
            initialzeForm();
            fillComboCliente();
            fillComboProducto();
            fillDatagrid();
        }

        private void initialzeForm()
        {
            btnAddProduct.Enabled = false;
            btnCrear.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = false;
            txtTotal.ReadOnly = true;
            txtCuota.ReadOnly = true;

            numPagos.Enabled = false;
           

            txtInteres.Enabled = false;
            comboCliente.Enabled = false;
            comboProducto.Enabled = false;
            dgbProductos.Enabled = false;
            btnClearFilters.Visible = false;
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            initialzeForm();
            txtInteres.ReadOnly = false;
            btnCrear.Enabled = true;
            btnAddProduct.Enabled = true;
            txtInteres.Enabled = true;
            comboCliente.Enabled = true;
            comboProducto.Enabled = true;
            numPagos.Enabled = true;
           

            clear();
        }

        private void clear()
        {
            total = 0;
            txtInteres.Clear();
            txtTotal.Clear();
            comboCliente.SelectedIndex = 1; //Items.Clear()
            productos.Clear(); //limpiar lista de productos
            dgbProductos.DataSource = null;
            dgbProductos.Enabled = true;
            txtCuota.Clear();
            numPagos.Text = "2";


        }

        public void fillDatagrid(bool isFiltering = false)
        {
            credito cr = new credito();
            dgbCreditos.DataSource = null;
            if (isFiltering)
            {
                var creditos = (from c in contexto.credito
                                 where c.cliente.nombre.Contains(txtBuscar.Text)
                                 || c.cliente.telefono.Contains(txtBuscar.Text)
                                 select c).ToList();
                dgbCreditos.DataSource = creditos;
            }
            else
            {
                var creditos = contexto.credito.ToList();
                dgbCreditos.DataSource = creditos;
                txtBuscar.Clear();
            }

            dgbCreditos.Columns["cliente"].Visible = false;
            dgbCreditos.Columns["producto"].Visible = false;
            dgbCreditos.Columns["pago"].Visible = false;
            dgbCreditos.Columns["usuario"].Visible = false;
            dgbCreditos.Columns["fecha_inicio"].Visible = false;
            dgbCreditos.Columns["estado"].Visible = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            credito credito = new credito();
            

            try
            {
                DateTime now = DateTime.Now;
                credito.id_usuario = 1;
                credito.id_cliente = int.Parse(comboCliente.SelectedValue.ToString());
                credito.interes = decimal.Parse(txtInteres.Text);
                credito.fecha_compra = now;
                credito.cuota = decimal.Parse(txtCuota.Text);
                credito.cantidad_cuotas = int.Parse(numPagos.Text);
                credito.total = total;
                contexto.credito.Add(credito);

                if (contexto.SaveChanges() == 1)
                {
                    MessageBox.Show("¡Crédito creado con éxito!");
                }

                foreach (producto producto in productos)
                {
                    producto prod = contexto.producto.FirstOrDefault(x => x.id_producto == producto.id_producto );
                    prod.id_credito = credito.id_credito;
                    contexto.SaveChanges();
                }

                clear();
                fillDatagrid();
                fillComboProducto();
                dgbProductos.DataSource = null;
            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error al tratar de crear la el crédito :/" + message.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardamos todo en la tabla créditos
                credito cr = contexto.credito.FirstOrDefault(x => x.id_credito == idCredito);

                cr.interes = decimal.Parse(txtInteres.Text);
                cr.id_cliente = int.Parse(comboCliente.SelectedValue.ToString());
                cr.cuota = decimal.Parse(txtCuota.Text);
                cr.cantidad_cuotas = int.Parse(numPagos.Text);
                cr.total = decimal.Parse(txtTotal.Text);

                if (contexto.SaveChanges() == 1)
                {
                    MessageBox.Show("Modificado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Modificar la lista de productos
                var old_prods = (from p in contexto.producto
                                     where p.id_credito == idCredito
                                     select p).ToList();

                //Eliminamos la vieja lista
                if(old_prods.Count > 0)
                {
                    foreach (producto old_prod in old_prods)
                    {
                        producto prod = contexto.producto.FirstOrDefault(x => x.id_producto == old_prod.id_producto);
                        prod.id_credito = null;
                        contexto.SaveChanges();
                    }
                }

                //Agregamos la nueva lista 
                if(productos.Count > 0)
                {
                    foreach (producto producto in productos)
                    {
                        producto prod = contexto.producto.FirstOrDefault(x => x.id_producto == producto.id_producto);
                        prod.id_credito = cr.id_credito;
                        contexto.SaveChanges();
                    }
                }

                fillComboProducto();
            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error " + message);
            }

            clear();
            initialzeForm();
            fillDatagrid(true);
        }

        public void fillComboCliente()
        {
            comboCliente.DataSource = null;
            comboCliente.DataSource = contexto.cliente.ToList();
            comboCliente.DisplayMember = "nombre";
            comboCliente.ValueMember = "id_cliente";
        }

        public void fillComboProducto()
        {
            comboProducto.DataSource = null;
            comboProducto.DataSource = contexto.producto.ToList();
            comboProducto.DataSource = (from p in contexto.producto where p.id_credito == null select p).ToList();
            comboProducto.DisplayMember = "nombre";
            comboProducto.ValueMember = "id_producto";
        }

       

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            prod = (producto)comboProducto.SelectedItem;

            int timesAdded = (from p in productos
                              where p.id_producto == prod.id_producto
                              select p).Count();

            int cantProducts = (from p in productos select p).Count();

            if (timesAdded == 0 && cantProducts < LIMTE_PRODUCTOS)
            {
                productos.Add(prod);

                dgbProductos.DataSource = null;
                dgbProductos.DataSource = productos;
                dgbProductos.Columns["id_credito"].Visible = false;
                dgbProductos.Columns["id_tipo"].Visible = false;
                dgbProductos.Columns["tipo"].Visible = false;
                dgbProductos.Columns["credito"].Visible = false;

                updateTotal(prod.precio);
            }
            else
            {
                string message = "";
                if (cantProducts == LIMTE_PRODUCTOS) message = "No se pueden agregar más productos, el limite son " + LIMTE_PRODUCTOS + " productos";
                else message = "El producto " + prod.nombre + " ya fue agregado.";
                MessageBox.Show(message);
            }
        }

        public void updateTotal(decimal price)
        {
            total = total + price;
            txtTotal.Text = total.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            fillDatagrid(true);
            if (txtBuscar.Text != "")
            {
                btnClearFilters.Visible = true;
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            fillDatagrid(true);
            btnClearFilters.Visible = false;
        }

        private void dgbCreditos_Click(object sender, EventArgs e)
        {
            btnCrear.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            dgbProductos.Enabled = true;
            btnAddProduct.Enabled = true;

            txtInteres.Enabled = true;
            comboCliente.Enabled = true;
            comboProducto.Enabled = true;
            numPagos.Enabled = true;
            dgbProductos.Enabled = true;

            //Fill products table
            idCredito = int.Parse(dgbCreditos.SelectedRows[0].Cells[0].Value.ToString());
            var prods = (from p in contexto.producto 
                         where p.id_credito == idCredito 
                         select p).ToList();


            productos = prods;
            fillProductosTable();


            //Fill the form
            txtInteres.Text = dgbCreditos.SelectedRows[0].Cells[3].Value.ToString();
            comboCliente.Text = ((cliente)dgbCreditos.SelectedRows[0].Cells[10].Value).nombre;
            txtTotal.Text = dgbCreditos.SelectedRows[0].Cells[5].Value.ToString();
            numPagos.Text = dgbCreditos.SelectedRows[0].Cells[7].Value.ToString();
            txtCuota.Text = dgbCreditos.SelectedRows[0].Cells[6].Value.ToString();


        }

        private void dgbProductos_Click(object sender, EventArgs e)
        {
            if(productos.Count > 0)
            {
                if (MessageBox.Show(this, "¿De verdad quieres remover el producto de la lista?", "Aparecera en el dropdown de productos.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idProd = int.Parse(dgbProductos.SelectedRows[0].Cells[0].Value.ToString());

                    productos = productos
                        .Where(x => x.id_producto != idProd)
                        .ToList();

                    //MessageBox.Show(txtInteres.ToS);
                    total = (decimal.Parse(txtTotal.Text) - (decimal.Parse(dgbProductos.SelectedRows[0].Cells[2].Value.ToString())));
                    txtTotal.Text = total.ToString();
                    fillProductosTable();
                }
            }
        }

        private void fillProductosTable()
        {
            dgbProductos.DataSource = null;
            dgbProductos.DataSource = productos;
            dgbProductos.Columns["id_credito"].Visible = false;
            dgbProductos.Columns["id_tipo"].Visible = false;
            dgbProductos.Columns["tipo"].Visible = false;
            dgbProductos.Columns["credito"].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿De verdad quieres eliminar el crédito?", "Eliminar el crédito",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    credito cr = contexto.credito.FirstOrDefault(x => x.id_credito == idCredito);
                    //Modificar la lista de productos
                    var old_prods = (from p in contexto.producto
                                     where p.id_credito == idCredito
                                     select p).ToList();

                    //Eliminamos la vieja lista
                    if (old_prods.Count > 0)
                    {
                        foreach (producto old_prod in old_prods)
                        {
                            producto prod = contexto.producto.FirstOrDefault(x => x.id_producto == old_prod.id_producto);
                            prod.id_credito = null;
                            contexto.SaveChanges();
                        }
                    }


                    //Eliminamos
                    contexto.credito.Remove(cr);

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

            fillComboProducto();
            clear();
            initialzeForm();
            fillDatagrid(true);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            calcularCuota();
        }

        private void FrmCredito_Load(object sender, EventArgs e)
        {

        }

        private void numPagos_ValueChanged(object sender, EventArgs e)
        {
            calcularCuota();
        }

        private void txtInteres_TextChanged(object sender, EventArgs e)
        {
            calcularCuota();
        }

        void calcularCuota()
        {
            if (txtTotal.Text != "" && numPagos.Text != "" && txtInteres.Text != "") //10% = 0.1    20% = 0.2  
            {
                decimal totalConInteres = (decimal.Parse(txtTotal.Text) * (decimal.Parse(txtInteres.Text) / 100)) + decimal.Parse(txtTotal.Text);
                int numeroPagos = int.Parse(numPagos.Text);

                txtCuota.Text = (totalConInteres/numeroPagos).ToString();
            }
        }
    }
}
