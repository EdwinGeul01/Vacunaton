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
    public partial class Vacuna_Delete : Form
    {
        Conexion cn = new Conexion();
        Main main;
        Vacunas vacuna;
        public Vacuna_Delete(Main m)
        {
            main = m;
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            vacuna = cn.Getvacuna(txtcod.Text);

            if (vacuna != null)
            {

                txtnombre.Text = vacuna.nombre;
                txtfabricante.Text = vacuna.fabricante;
                txtnumerolotes.Text = vacuna.numerolote;
                dpfechae.Value = vacuna.fechaEmision.Value;
                dpfechav.Value = vacuna.fechaVencimiento.Value;

                if (vacuna.estatus == "DONADA") { rbdonada.Checked = true; } else { rbcomprada.Checked = true; };

                btneliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vacuna no encontrada!!");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                cn.DeleteVacuna(txtcod.Text);

                MessageBox.Show("Vacuna Elminado!!");
                clear_form();
                btneliminar.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void clear_form()
        {
            txtcod.Clear();
            txtfabricante.Clear();
            txtnombre.Clear();
            txtnumerolotes.Clear();
            btneliminar.Enabled = false;

        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            btneliminar.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Fc.Show_Menu();
        }
    }
}
