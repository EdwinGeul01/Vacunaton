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
    public partial class CA_Create : Form
    {
        Conexion cn = new Conexion();

        public CA_Create()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {

            try
            {
                cn.CrearCentroAsistencia(
                txtid.Text,
                txtnombre.Text,
               txtdireccion.Text,
               txtciudad.Text,
               txtnumeropacientes.Text,
               txtcantmedicos.Text,
               txtcantenfermeras.Text,
               rbpublic.Checked ? "PUBLICO" : "PRIVADO"

             );


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
