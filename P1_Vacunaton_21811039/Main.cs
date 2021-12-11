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


    public partial class Main : Form
    {

        public Usuario user_login;

        //variables globales
        int mov;
        int movX;
        int movY;
        Forms_Controller fc;
        public Login log;

        internal Forms_Controller Fc { get => fc; set => fc = value; }

        public Main(Usuario u , Login l)
        {
            InitializeComponent();

            fc = new Forms_Controller(this);
            //MainBar.BackColor = Color.FromArgb(9, 7, 0);
            //panel_user.BackColor = Color.FromArgb(9, 7, 0);
            MainBar.BackColor = Color.FromArgb(230, 230, 230);
            user_login = u;
            log = l;

            lblnombre.Text = user_login.NombreCompleto;
            Config_TypeUser();
            
        }

    


        private void Config_TypeUser()
        {
            switch(user_login.rol)
            {
                case "1":
                    lbltipodeuser.Text = "ADMINISTRADOR";
                    panel_user.BackColor = Color.Crimson;
                    break;
                case "2":
                    lbltipodeuser.Text = "OFICIAL MEDICO";
                    panel_user.BackColor = Color.Green;
                    break;
                case "3":
                    lbltipodeuser.Text = "DIGITADOR";
                    panel_user.BackColor = Color.Yellow;
                    break;

            }
        }




        private void Main_Load_1(object sender, EventArgs e)
        {
            fc.Show_Menu();
            fc.removeborder();

        }



        private void MainBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X + panel_user.Width;
            movY = e.Y;
        }

        private void MainBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void MainBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void MainBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btngohome_Click(object sender, EventArgs e)
        {
            Fc.Show_Menu();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            log.Enabled = true;
            log.Visible = true;

            this.Close();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            Info infor = new Info();
            infor.Show();
        }
    }
}
