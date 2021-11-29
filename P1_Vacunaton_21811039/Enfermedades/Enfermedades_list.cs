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
    public partial class Enfermedades_list : Form
    {
        Conexion cn = new Conexion();
        CheckedListBox Lv_ref;
        public Enfermedades_list(CheckedListBox t)
        {
            Lv_ref = t;
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Enfermedad_Create enfermedad_Create = new Enfermedad_Create(this);
            enfermedad_Create.Show();
        }

        private void Enfermedades_list_Load(object sender, EventArgs e)
        {
            Load_Enfermedades();
            Load_CheckEnfermedades();
        }

        private void Load_CheckEnfermedades()
        {
            int count;
            for (int i = 0; i < Lv_ref.Items.Count; i++)
            {
                 count = 0;
                for (int j = 0; j < ClistEnf.Items.Count; j++)
                {
                    if ( Lv_ref.Items[i].ToString() == ClistEnf.Items[j].ToString())
                    {
                        ClistEnf.SetItemChecked(count, true) ;
                    }
                    count++;
                }
            }

        }

        public void Load_Enfermedades()
        {
            ClistEnf.Items.Clear();
           foreach(EnfermedadesBases e in cn.GetAllEnfermedades())
            {
                ClistEnf.Items.Add(e.nombreEnfermedad);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            List<string> enfermedades_borrar = new List<string>();

            foreach(var i in ClistEnf.CheckedItems)
            {
                enfermedades_borrar.Add(i.ToString());
            }

            cn.Delete_Enfermedades(enfermedades_borrar);
            Load_Enfermedades();
            Load_CheckEnfermedades();
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            Lv_ref.Items.Clear();
            foreach (var i in ClistEnf.CheckedItems)
            {
                Lv_ref.Items.Add(i);

            }
            for(int  i  = 0; i < Lv_ref.Items.Count; i++)
            {
                Lv_ref.SetItemChecked(i, true);
            }
            this.Close();
        }
    }
}
