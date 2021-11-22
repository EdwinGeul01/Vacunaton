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
        private User_Create user_c;
        private User_Modf user_Modf;
        private User_Delete User_Delete;

        public Forms_Controller(Main m)
        {
            this.m = m;
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

        public void Show_Create_User()
        {
            try
            {
                close_All_Mdi();
                user_c = new User_Create();
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
                user_Modf = new User_Modf();
                user_c.MdiParent = m;
                user_c.Show();

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
                User_Delete = new User_Delete();
                user_c.MdiParent = m;
                user_c.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }
}
