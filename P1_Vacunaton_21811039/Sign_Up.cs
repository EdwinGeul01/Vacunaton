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
    public partial class Sign_Up : Form
    {
        Conexion cn = new Conexion();

        public Sign_Up()
        {
            InitializeComponent();   
            
        }
   

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            User_Create_Load();
        }



        private void User_Create_Load()
        {
            foreach (Vacunas v in cn.GetAllVacunas())
            {
                cbvacunas.Items.Add(v.nombre);
            }

            foreach (CentroAsistencia c in cn.GetAllCentroA())
            {
                cbcentro.Items.Add(c.Nombre);
            }

            cbrol.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                cn.CrearUsuario(txtcod.Text,
                    txtpass.Text,
                    txtnumeroid.Text,
                    txtnombre.Text,
                    rbmasc.Checked ? "M" : "F",
                    txtcorreo.Text,
                    txttelefono.Text,
                    (cbrol.SelectedIndex + 1).ToString(),
                    cbcentro.Text,
                    cbvacunas.Text
                    );

                this.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }



}
