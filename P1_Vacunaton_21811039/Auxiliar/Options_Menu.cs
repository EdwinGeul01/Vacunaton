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
    public partial class Admin_User : Form
    {
        Main m;
        int option;

        public Admin_User(Main m,int i)
        {
            this.m = m;
            this.option = i;
            InitializeComponent();
            set_values();
        }


        private void set_values()
        {
            switch (option)
            {
                case 1:
                    lbldirectory.Text = "                       OPCIONES  -  ADMINISTRAR USUARIOS               ";
                    lbltitle.Text = "USUARIOS          ";
                    panelimagesection.BackgroundImage = global::P1_Vacunaton_21811039.Properties.Resources.users_resize;
                    break;
                case 2:
                    lbldirectory.Text = "                       OPCIONES  -  ADMINISTRAR VACUNAS               ";
                    lbltitle.Text = "VACUNAS          ";
                    panelimagesection.BackgroundImage = global::P1_Vacunaton_21811039.Properties.Resources.vacunas;
                    break;
                case 3:
                    lbldirectory.Text = "                       OPCIONES  -  ADMINISTRAR CENTROS DE ASISTENCIA               ";
                    lbltitle.Text = "CENTROS DE ASISTENCIA          ";
                    panelimagesection.BackgroundImage = global::P1_Vacunaton_21811039.Properties.Resources.centros_de_asistencia_;
                    break;
                case 4:
                    lbldirectory.Text = "                       OPCIONES  -  ADMINISTRAR CIUDADANOS               ";
                    lbltitle.Text = "CIUDADANOS          ";
                    panelimagesection.BackgroundImage = global::P1_Vacunaton_21811039.Properties.Resources.ciudadanosR;
                    break;
 
            }
        }

        private void btnreturnmenu_Click(object sender, EventArgs e)
        {
            m.Fc.Show_Menu();
        }

        private void Admin_User_Load(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case 1:
                    m.Fc.Show_Create_User();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case 1:
                    m.Fc.Show_Modf_User();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case 1:
                    m.Fc.Show_Delete_User();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;

            }
        }
    }
}
