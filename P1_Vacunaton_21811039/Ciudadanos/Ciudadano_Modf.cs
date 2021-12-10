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
    public partial class Ciudadano_Modf : Form
    {
        Main main;
        Ciudadanos ciudadanoTemp;
        Conexion cn = new Conexion();
        public Ciudadano_Modf(Main m)
        {
            main = m;
            InitializeComponent();
            cbEstadocivil.SelectedIndex = 0;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            lvEnfermedades.Items.Clear();
            ciudadanoTemp = cn.GetCiudadano(txtid.Text);

            if (ciudadanoTemp == null)
            {
                MessageBox.Show("ciudadano no encontrado !!");
                return;
            }

            txtnombre.Text = ciudadanoTemp.nombreCompleto;
            txtdirec.Text = ciudadanoTemp.direccion;
            txttelefono.Text = ciudadanoTemp.telefono;
            if (ciudadanoTemp.genero == "M") { rbmasc.Checked = true; } else { rbfem.Checked = true; };
            dpfechanec.Value = ciudadanoTemp.fechaNacimiento.Value;
            cbEstadocivil.Text = ciudadanoTemp.estadoCivil;

            for (int i = 0; i < ciudadanoTemp.EnfermedadesBases.ToList().Count(); i++)
            {
                lvEnfermedades.Items.Add(ciudadanoTemp.EnfermedadesBases.ToList()[i].nombreEnfermedad);
            }

            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            

            List<string> enfermedades = new List<string>();

            for (int i = 0; i < lvEnfermedades.Items.Count; i++)
            {
                enfermedades.Add(lvEnfermedades.Items[i].ToString());
            }

            cn.ModfCiudadano(txtid.Text, txtnombre.Text, dpfechanec.Value, rbmasc.Checked ? "M" : "F", txttelefono.Text, txtdirec.Text, cbEstadocivil.Text, enfermedades);

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
