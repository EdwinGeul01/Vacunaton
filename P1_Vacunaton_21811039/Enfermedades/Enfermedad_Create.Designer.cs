
namespace P1_Vacunaton_21811039
{
    partial class Enfermedad_Create
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 56);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(263, 20);
            this.txtname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 46;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(9, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 47;
            this.label1.Text = "DESCRIPCION";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(12, 145);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(263, 116);
            this.txtdesc.TabIndex = 48;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(12, 281);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(263, 44);
            this.btncrear.TabIndex = 49;
            this.btncrear.Text = "CREAR";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(12, 331);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(125, 44);
            this.btncancelar.TabIndex = 50;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 52;
            this.label3.Text = "CODIGO";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(12, 97);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(263, 20);
            this.txtcod.TabIndex = 51;
            // 
            // Enfermedad_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Name = "Enfermedad_Create";
            this.Text = "Enfermedad_Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcod;
    }
}