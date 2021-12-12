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
    public partial class Menu_Consultas : Form
    {
        Main Main;
        public Menu_Consultas(Main m)
        {
            Main = m;
            InitializeComponent();
            VerificarTipoUSuario();
        }

        private void VerificarTipoUSuario()
        {
            if(Main.user_login.rol == "2")
            {
                btnuser.Enabled = false;
                btnuser.Visible = false;
                btnConCiud.Enabled = false;
                btnConCiud.Visible = false;
            }
            if (Main.user_login.rol == "3")
            {
                btnuser.Enabled = false;
                btnuser.Visible = false;
                btnCA.Enabled = false;
                btnCA.Visible = false;
                btnVacunas.Enabled = false;
                btnVacunas.Visible = false;

            }
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            Report_User ru = new Report_User();
            ru.Show();
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            Report_CentroA rc = new Report_CentroA();
            rc.Show();
        }


        private void ocultar_opciones()
        {
            btnuser.Enabled = false;
            btnuser.Visible = false;
            btnConCiud.Enabled = false;
            btnConCiud.Visible = false;
            btnCA.Visible = false;
            btnCA.Enabled = false;
            btnVacunas.Enabled = false;
            btnVacunas.Visible = false;
            btnPerVac.Enabled = false;
            btnPerVac.Visible = false;
            btnConsultEnf.Enabled = false;
            btnConsultEnf.Visible = false;
        }


        private void btnPerVac_Click(object sender, EventArgs e)
        {
            ocultar_opciones();
            btnporDosis.Enabled = true;
            btnporDosis.Visible = true;
            btnporfecha.Visible = true;
            btnporfecha.Enabled = true;
            btnporciudadanos.Enabled = true;
            btnporciudadanos.Visible = true;

        }

        private void btnConsultEnf_Click(object sender, EventArgs e)
        {
            Report_Enfermedades rc = new Report_Enfermedades();
            rc.Show();
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            Report_Vacunas rc = new Report_Vacunas();
            rc.Show();
        }

        private void btnConCiud_Click(object sender, EventArgs e)
        {
            Report_Ciudadanos rc = new Report_Ciudadanos();
            rc.Show();
        }

        private void btnreturnmenu_Click(object sender, EventArgs e)
        {
            Main.Fc.Show_Menu();
        }

        private void btnporDosis_Click(object sender, EventArgs e)
        {
            Report_VacunasXCiuda rc = new Report_VacunasXCiuda();
            rc.Show();
        }

        private void btnporfecha_Click(object sender, EventArgs e)
        {
            Report_VacunasXCiuda_F rc = new Report_VacunasXCiuda_F();
            rc.Show();
        }

        private void btnporciudadanos_Click(object sender, EventArgs e)
        {
            Report_VacunasXCiuda_C rc = new Report_VacunasXCiuda_C();
            rc.Show();
        }

        private void Menu_Consultas_Load(object sender, EventArgs e)
        {

        }
    }
}
