
namespace P1_Vacunaton_21811039
{
    partial class Ciudadano_Create
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.cbEstadocivil = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.rbfem = new System.Windows.Forms.RadioButton();
            this.rbmasc = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbldirectory = new System.Windows.Forms.Label();
            this.dpFechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarenfermedad = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvEnfermedades = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Location = new System.Drawing.Point(47, 473);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(256, 38);
            this.btncancelar.TabIndex = 64;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.Location = new System.Drawing.Point(47, 411);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(256, 56);
            this.btncrear.TabIndex = 63;
            this.btncrear.Text = "CREAR";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // cbEstadocivil
            // 
            this.cbEstadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadocivil.FormattingEnabled = true;
            this.cbEstadocivil.Items.AddRange(new object[] {
            "SOLTERO",
            "CASADO",
            "DIVORCIADO",
            "SEPARACION EN PROCESO JUDICIAL",
            "VIUDO",
            "CONCUBINATO"});
            this.cbEstadocivil.Location = new System.Drawing.Point(354, 113);
            this.cbEstadocivil.Name = "cbEstadocivil";
            this.cbEstadocivil.Size = new System.Drawing.Size(221, 21);
            this.cbEstadocivil.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(351, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 14);
            this.label9.TabIndex = 57;
            this.label9.Text = "ESTADO CIVIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(47, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 56;
            this.label8.Text = "TELEFONO";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(47, 253);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(203, 20);
            this.txttelefono.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(47, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 54;
            this.label6.Text = "DIRECCION";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(47, 369);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(268, 20);
            this.txtdireccion.TabIndex = 53;
            // 
            // rbfem
            // 
            this.rbfem.AutoSize = true;
            this.rbfem.Location = new System.Drawing.Point(160, 319);
            this.rbfem.Name = "rbfem";
            this.rbfem.Size = new System.Drawing.Size(81, 17);
            this.rbfem.TabIndex = 52;
            this.rbfem.Text = "FEMENINO";
            this.rbfem.UseVisualStyleBackColor = true;
            // 
            // rbmasc
            // 
            this.rbmasc.AutoSize = true;
            this.rbmasc.Checked = true;
            this.rbmasc.Location = new System.Drawing.Point(44, 319);
            this.rbmasc.Name = "rbmasc";
            this.rbmasc.Size = new System.Drawing.Size(88, 17);
            this.rbmasc.TabIndex = 51;
            this.rbmasc.TabStop = true;
            this.rbmasc.Text = "MASCULINO";
            this.rbmasc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(44, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 50;
            this.label5.Text = "GENERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(47, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 14);
            this.label3.TabIndex = 47;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(47, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 45;
            this.label2.Text = "NOMBRE";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(47, 157);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(204, 20);
            this.txtname.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(47, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 14);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(47, 115);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(204, 20);
            this.txtid.TabIndex = 42;
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitle.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(43, 62);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(688, 21);
            this.lbltitle.TabIndex = 41;
            this.lbltitle.Text = "CREAR CIUDADANO         ";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbldirectory
            // 
            this.lbldirectory.BackColor = System.Drawing.Color.LightGray;
            this.lbldirectory.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldirectory.Location = new System.Drawing.Point(4, 28);
            this.lbldirectory.Name = "lbldirectory";
            this.lbldirectory.Size = new System.Drawing.Size(776, 21);
            this.lbldirectory.TabIndex = 39;
            this.lbldirectory.Text = "                       OPCIONES  -  ADMINISTRAR USUARIOS - CREAR CIUDADANO       " +
    "       ";
            this.lbldirectory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dpFechanacimiento
            // 
            this.dpFechanacimiento.CustomFormat = "dd/MM/yyy";
            this.dpFechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechanacimiento.Location = new System.Drawing.Point(50, 203);
            this.dpFechanacimiento.Name = "dpFechanacimiento";
            this.dpFechanacimiento.Size = new System.Drawing.Size(200, 20);
            this.dpFechanacimiento.TabIndex = 66;
            // 
            // btnAgregarenfermedad
            // 
            this.btnAgregarenfermedad.Location = new System.Drawing.Point(486, 152);
            this.btnAgregarenfermedad.Name = "btnAgregarenfermedad";
            this.btnAgregarenfermedad.Size = new System.Drawing.Size(146, 29);
            this.btnAgregarenfermedad.TabIndex = 67;
            this.btnAgregarenfermedad.Text = "AGREGAR O ELIMINAR";
            this.btnAgregarenfermedad.UseVisualStyleBackColor = true;
            this.btnAgregarenfermedad.Click += new System.EventHandler(this.btnAgregarenfermedad_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(354, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 14);
            this.label10.TabIndex = 68;
            this.label10.Text = "ENFERMEDADES BASES";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Image = global::P1_Vacunaton_21811039.Properties.Resources.logoname;
            this.label7.Location = new System.Drawing.Point(470, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 26);
            this.label7.TabIndex = 40;
            // 
            // lvEnfermedades
            // 
            this.lvEnfermedades.Enabled = false;
            this.lvEnfermedades.FormattingEnabled = true;
            this.lvEnfermedades.Location = new System.Drawing.Point(357, 185);
            this.lvEnfermedades.Name = "lvEnfermedades";
            this.lvEnfermedades.Size = new System.Drawing.Size(278, 139);
            this.lvEnfermedades.TabIndex = 70;
            // 
            // Ciudadano_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 596);
            this.Controls.Add(this.lvEnfermedades);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAgregarenfermedad);
            this.Controls.Add(this.dpFechanacimiento);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.cbEstadocivil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.rbfem);
            this.Controls.Add(this.rbmasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldirectory);
            this.Name = "Ciudadano_Create";
            this.Text = "Ciudadano_Create";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.ComboBox cbEstadocivil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.RadioButton rbfem;
        private System.Windows.Forms.RadioButton rbmasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldirectory;
        private System.Windows.Forms.DateTimePicker dpFechanacimiento;
        private System.Windows.Forms.Button btnAgregarenfermedad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox lvEnfermedades;
    }
}