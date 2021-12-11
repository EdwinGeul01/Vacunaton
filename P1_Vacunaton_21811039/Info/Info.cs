using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P1_Vacunaton_21811039
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Info_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("../../resources/BaseDatos.txt", true);
                string texto = sr.ReadToEnd();

                txtbd.Text = texto;
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
      
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
