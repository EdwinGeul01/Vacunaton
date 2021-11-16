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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(16,16,16);
                /*Color.FromArgb(255,49,28);*/
            this.Opacity = 0.95;

            btnlogin.BackColor = Color.FromArgb(97, 174, 68);
            btnexit.BackColor = Color.FromArgb(226, 70, 70);

            txtpass.PasswordChar = '*';

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
