
namespace P1_Vacunaton_21811039
{
    partial class Ciudadano_Delete
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
            this.button2 = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldirectory = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dpfechanec = new System.Windows.Forms.DateTimePicker();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.rbfem = new System.Windows.Forms.RadioButton();
            this.rbmasc = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.lvEnfermedades = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-3, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 38);
            this.button2.TabIndex = 90;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitle.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(43, 62);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(688, 21);
            this.lbltitle.TabIndex = 72;
            this.lbltitle.Text = "ELIMINAR CIUDADANO         ";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.label7.TabIndex = 71;
            // 
            // lbldirectory
            // 
            this.lbldirectory.BackColor = System.Drawing.Color.LightGray;
            this.lbldirectory.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldirectory.Location = new System.Drawing.Point(4, 28);
            this.lbldirectory.Name = "lbldirectory";
            this.lbldirectory.Size = new System.Drawing.Size(776, 21);
            this.lbldirectory.TabIndex = 70;
            this.lbldirectory.Text = "                       OPCIONES  -  ADMINISTRAR USUARIOS - ELIMINAR CIUDADANO    " +
    "          ";
            this.lbldirectory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(354, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 14);
            this.label10.TabIndex = 113;
            this.label10.Text = "ENFERMEDADES BASES";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(256, 111);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(89, 29);
            this.btnbuscar.TabIndex = 112;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dpfechanec
            // 
            this.dpfechanec.CustomFormat = "dd/mm/yyy";
            this.dpfechanec.Enabled = false;
            this.dpfechanec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpfechanec.Location = new System.Drawing.Point(50, 206);
            this.dpfechanec.Name = "dpfechanec";
            this.dpfechanec.Size = new System.Drawing.Size(200, 20);
            this.dpfechanec.TabIndex = 111;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Location = new System.Drawing.Point(47, 414);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(256, 86);
            this.btneliminar.TabIndex = 110;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(351, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 14);
            this.label9.TabIndex = 108;
            this.label9.Text = "ESTADO CIVIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(47, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 107;
            this.label8.Text = "TELEFONO";
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(47, 256);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(204, 20);
            this.txttelefono.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(47, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 105;
            this.label6.Text = "DIRECCION";
            // 
            // txtdirec
            // 
            this.txtdirec.Enabled = false;
            this.txtdirec.Location = new System.Drawing.Point(47, 372);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(268, 20);
            this.txtdirec.TabIndex = 104;
            // 
            // rbfem
            // 
            this.rbfem.AutoSize = true;
            this.rbfem.Enabled = false;
            this.rbfem.Location = new System.Drawing.Point(163, 317);
            this.rbfem.Name = "rbfem";
            this.rbfem.Size = new System.Drawing.Size(81, 17);
            this.rbfem.TabIndex = 103;
            this.rbfem.Text = "FEMENINO";
            this.rbfem.UseVisualStyleBackColor = true;
            // 
            // rbmasc
            // 
            this.rbmasc.AutoSize = true;
            this.rbmasc.Checked = true;
            this.rbmasc.Enabled = false;
            this.rbmasc.Location = new System.Drawing.Point(47, 317);
            this.rbmasc.Name = "rbmasc";
            this.rbmasc.Size = new System.Drawing.Size(88, 17);
            this.rbmasc.TabIndex = 102;
            this.rbmasc.TabStop = true;
            this.rbmasc.Text = "MASCULINO";
            this.rbmasc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(47, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 101;
            this.label5.Text = "GENERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(47, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 14);
            this.label3.TabIndex = 100;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(47, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "NOMBRE";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(47, 160);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(204, 20);
            this.txtnombre.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(47, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 14);
            this.label1.TabIndex = 97;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(47, 118);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(204, 20);
            this.txtid.TabIndex = 96;
            // 
            // txtestado
            // 
            this.txtestado.Enabled = false;
            this.txtestado.Location = new System.Drawing.Point(354, 120);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(204, 20);
            this.txtestado.TabIndex = 115;
            // 
            // lvEnfermedades
            // 
            this.lvEnfermedades.Enabled = false;
            this.lvEnfermedades.FormattingEnabled = true;
            this.lvEnfermedades.Location = new System.Drawing.Point(354, 177);
            this.lvEnfermedades.Name = "lvEnfermedades";
            this.lvEnfermedades.Size = new System.Drawing.Size(278, 139);
            this.lvEnfermedades.TabIndex = 116;
            // 
            // Ciudadano_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 596);
            this.Controls.Add(this.lvEnfermedades);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dpfechanec);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdirec);
            this.Controls.Add(this.rbfem);
            this.Controls.Add(this.rbmasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldirectory);
            this.Name = "Ciudadano_Delete";
            this.Text = "Ciudadano_Delete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldirectory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DateTimePicker dpfechanec;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.RadioButton rbfem;
        private System.Windows.Forms.RadioButton rbmasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.CheckedListBox lvEnfermedades;
    }
}