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
            btnAdminUser.BackColor = Color.FromArgb(18, 83, 198);
            btnAdminVacunas.BackColor = Color.FromArgb(18, 83, 198);
            btnconsultas.BackColor = Color.FromArgb(18, 83, 198);
            btnAdminCiudadanos.BackColor = Color.FromArgb(18, 83, 198);
            btnAdminCentrosAsistencia.BackColor = Color.FromArgb(18, 83, 198);



            switch (m.user_login.rol)
            {
                case "1":
                    break;
                case "2":
                    btnAdminCiudadanos.Visible = false;
                    btnAdminCiudadanos.Enabled = false;
                    break;
                case "3":
                    btnAdminUser.Enabled = false;
                    btnAdminUser.Visible = false;
                    btnAdminCentrosAsistencia.Visible = false;
                    btnAdminCentrosAsistencia.Enabled = false;
                    btnAdminVacunas.Enabled = false;
                    btnAdminVacunas.Visible = false;
                    break;



            }

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
