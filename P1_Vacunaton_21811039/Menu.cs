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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            button1.Enabled = false;
            button1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("HOLA MUNDO!!");
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}