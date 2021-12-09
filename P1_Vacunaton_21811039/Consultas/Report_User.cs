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
    public partial class Report_User : Form
    {
        public Report_User()
        {
            InitializeComponent();
        }

        private void Report_User_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'VacunatonDataSet.roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.VacunatonDataSet.roles);
            // TODO: esta línea de código carga datos en la tabla 'vacunatonDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.UsuarioTableAdapter.Fill(this.VacunatonDataSet.Usuario);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                this.UsuarioTableAdapter.FillBy(this.VacunatonDataSet.Usuario, textBox1.Text);

            }else
            {
                this.UsuarioTableAdapter.Fill(this.VacunatonDataSet.Usuario);
            }
            this.reportViewer1.RefreshReport();
        }




  

        private void UsuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
        }
    }
}
