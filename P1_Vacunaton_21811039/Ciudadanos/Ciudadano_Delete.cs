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
    public partial class Ciudadano_Delete : Form
    {

        Main main;
        Ciudadanos ciudadanoTemp;
        Conexion cn = new Conexion();
        public Ciudadano_Delete(Main m)
        {
            main = m;
            InitializeComponent();
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
            txtestado.Text = ciudadanoTemp.estadoCivil;

            for (int i = 0; i < ciudadanoTemp.EnfermedadesBases.ToList().Count(); i++)
            {
                lvEnfermedades.Items.Add(ciudadanoTemp.EnfermedadesBases.ToList()[i].nombreEnfermedad);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                cn.EliminarCiudadanos(txtid.Text);

                MessageBox.Show("ciudadano eliminado exitosamente!!");


            }catch(Exception err)
            {


            }
        }
    }
}
