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
    public partial class Vacuna_Create : Form
    {

        Conexion cn = new Conexion();
        Main main;
        Vacunas vacuna;
        public Vacuna_Create(Main m)
        {
            main = m;
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            try
            {
                cn.CrearVacuna(
             txtcod.Text,
             txtname.Text,
             txtfabri.Text,
             dpfechaemision.Value,
             dpfechavencimiento.Value,
             txtnlotes.Text,
             rbdonada.Checked ? "DONADA" : "COMPRADA"
             );

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Fc.Show_Menu();
        }
    }
}
