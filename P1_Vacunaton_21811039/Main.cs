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
        //variables globales
        int mov;
        int movX;
        int movY;
        Forms_Controller fc;

        internal Forms_Controller Fc { get => fc; set => fc = value; }

        public Main()
        {
            InitializeComponent();

            fc = new Forms_Controller(this);
            //MainBar.BackColor = Color.FromArgb(9, 7, 0);
            panel_user.BackColor = Color.FromArgb(9, 7, 0);
            MainBar.BackColor = Color.FromArgb(0, 0, 51);

        }

    







        private void Main_Load_1(object sender, EventArgs e)
        {
            fc.Show_Menu();
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
            Application.Exit();
        }
    }
}
