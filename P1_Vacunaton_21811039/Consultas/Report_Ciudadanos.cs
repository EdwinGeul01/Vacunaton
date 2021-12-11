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
    public partial class Report_Ciudadanos : Form
    {
        public Report_Ciudadanos()
        {
            InitializeComponent();
        }

        private void Report_Ciudadanos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.EnfermedadesXCiudadanos' Puede moverla o quitarla según sea necesario.
            this.EnfermedadesXCiudadanosTableAdapter.Fill(this.VacunatonDataSet.EnfermedadesXCiudadanos);
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.EnfermedadesBases' Puede moverla o quitarla según sea necesario.
            this.EnfermedadesBasesTableAdapter.Fill(this.VacunatonDataSet.EnfermedadesBases);
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.Ciudadanos' Puede moverla o quitarla según sea necesario.
            this.CiudadanosTableAdapter.Fill(this.VacunatonDataSet.Ciudadanos);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void cbidname_CheckedChanged(object sender, EventArgs e)
        {
            txtinfo.Enabled = !txtinfo.Enabled;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(cbidname.Checked)
            {
                this.CiudadanosTableAdapter.FillBy(this.VacunatonDataSet.Ciudadanos,txtinfo.Text);
                this.reportViewer1.RefreshReport();

                this.EnfermedadesXCiudadanosTableAdapter.FillBy(this.VacunatonDataSet.EnfermedadesXCiudadanos, txtinfo.Text);
                this.reportViewer2.RefreshReport();
            }
            else
            {

                this.CiudadanosTableAdapter.Fill(this.VacunatonDataSet.Ciudadanos);
                this.reportViewer1.RefreshReport();



                this.EnfermedadesXCiudadanosTableAdapter.Fill(this.VacunatonDataSet.EnfermedadesXCiudadanos);
                this.reportViewer2.RefreshReport();

            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = !panel3.Enabled;
            panel3.Visible = !panel3.Visible;
            panel2.Enabled = !panel2.Enabled;
            panel2.Visible = !panel2.Visible;
        }

       
    }
}
