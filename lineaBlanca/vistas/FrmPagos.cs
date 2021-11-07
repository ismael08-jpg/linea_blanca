using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace lineaBlanca.vistas
{
    public partial class FrmPagos : Form
    {
        linea_blancaEntities contexto = new linea_blancaEntities();
        private int idPago = 0;
        bool comboClienteReady = false;
        bool comboHistorialClienteReady = false;
        private decimal MORA = 0.07m;  
        public FrmPagos()
        {
            refreshAll();
            InitializeComponent();
            autoCompletar();
            fillComboCliente();
            comboCliente.SelectedIndex = 0;
            InitializeForm();
            fillComboHistorialClientes();
        }

        public void refreshAll()
        {
            foreach (var entity in contexto.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        private void InitializeForm()
        {
            txtCuota.ReadOnly = true;
            txtMora.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtFechaLimite.ReadOnly = true;
            btnPagar.Enabled = false;
        }

        private void clear()
        {
            txtCuota.Clear();
            txtMora.Clear();
            txtTotal.Clear();
            txtFechaLimite.Clear();
            btnPagar.Enabled = false;
            idPago = 0;
            labelInfo.Text = "";
        }
        void fillComboCliente()
        {
            List<cliente> clientes = new List<cliente>();
            cliente cl = new cliente();
            cl.nombre = "Selecione un cliente";
            cl.id_cliente = 0;
            clientes.Add(cl);

            foreach (cliente cliente in contexto.cliente.ToList())
            {
                clientes.Add(cliente);
            }


            comboCliente.DataSource = null;
            comboCliente.DataSource = clientes;
            comboCliente.DisplayMember = "nombre";
            comboCliente.ValueMember = "id_cliente";
            comboClienteReady = true;
           
        }

        void autoCompletar()
        {
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();

            var clientes = contexto.cliente.ToList();

            foreach (cliente cl in clientes)
            {
                list.Add(cl.nombre);
            }

            txtClientes.AutoCompleteCustomSource = list;
        }

        private void fillDgbCreditos()
        {

            try
            {
                int idCliente = int.Parse(comboCliente.SelectedValue.ToString());
                credito cr = new credito();
                cr = contexto.credito.FirstOrDefault(x => x.id_cliente == idCliente 
                && (x.estado == "En progreso" || x.estado == "No iniciado"));

               if(cr != null)
               {
                    dgbCreditos.DataSource = null;
                    dgbCreditos.DataSource = (from p in contexto.pago
                                              where p.id_credito == cr.id_credito
                                              orderby p.id_pago descending
                                              select new
                                              {
                                                  ID = p.id_pago,
                                                  Cliente = p.credito.cliente.nombre,
                                                  Fecha_pago = p.fecha_pago,
                                                  Fecha_limite = p.fecha_limite,
                                                  Monto = p.monto,
                                                  p.mora,
                                                  Estado = p.estado,
                                                  ID_credito = p.id_credito,
                                                  p.credito
                                              }).ToList();
                    dgbCreditos.Columns["credito"].Visible = false;
                } else
                {
                    if (idCliente != 0)
                    {
                        dgbCreditos.DataSource = null;
                        MessageBox.Show("El cliente no poseé creditos activos", "No hay pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error  :/" + message.ToString());
            }
            
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboClienteReady)
            {
                fillDgbCreditos();
            }
            clear();


        }

        private void dgbCreditos_Click(object sender, EventArgs e)
        {
            if(dgbCreditos.SelectedRows[0].Cells[6].Value.ToString() == "Pendiente")
            {
                DateTime now = DateTime.Now;
                decimal mora = 0;
                idPago = int.Parse(dgbCreditos.SelectedRows[0].Cells[0].Value.ToString());
                labelInfo.Text = "";
                labelInfo.ForeColor = System.Drawing.Color.Gray;
                if (dgbCreditos.SelectedRows[0].Cells[3].Value != null)
                {
                    txtFechaLimite.Text = dgbCreditos.SelectedRows[0].Cells[3].Value.ToString();
                    labelInfo.Text = "¡A este crédito no se le recargará mora!";

                    //Evaluar si el pago tiene mora
                    int result = DateTime.Compare(now, DateTime.Parse(dgbCreditos.SelectedRows[0].Cells[3].Value.ToString()));
                    
                    if (result < 0)
                    {
                        //is earlier than
                        labelInfo.ForeColor = System.Drawing.Color.Gray;
                        labelInfo.Text = "¡A este crédito no se le recargará mora!";
                        mora = 0.0m;

                    }
                    else if (result == 0)
                    {
                        //The same as
                        labelInfo.Text = "Estas casi al limite, debes pagar hoy para que no se te recargue mora";
                        mora = 0.0m;

                    }
                    else if (result > 0)
                    {
                        //Later than
                        labelInfo.ForeColor = System.Drawing.Color.Red;
                        //txtMora.Text = (decimal.Parse(dgbCreditos.SelectedRows[0].Cells[4].Value.ToString()) * MORA).ToString();
                        labelInfo.Text = "Se le recargará el %7 de mora por el pago tardado";
                        mora = decimal.Parse(dgbCreditos.SelectedRows[0].Cells[4].Value.ToString()) * MORA;
                    }
                }
                else
                {
                    txtFechaLimite.Text = "Primer pago";
                    labelInfo.Text = "(No hay fecha limite) El primer pago marca el inicio de los pagos del crédito";
                }
                txtCuota.Text = dgbCreditos.SelectedRows[0].Cells[4].Value.ToString();
                txtMora.Text = mora.ToString();
                txtTotal.Text = (decimal.Parse(dgbCreditos.SelectedRows[0].Cells[4].Value.ToString()) + mora).ToString();



                btnPagar.Enabled = true;
            } else
            {
                clear();
                labelInfo.ForeColor = System.Drawing.Color.Green;
                labelInfo.Text = "Este pago ya fue realizado: " + String.Format("{0:dd-MM-yyyy}", dgbCreditos.SelectedRows[0].Cells[2].Value.ToString());
            }
          
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                refreshAll();

                pago pago = contexto.pago.FirstOrDefault(x => x.id_pago == idPago);

                if (pago != null)
                {
                    if (MessageBox.Show(this, "¿Marcar como pagado el esta cuota?", "¿Pagar?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DateTime now = DateTime.Now;
                        //Editar el pago
                        
                        pago.credito.estado = "En progreso";
                        pago.fecha_pago = now;
                        pago.estado = "Pagado";
                        if (pago.fecha_limite == null)
                        {
                            pago.fecha_limite = now;
                        }

                        if (txtMora.Text != "")
                        {
                            pago.mora = decimal.Parse(txtMora.Text);
                        }
                        else
                        {
                            pago.mora = 0.00m;
                        }

                        if (contexto.SaveChanges() == 1)
                        {
                            MessageBox.Show("Pagado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //Validar que sean todos los pagos
                        int cantPagos = (from p in contexto.pago
                                         where p.id_credito == pago.id_credito
                                         select p).Count();

                        if (cantPagos < pago.credito.cantidad_cuotas)
                        {
                            //Crear pago del siguiente mes
                            pago siguientePago = new pago();
                            siguientePago.id_credito = pago.id_credito;
                            siguientePago.monto = pago.monto;
                            siguientePago.estado = "Pendiente";
                            if (pago.fecha_limite == null)
                            {
                                siguientePago.fecha_limite = now.AddMonths(1);
                                //pago.fecha_limite = now;
                            }
                            else
                            {
                                DateTime fecha = (DateTime)pago.fecha_limite;
                                siguientePago.fecha_limite = fecha.AddMonths(1);
                            }

                            contexto.pago.Add(siguientePago);
                        }
                        else
                        {
                            pago.credito.estado = "Finalizado";
                            MessageBox.Show("Se realizó el último pago con éxito\n El crédito está finalizado \n podrá ver los pagos en el historial", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        contexto.SaveChanges();

                        
                    }
                } else
                {
                    MessageBox.Show("Intentelo de nuevo por favor", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                refreshAll();
                fillDgbCreditos();
                clear();
            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error  :/" + message.ToString());
            }
        }

        // . Historial de pagos . ------------------------------------------------------------ Ismael
        bool comboHistorialCreditoReady = false;

        private void fillComboHistorialCreditos()
        {

            try
            {
                int idCliente = int.Parse(comboHistorialCliente.SelectedValue.ToString());
                
                List<credito> creditos = new List<credito>();
              

                creditos = (from c in contexto.credito
                      where c.estado == "Finalizado" && c.id_cliente == idCliente
                      orderby c.fecha_compra descending
                      select c).ToList();

                if (creditos.Count > 0)
                {
                    comboHistorialCredito.DataSource = null;
                    comboHistorialCredito.DataSource = creditos;
                    comboHistorialCredito.DisplayMember = "fecha_compra";
                    comboHistorialCredito.ValueMember = "id_credito";
                }
                else
                {
                    if (idCliente != 0)
                    {
                        dgbCreditos.DataSource = null;
                        MessageBox.Show("El cliente no poseé historial de créditos", "No hay créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                comboHistorialCreditoReady = true;

            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error  :/" + message.ToString());
            }

        }


        private void fillComboHistorialClientes()
        {
            List<cliente> clientes = new List<cliente>();
            cliente cl = new cliente();
            cl.nombre = "Selecione un cliente";
            cl.id_cliente = 0;
            clientes.Add(cl);

            foreach (cliente cliente in contexto.cliente.ToList())
            {
                clientes.Add(cliente);
            }


            comboHistorialCliente.DataSource = null;
            comboHistorialCliente.DataSource = clientes;
            comboHistorialCliente.DisplayMember = "nombre";
            comboHistorialCliente.ValueMember = "id_cliente";
            comboHistorialClienteReady = true;
        }

        private void comboHistorialCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgbHistorialPago.DataSource = null;
            comboHistorialCredito.DataSource = null;
            if (comboHistorialClienteReady)
            fillComboHistorialCreditos();  
        }


        private void fillDgbHistorialPagos()
        {

            try
            {

                if (comboHistorialCredito.SelectedValue != null)
                {
                   
                    int idCredito = int.Parse(comboHistorialCredito.SelectedValue.ToString());


                    dgbHistorialPago.DataSource = null;
                    dgbHistorialPago.DataSource = (from p in contexto.pago
                                              where p.id_credito == idCredito
                                              orderby p.id_pago descending
                                              select new
                                              {
                                                  ID = p.id_pago,
                                                  Cliente = p.credito.cliente.nombre,
                                                  Fecha_pago = p.fecha_pago,
                                                  Fecha_limite = p.fecha_limite,
                                                  Monto = p.monto,
                                                  p.mora,
                                                  Estado = p.estado,
                                                  ID_credito = p.id_credito,
                                                  p.credito
                                              }).ToList();
                    dgbHistorialPago.Columns["credito"].Visible = false;
                } else
                {
                    dgbHistorialPago.DataSource = null;
                }
               

            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error  :/" + message.ToString());
            }

        }

        private void comboHistorialCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgbHistorialPago.DataSource = null;
            if (comboHistorialCreditoReady && comboHistorialCliente.SelectedValue.ToString() != "0")
                fillDgbHistorialPagos();

          
        }
    }
}
