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
    public partial class Admin_User : Form
    {
        Main m;

        public Admin_User(Main m)
        {
            this.m = m;
            InitializeComponent();
        }

        private void btnreturnmenu_Click(object sender, EventArgs e)
        {
            m.Fc.Show_Menu();
        }
    }
}