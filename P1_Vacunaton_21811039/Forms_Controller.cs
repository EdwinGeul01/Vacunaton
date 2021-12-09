using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Vacunaton_21811039
{
    class Forms_Controller
    {
        private Main m;
        private Admin_User menu_au;
        private Menu menu_;

        //usuarios
        private User_Create user_c;
        private User_Modf user_Modf;
        private User_Delete User_Delete;

        //centro de asistencia
        private CA_Create ca_create;
        private CA_Modf ca_Modf;
        private CA_Delete ca_Delete;

        //vacunas
        private Vacuna_Create va_create;
        private Vacuna_Modf va_modf;
        private Vacuna_Delete va_delt;


        //ciudadanos
        private Ciudadano_Create ci_create;
        private Ciudadano_Modf ci_modf;
        private Ciudadano_Delete ci_delete;

        //aplicar vacunas
        private AplicarVacuna AplicarVacuna;
        private Delete_RegVac DeleteAplicarVacuna;

        public Forms_Controller(Main m)
        {
            this.m = m;
        }


        public void removeborder()
        {

            MdiChanges.removeborders(ref m);
        }


        private void close_All_Mdi()
        {
            foreach (var c in m.MdiChildren)
            {
                c.Close();

            }

        }


        public void Show_Menu()
        {
            try
            {
                close_All_Mdi();
                menu_ = new Menu(m);
                menu_.MdiParent = m;
                menu_.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        public void Show_Option_Menu(int i)
        {
            try
            {
                close_All_Mdi();
                menu_au = new Admin_User(m, i);
                menu_au.MdiParent = m;
                menu_au.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }



        //USUARIOS METODOS
        public void Show_Create_User()
        {
            try
            {
                close_All_Mdi();
                user_c = new User_Create(m);
                user_c.MdiParent = m;
                user_c.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Show_Modf_User()
        {
            try
            {
                close_All_Mdi();
                user_Modf = new User_Modf(m);
                user_Modf.MdiParent = m;
                user_Modf.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Show_Delete_User()
        {
            try
            {
                close_All_Mdi();
                User_Delete = new User_Delete(m);
                User_Delete.MdiParent = m;
                User_Delete.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        //CENTRO DE ASISTENCIA METODOS
        public void Show_Create_CentroDeAsistencia()
        {
            try
            {
                close_All_Mdi();
                ca_create = new CA_Create();
                ca_create.MdiParent = m;
                ca_create.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        public void Show_Modf_CentroDeAsistencia()
        {
            try
            {
                close_All_Mdi();
                ca_Modf = new CA_Modf();
                ca_Modf.MdiParent = m;
                ca_Modf.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Show_Delete_CentroDeAsistencia()
        {
            try
            {
                close_All_Mdi();
                ca_Delete = new CA_Delete();
                ca_Delete.MdiParent = m;
                ca_Delete.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        //VACUNAS
        public void Show_Create_vacuna()
        {
            try
            {
                close_All_Mdi();
                va_create = new Vacuna_Create();
                va_create.MdiParent = m;
                va_create.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        public void Show_Modf_vacuna()
        {
            try
            {
                close_All_Mdi();
                va_modf = new Vacuna_Modf();
                va_modf.MdiParent = m;
                va_modf.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Show_Delete_vacuna()
        {
            try
            {
                close_All_Mdi();
                va_delt = new Vacuna_Delete();
                va_delt.MdiParent = m;
                va_delt.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        //CIUDADANOS

        public void Show_Create_Ciudadanos()
        {
            try
            {
                close_All_Mdi();
                ci_create = new Ciudadano_Create(m);
                ci_create.MdiParent = m;
                ci_create.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Show_Modf_Ciudadanos()
        {
            try
            {
                close_All_Mdi();
                ci_modf = new Ciudadano_Modf(m);
                ci_modf.MdiParent = m;
                ci_modf.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Show_Delete_Ciudadanos()
        {
            try
            {
                close_All_Mdi();
                ci_delete = new Ciudadano_Delete(m);
                ci_delete.MdiParent = m;
                ci_delete.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //CIUDADANOS X VACUNA

        public void Show_AplicarVacuna()
        {


            try
            {
                close_All_Mdi();
                AplicarVacuna = new AplicarVacuna(m);
                AplicarVacuna.MdiParent = m;
                AplicarVacuna.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void Show_DeleteAplicarVacuna()
        {
              try
            {
                close_All_Mdi();
                DeleteAplicarVacuna = new Delete_RegVac(m);
                DeleteAplicarVacuna.MdiParent = m;
                DeleteAplicarVacuna.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //consultas menu
        public void Show_ConsultasMenu()
        {
            try
            {
                close_All_Mdi();
                Menu_Consultas MConsult = new Menu_Consultas(m);
                MConsult.MdiParent = m;
                MConsult.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
