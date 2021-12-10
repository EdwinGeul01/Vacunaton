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
    public partial class CA_Delete : Form
    {
        Conexion cn = new Conexion();
        CentroAsistencia CA;
        Main m;


        public CA_Delete(Main m)
        {
            this.m = m;
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            CA = cn.GetCentroAsistencia(txtid.Text);

            if (CA != null)
            {
                txtnombre.Text = CA.Nombre;
                txtnumeropacientes.Text = CA.numeroPacientes.ToString();
                txtdireccion.Text = CA.direccion;
                txtciudad.Text = CA.ciudad;
                txtcantmedicos.Text = CA.cantMedicos.ToString();
                txtcantenferm.Text = CA.cantEnfermeras.ToString();
                txtdireccion.Text = CA.direccion;
                if (CA.estatus == "PUBLICO") { rbpublic.Checked = true; } else { rbprivado.Checked = true; }
                btneliminar.Enabled = true;

            }
            else
            {
                MessageBox.Show("Centro de Asistencia no encontrado!!");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.DeleteCentroAsistencia(txtid.Text);

                MessageBox.Show("Centro de asistencia Eliminado exitosamente!!");
                btneliminar.Enabled = false;

            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            btneliminar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.Fc.Show_Menu();
        }
    }
}
