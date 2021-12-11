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
    public partial class Enfermedad_Create : Form
    {
        Enfermedades_list Enf_List;
        Conexion cn = new Conexion();

        public Enfermedad_Create(Enfermedades_list Enf_L)
        {
            Enf_List = Enf_L;
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (txtcod.Text == "")
            {
                MessageBox.Show("codigo no puede ser nulo!");
                return;
            }
            try
            {
                cn.CrearEnfermedades(txtcod.Text, txtname.Text, txtdesc.Text);
                Enf_List.Load_Enfermedades();
                this.Close();

            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
