
namespace P1_Vacunaton_21811039
{
    partial class Enfermedades_list
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClistEnf = new System.Windows.Forms.CheckedListBox();
            this.btnfinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClistEnf
            // 
            this.ClistEnf.FormattingEnabled = true;
            this.ClistEnf.Location = new System.Drawing.Point(12, 132);
            this.ClistEnf.Name = "ClistEnf";
            this.ClistEnf.Size = new System.Drawing.Size(469, 394);
            this.ClistEnf.TabIndex = 0;
            // 
            // btnfinish
            // 
            this.btnfinish.Location = new System.Drawing.Point(365, 532);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(107, 26);
            this.btnfinish.TabIndex = 1;
            this.btnfinish.Text = "TERMINAR";
            this.btnfinish.UseVisualStyleBackColor = true;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE ENFERMEDADES BASE";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(194, 54);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(287, 26);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "AGREGAR NUEVA ENFERMEDAD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(194, 86);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(287, 26);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "ELIMINAR ENFERMEDADES SELECCIONADAS";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Enfermedades_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 565);
            this.ControlBox = false;
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfinish);
            this.Controls.Add(this.ClistEnf);
            this.Name = "Enfermedades_list";
            this.Text = "Enfermedades_list";
            this.Load += new System.EventHandler(this.Enfermedades_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClistEnf;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
    }
}