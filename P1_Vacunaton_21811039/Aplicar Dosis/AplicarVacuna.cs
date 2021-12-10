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
    public partial class AplicarVacuna : Form
    {
        Main main;
        Conexion cn = new Conexion();
        VacunaXCiudadanos VxC;
        Ciudadanos Ciudadano;
        public AplicarVacuna(Main m)
        {
            main = m;

            InitializeComponent();
        }

        private void AplicarVacuna_Load(object sender, EventArgs e)
        {
            foreach (Vacunas v in cn.GetAllVacunas())
            {
                cbvacunasE.Items.Add(v.nombre);
            }

            foreach (CentroAsistencia c in cn.GetAllCentroA())
            {
                cbCentrovacunas.Items.Add(c.Nombre);
            }




            cbvacunasE.SelectedIndex = 0;
            cbCentrovacunas.SelectedIndex = 0;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
             VxC = cn.GetVacunasXCiudadanos4id(txtcod.Text);
            Ciudadano = cn.GetCiudadano(txtcod.Text);

            if(Ciudadano == null)
            {
                MessageBox.Show("no se encontro al ciudadano!!");
                return;
            }

            btnaplicar.Enabled = true;

            if(VxC == null)
            {
                txtndosis.Text  = "1";
                return;

            }

            
            txtndosis.Text = (Convert.ToInt32(VxC.NumeroDosis) + 1).ToString();
            
            

        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            
            if(txtndosis.Text != "1")
            {
                if ((dpfechaapli.Value - VxC.Fecha_Aplicacion.Value).TotalDays >= 60  )
                {
                    cn.CrearVacunaXCiudadano(txtcod.Text, txtndosis.Text, cbCentrovacunas.Text, cbvacunasE.Text, dpfechaapli.Value);
                    btnaplicar.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("falta tiempo para esta aplicacion!!");
                    btnaplicar.Enabled = false;

                    return;
                }

            }


            cn.CrearVacunaXCiudadano(txtcod.Text, txtndosis.Text, cbCentrovacunas.Text, cbvacunasE.Text, dpfechaapli.Value);
            btnaplicar.Enabled = false;



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            main.Fc.Show_Menu();
        }
    }
}
