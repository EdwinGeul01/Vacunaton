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
        Conexion cn;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(16,16,16);
                /*Color.FromArgb(255,49,28);*/
            this.Opacity = 0.95;

            //btnlogin.BackColor = Color.FromArgb(97, 174, 68);
            //btnexit.BackColor = Color.FromArgb(226, 70, 70);

            txtpass.PasswordChar = '*';

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            cn = new Conexion();

            if (cn.Validar_Usuario(txtuser.Text,txtpass.Text))
            {
                Usuario u = cn.Get_User(txtuser.Text);
                Main m = new Main(u,this);
                m.StartPosition = FormStartPosition.CenterScreen;
                m.Show();
                this.Hide();
                this.Enabled = false;
            }else
            {
                MessageBox.Show("usuario o contraseña incorrectos!!");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Sign_Up SignUp_ = new Sign_Up();
            SignUp_.StartPosition = FormStartPosition.CenterScreen;
            SignUp_.Show();
        }
    }
}
