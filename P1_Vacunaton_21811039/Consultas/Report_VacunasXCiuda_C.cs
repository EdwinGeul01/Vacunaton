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
    public partial class Report_VacunasXCiuda_C : Form
    {
        public Report_VacunasXCiuda_C()
        {
            InitializeComponent();
        }

        private void Report_VacunasXCiuda_C_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.VacunaXCiudadanos' Puede moverla o quitarla según sea necesario.
            this.VacunaXCiudadanosTableAdapter.Fill(this.VacunatonDataSet.VacunaXCiudadanos);
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.Ciudadanos' Puede moverla o quitarla según sea necesario.
            this.CiudadanosTableAdapter.Fill(this.VacunatonDataSet.Ciudadanos);
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.Vacunas' Puede moverla o quitarla según sea necesario.
            this.VacunasTableAdapter.Fill(this.VacunatonDataSet.Vacunas);
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.CentroAsistencia' Puede moverla o quitarla según sea necesario.
            this.CentroAsistenciaTableAdapter.Fill(this.VacunatonDataSet.CentroAsistencia);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void cbid_CheckedChanged(object sender, EventArgs e)
        {
            cbdosis.Checked = false;
            cbfecha.Checked = false;
        }

        private void cbdosis_CheckedChanged(object sender, EventArgs e)
        {
            cbfecha.Checked = false;
            cbid.Checked = false;
        }

        private void cbfecha_CheckedChanged(object sender, EventArgs e)
        {
            cbdosis.Checked = false;
            cbid.Checked = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {

                var temp = this.VacunatonDataSet.VacunaXCiudadanos;
                if (cbid.Checked)
                {
                    VacunaXCiudadanosTableAdapter.GetById(temp, txtid.Text);
                    temp = VacunaXCiudadanosTableAdapter.GetData();
                }


                if (cbdosis.Checked)
                {
                    VacunaXCiudadanosTableAdapter.FindDosis(temp, Convert.ToInt32(txtdosis.Text));
                    temp = VacunaXCiudadanosTableAdapter.GetData();
                }


                if (cbfecha.Checked)
                {
                    VacunaXCiudadanosTableAdapter.FindByDate(temp, dpfechaapli.Value.ToString());
                    temp = VacunaXCiudadanosTableAdapter.GetData();
                }
                this.VacunaXCiudadanosTableAdapter.Fill(temp);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }
    }
}
