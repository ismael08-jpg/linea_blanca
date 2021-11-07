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
        

        ParameterFields parametros_inicio = new ParameterFields();

        ParameterFields parametros_fin = new ParameterFields();

        ParameterField miParametro_inicio = new ParameterField();

        ParameterField miParametro_fin = new ParameterField();

        ParameterDiscreteValue inicio = new ParameterDiscreteValue();

        ParameterDiscreteValue fin = new ParameterDiscreteValue();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_rangos_Click(object sender, EventArgs e)
        {
            Dtp_inicio.Format = DateTimePickerFormat.Custom;
            Dtp_inicio.CustomFormat = "yyyy-MM-dd";
            this.miParametro_inicio.ParameterValueType = ParameterValueKind.DateParameter;
            this.miParametro_inicio.Name = "@fecha1";
            this.inicio.Value = this.maskedTextBox1;
            this.miParametro_inicio.CurrentValues.Add(inicio);
            this.parametros_inicio.Add(miParametro_inicio);

            Dtp_fin.Format = DateTimePickerFormat.Custom;
            Dtp_fin.CustomFormat = "yyyy-MM-dd";
            this.miParametro_fin.ParameterValueType = ParameterValueKind.DateParameter;
            this.miParametro_fin.Name = "@fecha2";
            this.fin.Value = this.maskedTextBox2;
            this.miParametro_fin.CurrentValues.Add(fin);
            this.parametros_fin.Add(miParametro_fin);

            Report_Rango reprango = new Report_Rango();
            this.Crvw_Rango.ReportSource = reprango;
        }

        private void btn_disponibles_Click(object sender, EventArgs e)
        {
            

            Report_Disponibilidad rep = new Report_Disponibilidad();
            this.Crvw_Disponibles.ReportSource = rep;
        }
    }
}
