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
    public partial class Menu : Form
    {
        Main m;
        public Menu(Main m )
        {
            this.m = m;
            InitializeComponent();
            //button1.Enabled = false;
            //button1.Visible = false;
        }



        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminUser_Click(object sender, EventArgs e)
        {
            m.Fc.Show_Option_Menu(1);
        }


        ~Menu()
        {
            MessageBox.Show("destruido");
        }

        private void btnAdminVacunas_Click(object sender, EventArgs e)
        {
           m.Fc.Show_Option_Menu(2);
        }

        private void btnAdminCentrosAsistencia_Click(object sender, EventArgs e)
        {
            m.Fc.Show_Option_Menu(3);
        }

        private void btnAdminCiudadanos_Click(object sender, EventArgs e)
        {
            m.Fc.Show_Option_Menu(4);
        }
    }
}
