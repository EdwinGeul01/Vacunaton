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
    public partial class User_Delete : Form
    {
        Conexion cn = new Conexion();
        Main main;
        Usuario user;

        public User_Delete(Main m)
        {
            main = m;
            InitializeComponent();
            txtcod.Enabled = true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            user = cn.Get_User(txtcod.Text);
            if (user != null )
            {

                if (user.rol != "3" && main.user_login.rol == "2")
                {
                    MessageBox.Show("No tiene autorizacion para Eliminar este usuario!!");
                    return;
                }

                txtnombre.Text = user.NombreCompleto;
                txtpass.Text = user.contraseña;
                txtnident.Text = user.n_identidad;
                txttelefono.Text = user.telefono;
                txtcorreo.Text = user.correo;
                txtrol.Text = user.roles != null ? user.roles.rol : "";
           
                    txtvacunasEncrg.Text = user.Vacunas != null ? user.Vacunas.nombre : "";
                txtCA.Text = user.CentroAsistencia != null ? user.CentroAsistencia.Nombre : "";



                if (user.genero == "M") { rbmasc.Checked = true; } else { rbfemn.Checked = true; }
                btneliminar.Enabled = true;

            }
            else
            {
                MessageBox.Show("Usuario no encontrado!!");
            }
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            btneliminar.Enabled = false;
        }


        private void clear_form()
        {
            txtcorreo.Clear();
            txtnident.Clear();
            txtnombre.Clear();
            txtpass.Clear();
            txttelefono.Clear();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

                cn.DeleteUsuario(txtcod.Text);

                MessageBox.Show("Usuario Elminado!!");
                clear_form();
                btneliminar.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void User_Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
