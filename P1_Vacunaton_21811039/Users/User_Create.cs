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
    public partial class User_Create : Form
    {
        Main main;
        Conexion cn = new Conexion();
        public User_Create(Main m)
        {
            main = m;
            InitializeComponent();
        }

        private void lbldirectory_Click(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if(txtcod.Text == "")
            {
                MessageBox.Show("id no puede ser nulo!");
                return;
            }

            try
            {
                cn.CrearUsuario(txtcod.Text,
                    txtpass.Text,
                    txtnidentidad.Text,
                    txtnombre.Text,
                    rbmasc.Checked ? "M" : "F",
                    txtcorreo.Text,
                    txttelefono.Text,
                    (cbrol.SelectedIndex + 1).ToString(),
                    cbCentrovacunas.Text,
                    cbvacunas.Text
                    );


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            
        }

        private void User_Create_Load(object sender, EventArgs e)
        {
           foreach(Vacunas v in cn.GetAllVacunas())
            {
                cbvacunas.Items.Add(v.nombre);
            }

           foreach(CentroAsistencia c in cn.GetAllCentroA())
            {
                cbCentrovacunas.Items.Add(c.Nombre);
            }

            cbrol.SelectedIndex = 0;



            if(main.user_login.rol == "2")
            {
                cbrol.SelectedIndex = 2;
                cbrol.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Fc.Show_Menu();
        }
    }
}
