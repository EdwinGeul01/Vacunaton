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

        public Forms_Controller(Main m)
        {
            this.m = m;
        }




        private void close_All_Mdi()
        {
            foreach(var c in m.MdiChildren)
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


        public void Show_User_Menu()
        {
            try
            {
                close_All_Mdi();
                menu_au = new Admin_User(m);
                menu_au.MdiParent = m;
                menu_au.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }



    }
}
