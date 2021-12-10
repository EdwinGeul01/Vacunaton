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
    public partial class Delete_RegVac : Form
    {
        Main m;
        Conexion cn = new Conexion();

        public Delete_RegVac(Main m)
        {
            this.m = m;
            InitializeComponent();
        }

        private void Delete_RegVac_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.VacunaXCiudadanos' Puede moverla o quitarla según sea necesario.
            this.VacunaXCiudadanosTableAdapter.Fill(this.VacunatonDataSet.VacunaXCiudadanos);
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.Ciudadanos' Puede moverla o quitarla según sea necesario.
            this.CiudadanosTableAdapter.Fill(this.VacunatonDataSet.Ciudadanos);
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.Vacunas' Puede moverla o quitarla según sea necesario.
            this.VacunasTableAdapter.Fill(this.VacunatonDataSet.Vacunas);
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.CentroAsistencia' Puede moverla o quitarla según sea necesario.
            this.CentroAsistenciaTableAdapter.Fill(this.VacunatonDataSet.CentroAsistencia);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            VacunaXCiudadanosTableAdapter.GetById(this.VacunatonDataSet.VacunaXCiudadanos, txtcod.Text);
            this.reportViewer1.RefreshReport();
        }

        private void cball_CheckedChanged(object sender, EventArgs e)
        {
            txtndosis.Enabled = !txtndosis.Enabled;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (!cball.Checked)
            { 
            cn.EliminarVacunaXCiudadano(txtcod.Text, txtndosis.Text);
            }
            else
            {
                cn.EliminarVacunaXCiudadano(txtcod.Text, "ALL");
            }
            VacunaXCiudadanosTableAdapter.GetById(this.VacunatonDataSet.VacunaXCiudadanos, txtcod.Text);
            this.reportViewer1.RefreshReport();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            m.Fc.Show_Menu();

        }
    }
}
