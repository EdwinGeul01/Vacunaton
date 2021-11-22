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
            cn.CrearUsuario(txtcod.Text,
                txtpass.Text,
                txtnidentidad.Text,
                txtnombre.Text,
                "M",
                txtcorreo.Text,
                txttelefono.Text,
                cbrol.Text, cbCentrovacunas.Text,
                cbvacunas.Text
                );
        }
    }
}
