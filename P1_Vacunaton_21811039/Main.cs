﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

 

        private void Main_Load_1(object sender, EventArgs e)
        {
            try
            {

                Menu menu_ = new Menu();
                menu_.MdiParent = this;
                menu_.Show();

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }
    }
}
