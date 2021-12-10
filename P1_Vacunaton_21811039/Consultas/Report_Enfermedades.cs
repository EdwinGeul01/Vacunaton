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
    public partial class Report_Enfermedades : Form
    {
        public Report_Enfermedades()
        {
            InitializeComponent();
        }

        private void Report_Enfermedades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.EnfermedadesBases' Puede moverla o quitarla según sea necesario.
            this.EnfermedadesBasesTableAdapter.Fill(this.VacunatonDataSet.EnfermedadesBases);

            this.reportViewer1.RefreshReport();
        }

        private void cbidname_CheckedChanged(object sender, EventArgs e)
        {
            txtinfo.Enabled = !txtinfo.Enabled;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           if(cbidname.Checked)
            {
                this.EnfermedadesBasesTableAdapter.FillBy(this.VacunatonDataSet.EnfermedadesBases,txtinfo.Text);
                this.reportViewer1.RefreshReport();

            }
            else
            {
                this.EnfermedadesBasesTableAdapter.Fill(this.VacunatonDataSet.EnfermedadesBases);

                this.reportViewer1.RefreshReport();

            }
        }
    }
}
