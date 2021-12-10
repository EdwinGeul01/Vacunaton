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
    public partial class Vacuna_Modf : Form
    {
        Conexion cn = new Conexion();
        Main main;
        Vacunas vacuna;
        public Vacuna_Modf(Main m)
        {
            main = m;
            InitializeComponent();
        }

        private void Vacuna_Modf_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            vacuna = cn.Getvacuna(txtcod.Text);

            if (vacuna != null)
            {

                txtnombre.Text = vacuna.nombre;
                txtfabricante.Text = vacuna.fabricante;
                txtnumerolotes.Text = vacuna.numerolote;
                dpfechaemision.Value = vacuna.fechaEmision.Value;
                dpfechavencimiento.Value = vacuna.fechaVencimiento.Value;

                if (vacuna.estatus == "DONADA") { rbdonada.Checked = true;  } else { rbcomprada.Checked = true; };

                btnmodf.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vacuna no encontrada!!");
            }

        }

        private void btnmodf_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ModificarVacuna(txtcod.Text, txtnombre.Text, txtfabricante.Text, dpfechaemision.Value, dpfechavencimiento.Value, txtnumerolotes.Text,
                                rbdonada.Checked == true ? rbdonada.Text : rbcomprada.Text);

                MessageBox.Show("Vacuna modificada");
            }catch(Exception err)
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
