using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.Shared;
using lineaBlanca.Reportes;
namespace lineaBlanca.vistas
{

    public partial class FrmReportes : Form
    {

        /**
         * Variable para reporte de Rango
         * */
        ParameterRangeValue param = new ParameterRangeValue();
        ParameterFields parametros= new ParameterFields();
        ParameterField miParametro_inicio = new ParameterField();
        ParameterDiscreteValue inicio = new ParameterDiscreteValue();

        ParameterField miParametro_fin = new ParameterField();
        ParameterDiscreteValue fin = new ParameterDiscreteValue();
        /**
         * Fin Variables reporte Rango
         * */

        /**
        * Variable para reporte de ganancias
        * */
        ParameterFields parametros_ganancia = new ParameterFields();

        ParameterField miParametro_ganancia = new ParameterField();

        ParameterDiscreteValue ganancia = new ParameterDiscreteValue();
        
        /**
        * Fin variable para reporte de ganancias
        * */
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_rangos_Click(object sender, EventArgs e)
        {
            this.miParametro_inicio.ParameterValueType = ParameterValueKind.DateParameter;
            this.miParametro_inicio.Name = "@fecha1";
            this.inicio.Value = Dtp_inicio.Text;
            this.miParametro_inicio.CurrentValues.Add(inicio);
            

            this.miParametro_fin.ParameterValueType = ParameterValueKind.DateParameter;
            this.miParametro_fin.Name = "@fecha2";
            this.fin.Value = Dtp_fin.Text;
            this.miParametro_fin.CurrentValues.Add(fin);

            ParameterFields Pfs = new ParameterFields();
            Pfs.Add(miParametro_inicio);
            Pfs.Add(miParametro_fin);

            this.Crvw_Rango.ParameterFieldInfo = Pfs;


            Report_Rango reprango = new Report_Rango();
            this.Crvw_Rango.ReportSource = reprango;
        }

        private void btn_disponibles_Click(object sender, EventArgs e)
        {
            Report_Disponibilidad rep = new Report_Disponibilidad();
            this.Crvw_Disponibles.ReportSource = rep;
        }

        private void Btn_SUMganancias_Click(object sender, EventArgs e)
        {
            Report_SUMGanancias sumgan = new Report_SUMGanancias();
            this.Crvw_SUMGanancias.ReportSource = sumgan;
        }

        private void Btn_ganancias_Click(object sender, EventArgs e)
        {
            this.miParametro_ganancia.ParameterValueType = ParameterValueKind.NumberParameter;
            this.miParametro_ganancia.Name = "@id";
            this.ganancia.Value = int.Parse(this.txt_idProd.Text);
            this.miParametro_ganancia.CurrentValues.Add(ganancia);
            this.parametros_ganancia.Add(miParametro_ganancia);
            this.Crvw_Ganancias.ParameterFieldInfo = parametros_ganancia;

            Report_Ganancias gan = new Report_Ganancias();
            this.Crvw_Ganancias.ReportSource = gan;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.txt_idProd.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Report_pendientes pendientes = new Report_pendientes();
            this.Crvw_Debe.ReportSource = pendientes;
        }
    }
}
