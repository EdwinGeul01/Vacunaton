﻿using System;
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
    public partial class Report_Vacunas : Form
    {
        public Report_Vacunas()
        {
            InitializeComponent();
        }

        private void Report_Vacunas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.Vacunas' Puede moverla o quitarla según sea necesario.
            this.VacunasTableAdapter.Fill(this.VacunatonDataSet.Vacunas);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void cbidname_CheckedChanged(object sender, EventArgs e)
        {
            txtinfo.Enabled = !txtinfo.Enabled;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cbidname.Checked)
            {
                this.VacunasTableAdapter.FillBy(this.VacunatonDataSet.Vacunas, txtinfo.Text);
                this.reportViewer1.RefreshReport();

            }
            else
            {
                this.VacunasTableAdapter.Fill(this.VacunatonDataSet.Vacunas);

                this.reportViewer1.RefreshReport();

            }
        }

      
    }
}
