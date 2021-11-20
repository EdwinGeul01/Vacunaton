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
        public Main()
        {
            InitializeComponent();
            MainBar.BackColor = Color.FromArgb(9, 7, 0);
            panel_user.BackColor = Color.FromArgb(9, 7, 0);

        }

        int mov;
        int movX;
        int movY;



        private void Main_Load_1(object sender, EventArgs e)
        {
            try
            {
                Menu menu_ = new Menu();
                menu_.MdiParent = this;
                menu_.Show();

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }

 

        private void MainBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
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
    }
}
