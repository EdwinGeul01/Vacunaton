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
            m.Fc.Show_User_Menu();
        }


        ~Menu()
        {
            MessageBox.Show("destruido");
        }

    }
}
