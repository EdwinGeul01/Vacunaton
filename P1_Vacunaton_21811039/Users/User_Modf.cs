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
    public partial class User_Modf : Form
    {
        Conexion cn = new Conexion();
        Main Main;
        Usuario user;
        public User_Modf(Main m)
        {
            Main = m;
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            user = cn.Get_User(txtcod.Text);
            if(user != null)
            {

                if(user.rol != "3" && Main.user_login.rol == "2")
                {
                    MessageBox.Show("No tiene autorizacion para editar este usuario!!");
                    return;
                }

                txtnombre.Text = user.NombreCompleto;
                txtpass.Text = user.contraseña;
                txtnidentidad.Text = user.n_identidad;
                txttelefono.Text = user.telefono;
                txtcorreo.Text = user.correo;
                cbrol.Text = user.roles != null ? user.roles.rol : "";
                cbvacunasE.Text = user.Vacunas != null ? user.Vacunas.nombre : "";
                cbcentroA.Text = user.CentroAsistencia != null ? user.CentroAsistencia.Nombre : "";

                if (user.genero == "M") { rbmasc.Checked = true; }else{ rbfemn.Checked = true; }
                btnmodf.Enabled = true;

            }
            else
            {
                MessageBox.Show("Usuario no encontrado!!");
            }
        }

        private void btnmodf_Click(object sender, EventArgs e)
        {
            try
            {
                //user.NombreCompleto = txtnombre.Text;
                //user.contraseña = txtpass.Text;
                //user.n_identidad = txtnidentidad.Text;
                //user.telefono = txttelefono.Text;
                //user.rol = cbrol.SelectedIndex.ToString();
                //user.IdCentroAsistencia = cbcentroA.SelectedIndex.ToString();
                //user.IdVacunas = cbvacunasE.SelectedIndex.ToString();
                //user.genero =rbmasc.Checked?"M":"F";

                cn.ModfUsuario(txtcod.Text, txtpass.Text, txtnidentidad.Text, txtnombre.Text, rbmasc.Checked ? "M" : "F", txtcorreo.Text, txttelefono.Text,
                               (cbrol.SelectedIndex + 1).ToString(), cbcentroA.Text, cbvacunasE.Text);

                MessageBox.Show("Usuario modificado!!");
                clear_form();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            btnmodf.Enabled = false;
            clear_form();
        }


        private void clear_form()
        {
            txtcorreo.Clear();
            txtnidentidad.Clear();
            txtnombre.Clear();
            txtpass.Clear();
            txttelefono.Clear();
            cbrol.SelectedIndex = -1;
            cbcentroA.SelectedIndex = -1;
            cbvacunasE.SelectedIndex = -1;
        }

        private void User_Modf_Load(object sender, EventArgs e)
        {
            foreach (Vacunas v in cn.GetAllVacunas())
            {
                cbvacunasE.Items.Add(v.nombre);
            }

            foreach (CentroAsistencia c in cn.GetAllCentroA())
            {
                cbcentroA.Items.Add(c.Nombre);
            }

            if (Main.user_login.rol == "2")
            {
                cbrol.SelectedIndex = 2;
                cbrol.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.Fc.Show_Menu();
        }
    }
}
