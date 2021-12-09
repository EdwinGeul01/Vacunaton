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
    public partial class Report_VacunasXCiuda_F : Form
    {
        public Report_VacunasXCiuda_F()
        {
            InitializeComponent();
        }

        private void Report_VacunasXCiuda_F_Load(object sender, EventArgs e)
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
    }
}
