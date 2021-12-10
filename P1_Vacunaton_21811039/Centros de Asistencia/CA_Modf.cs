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
    public partial class CA_Modf : Form
    {
        Conexion cn = new Conexion();
        CentroAsistencia CA;
        Main m;
        public CA_Modf(Main m)
        {
            this.m = m;
            InitializeComponent();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ModfCentroAsistencia(txtid.Text,
                                    txtnombre.Text,
                                    txtdireccion.Text,
                                    txtciudad.Text,
                                    txtnumeropacientes.Text,
                                    txtcantmedicos.Text,
                                    txtcantenferm.Text,
                                    rbpublic.Checked ? "PUBLICO" : "PRIVADO"
                          );


                MessageBox.Show("Centro de Asistencia Modificado Exitosamente!!!");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
            
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
                btnmodificar.Enabled = true;

            }
            else
            {
                MessageBox.Show("Centro de Asistencia no encontrado!!");
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            btnmodificar.Enabled = false;

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            m.Fc.Show_Menu();
        }
    }
}
