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
    public partial class Ciudadano_Create : Form
    {
        Main main;
        Conexion cn = new Conexion();
        public Ciudadano_Create(Main m)
        {
            main = m;
            InitializeComponent();
            cbEstadocivil.SelectedIndex = 0;
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> enfermedades = new List<string>();

                for(int i = 0; i < lvEnfermedades.Items.Count;i++)
                {
                    enfermedades.Add(lvEnfermedades.Items[i].ToString());
                }

                cn.CrearCiudadano(txtid.Text, txtname.Text, dpFechanacimiento.Value,
                    rbmasc.Checked ? "M" : "F", txttelefono.Text, txtdireccion.Text, cbEstadocivil.Text,enfermedades);




            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
       
        
        }

        private void btnAgregarenfermedad_Click(object sender, EventArgs e)
        {
            Enfermedades_list EFL = new Enfermedades_list(lvEnfermedades);
            EFL.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
           main.Fc.Show_Menu();
        }
    }
}
