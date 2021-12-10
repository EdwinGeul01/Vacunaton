
namespace P1_Vacunaton_21811039
{
    partial class AplicarVacuna
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldirectory = new System.Windows.Forms.Label();
            this.cbvacunasE = new System.Windows.Forms.ComboBox();
            this.txtndosis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpfechaapli = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnaplicar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cbCentrovacunas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(258, 112);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(120, 20);
            this.btnbuscar.TabIndex = 72;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(45, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 71;
            this.label1.Text = "ID CIUDADANO";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(48, 112);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(204, 20);
            this.txtcod.TabIndex = 70;
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitle.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(44, 65);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(688, 21);
            this.lbltitle.TabIndex = 69;
            this.lbltitle.Text = "APLICAR DOSIS          ";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Image = global::P1_Vacunaton_21811039.Properties.Resources.logoname;
            this.label7.Location = new System.Drawing.Point(471, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 26);
            this.label7.TabIndex = 68;
            // 
            // lbldirectory
            // 
            this.lbldirectory.BackColor = System.Drawing.Color.LightGray;
            this.lbldirectory.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldirectory.Location = new System.Drawing.Point(-2, 31);
            this.lbldirectory.Name = "lbldirectory";
            this.lbldirectory.Size = new System.Drawing.Size(783, 21);
            this.lbldirectory.TabIndex = 67;
            this.lbldirectory.Text = "                       OPCIONES  -  ADMINISTRAR CIUDADANOS - APLICAR DOSIS       " +
    "       ";
            this.lbldirectory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbvacunasE
            // 
            this.cbvacunasE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbvacunasE.FormattingEnabled = true;
            this.cbvacunasE.Location = new System.Drawing.Point(48, 221);
            this.cbvacunasE.Name = "cbvacunasE";
            this.cbvacunasE.Size = new System.Drawing.Size(204, 21);
            this.cbvacunasE.TabIndex = 73;
            // 
            // txtndosis
            // 
            this.txtndosis.Enabled = false;
            this.txtndosis.Location = new System.Drawing.Point(48, 161);
            this.txtndosis.Name = "txtndosis";
            this.txtndosis.Size = new System.Drawing.Size(204, 20);
            this.txtndosis.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(45, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 14);
            this.label2.TabIndex = 75;
            this.label2.Text = "# DE DOSIS HA APLICAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(45, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 76;
            this.label3.Text = "VACUNA ";
            // 
            // dpfechaapli
            // 
            this.dpfechaapli.CustomFormat = "dd/MM/yyy";
            this.dpfechaapli.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpfechaapli.Location = new System.Drawing.Point(48, 333);
            this.dpfechaapli.Name = "dpfechaapli";
            this.dpfechaapli.Size = new System.Drawing.Size(204, 20);
            this.dpfechaapli.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(45, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 93;
            this.label4.Text = "FECHA DE APLICACION";
            // 
            // btnaplicar
            // 
            this.btnaplicar.Enabled = false;
            this.btnaplicar.Location = new System.Drawing.Point(370, 157);
            this.btnaplicar.Name = "btnaplicar";
            this.btnaplicar.Size = new System.Drawing.Size(362, 75);
            this.btnaplicar.TabIndex = 94;
            this.btnaplicar.Text = "APLICAR DOSIS";
            this.btnaplicar.UseVisualStyleBackColor = true;
            this.btnaplicar.Click += new System.EventHandler(this.btnaplicar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(370, 238);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(362, 75);
            this.btncancelar.TabIndex = 95;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cbCentrovacunas
            // 
            this.cbCentrovacunas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCentrovacunas.FormattingEnabled = true;
            this.cbCentrovacunas.Location = new System.Drawing.Point(48, 276);
            this.cbCentrovacunas.Name = "cbCentrovacunas";
            this.cbCentrovacunas.Size = new System.Drawing.Size(204, 21);
            this.cbCentrovacunas.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(45, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 14);
            this.label10.TabIndex = 96;
            this.label10.Text = "CENTRO DE ASISTENCIA ENCARGADO";
            // 
            // AplicarVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 596);
            this.Controls.Add(this.cbCentrovacunas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaplicar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dpfechaapli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtndosis);
            this.Controls.Add(this.cbvacunasE);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldirectory);
            this.Name = "AplicarVacuna";
            this.Text = "AplicarVacuna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AplicarVacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldirectory;
        private System.Windows.Forms.ComboBox cbvacunasE;
        private System.Windows.Forms.TextBox txtndosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpfechaapli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaplicar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cbCentrovacunas;
        private System.Windows.Forms.Label label10;
    }
}