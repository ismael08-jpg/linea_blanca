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
    public partial class FrmPagos : Form
    {
        linea_blancaEntities contexto = new linea_blancaEntities();
        private int idPago = 0;
        bool comboClienteReady = false;
        private decimal MORA = 0.07m;  
        public FrmPagos()
        {
            InitializeComponent();
            autoCompletar();
            fillComboCliente();
            comboCliente.SelectedIndex = 0;
            InitializeForm();
        }

        
        private void InitializeForm()
        {
            txtCuota.ReadOnly = true;
            txtMora.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtFechaLimite.ReadOnly = true;
            btnPagar.Enabled = false;
            
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
             fillDgbCreditos();
            
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
                    txtMora.Text = "0.00";
                    if (result < 0)
                    {
                        //is earlier than
                        
                        labelInfo.Text = "¡A este crédito no se le recargará mora!";
                        
                    }
                    else if (result == 0)
                    {
                        //The same as
                        labelInfo.Text = "Estas casi al limite, debes pagar hoy para que no se te recargue mora";
                        
                    }
                    else if (result > 0)
                    {
                        //Later than
                        labelInfo.ForeColor = System.Drawing.Color.Red;
                        txtMora.Text = (decimal.Parse(dgbCreditos.SelectedRows[0].Cells[4].Value.ToString()) * MORA).ToString();
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
                //txtMora.Text = 
                txtTotal.Text = (decimal.Parse(dgbCreditos.SelectedRows[0].Cells[4].Value.ToString()) + MORA).ToString();



                btnPagar.Enabled = true;
            }
          
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Marcar como pagado el esta cuota?", "¿Pagar?",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime now = DateTime.Now;
                    //Editar el pago
                    pago p = contexto.pago.FirstOrDefault(x => x.id_pago == idPago);
                    p.fecha_pago = now;
                    p.estado = "Pagado";
                    p.mora = decimal.Parse(txtMora.Text);

                    //Crear pago nuevo.
                    pago pago = new pago();
                    pago.id_credito = p.id_credito;
                    pago.monto = p.monto;
                    pago.estado = "Pendiente";
                    if (p.fecha_limite == null)
                    {
                        pago.fecha_limite = now.AddMonths(1);
                    } else
                    {
                        DateTime fecha = (DateTime)p.fecha_limite;
                        pago.fecha_limite = fecha.AddMonths(1);
                    }
                    
                    contexto.pago.Add(pago);
                    p.fecha_limite = now;

                    if (contexto.SaveChanges() == 2)
                    {
                        MessageBox.Show("Pagado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    fillDgbCreditos();
                }
            }
            catch (Exception message)
            {
                MessageBox.Show("Hubo un error  :/" + message.ToString());
            }
        }
    }
}
