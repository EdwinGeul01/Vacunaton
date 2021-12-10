using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Vacunaton_21811039
{
    public partial class Report_CentroA : Form
    {
        public Report_CentroA()
        {
            InitializeComponent();
        }

        private void Report_CentroA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.CentroAsistencia' Puede moverla o quitarla según sea necesario.
            this.CentroAsistenciaTableAdapter.Fill(this.VacunatonDataSet.CentroAsistencia);

            this.reportViewer1.RefreshReport();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            if(cbidname.Checked)
            {
                this.CentroAsistenciaTableAdapter.FillById(this.VacunatonDataSet.CentroAsistencia,txtinfo.Text);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.CentroAsistenciaTableAdapter.Fill(this.VacunatonDataSet.CentroAsistencia);
                this.reportViewer1.RefreshReport();
            }
        }

        private void cbidname_CheckedChanged(object sender, EventArgs e)
        {
            txtinfo.Enabled = !txtinfo.Enabled;
        }
    }
    }

