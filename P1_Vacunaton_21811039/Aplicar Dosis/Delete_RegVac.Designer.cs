
namespace P1_Vacunaton_21811039
{
    partial class Delete_RegVac
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtndosis = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldirectory = new System.Windows.Forms.Label();
            this.cball = new System.Windows.Forms.CheckBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VacunatonDataSet = new P1_Vacunaton_21811039.VacunatonDataSet();
            this.VacunaXCiudadanosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VacunaXCiudadanosTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.VacunaXCiudadanosTableAdapter();
            this.CiudadanosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CiudadanosTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.CiudadanosTableAdapter();
            this.VacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VacunasTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.VacunasTableAdapter();
            this.CentroAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CentroAsistenciaTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.CentroAsistenciaTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunaXCiudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentroAsistenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(49, 484);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(324, 75);
            this.btncancelar.TabIndex = 111;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(403, 484);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(330, 75);
            this.btneliminar.TabIndex = 110;
            this.btneliminar.Text = "ELIMINAR DOSIS";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(46, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 14);
            this.label2.TabIndex = 106;
            this.label2.Text = "# DE DOSIS HA ELIMINAR";
            // 
            // txtndosis
            // 
            this.txtndosis.Location = new System.Drawing.Point(49, 189);
            this.txtndosis.Name = "txtndosis";
            this.txtndosis.Size = new System.Drawing.Size(204, 20);
            this.txtndosis.TabIndex = 105;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(259, 116);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(120, 20);
            this.btnbuscar.TabIndex = 103;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(46, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 102;
            this.label1.Text = "ID CIUDADANO";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(49, 116);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(204, 20);
            this.txtcod.TabIndex = 101;
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitle.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(45, 69);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(688, 21);
            this.lbltitle.TabIndex = 100;
            this.lbltitle.Text = "APLICAR DOSIS          ";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Image = global::P1_Vacunaton_21811039.Properties.Resources.logoname;
            this.label7.Location = new System.Drawing.Point(472, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 26);
            this.label7.TabIndex = 99;
            // 
            // lbldirectory
            // 
            this.lbldirectory.BackColor = System.Drawing.Color.LightGray;
            this.lbldirectory.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldirectory.Location = new System.Drawing.Point(-1, 35);
            this.lbldirectory.Name = "lbldirectory";
            this.lbldirectory.Size = new System.Drawing.Size(783, 21);
            this.lbldirectory.TabIndex = 98;
            this.lbldirectory.Text = "                       OPCIONES  -  ADMINISTRAR CIUDADANOS - APLICAR DOSIS       " +
    "       ";
            this.lbldirectory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cball
            // 
            this.cball.AutoSize = true;
            this.cball.Location = new System.Drawing.Point(50, 165);
            this.cball.Name = "cball";
            this.cball.Size = new System.Drawing.Size(63, 17);
            this.cball.TabIndex = 112;
            this.cball.Text = "TODAS";
            this.cball.UseVisualStyleBackColor = true;
            this.cball.CheckedChanged += new System.EventHandler(this.cball_CheckedChanged);
            // 
            // reportViewer1
            // 
            reportDataSource9.Name = "VxCiudadano";
            reportDataSource9.Value = this.VacunaXCiudadanosBindingSource;
            reportDataSource10.Name = "Ciudadanos";
            reportDataSource10.Value = this.CiudadanosBindingSource;
            reportDataSource11.Name = "Vacunas";
            reportDataSource11.Value = this.VacunasBindingSource;
            reportDataSource12.Name = "CentrodeA";
            reportDataSource12.Value = this.CentroAsistenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "P1_Vacunaton_21811039.Consultas.VacunasXCiudadanos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 236);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(779, 242);
            this.reportViewer1.TabIndex = 113;
            // 
            // VacunatonDataSet
            // 
            this.VacunatonDataSet.DataSetName = "VacunatonDataSet";
            this.VacunatonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VacunaXCiudadanosBindingSource
            // 
            this.VacunaXCiudadanosBindingSource.DataMember = "VacunaXCiudadanos";
            this.VacunaXCiudadanosBindingSource.DataSource = this.VacunatonDataSet;
            // 
            // VacunaXCiudadanosTableAdapter
            // 
            this.VacunaXCiudadanosTableAdapter.ClearBeforeFill = true;
            // 
            // CiudadanosBindingSource
            // 
            this.CiudadanosBindingSource.DataMember = "Ciudadanos";
            this.CiudadanosBindingSource.DataSource = this.VacunatonDataSet;
            // 
            // CiudadanosTableAdapter
            // 
            this.CiudadanosTableAdapter.ClearBeforeFill = true;
            // 
            // VacunasBindingSource
            // 
            this.VacunasBindingSource.DataMember = "Vacunas";
            this.VacunasBindingSource.DataSource = this.VacunatonDataSet;
            // 
            // VacunasTableAdapter
            // 
            this.VacunasTableAdapter.ClearBeforeFill = true;
            // 
            // CentroAsistenciaBindingSource
            // 
            this.CentroAsistenciaBindingSource.DataMember = "CentroAsistencia";
            this.CentroAsistenciaBindingSource.DataSource = this.VacunatonDataSet;
            // 
            // CentroAsistenciaTableAdapter
            // 
            this.CentroAsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(675, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 114;
            this.label3.Text = "REGISTRO";
            // 
            // Delete_RegVac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 596);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cball);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtndosis);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldirectory);
            this.Name = "Delete_RegVac";
            this.Text = "Delete_RegVac";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Delete_RegVac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunaXCiudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentroAsistenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtndosis;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldirectory;
        private System.Windows.Forms.CheckBox cball;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VacunaXCiudadanosBindingSource;
        private VacunatonDataSet VacunatonDataSet;
        private System.Windows.Forms.BindingSource CiudadanosBindingSource;
        private System.Windows.Forms.BindingSource VacunasBindingSource;
        private System.Windows.Forms.BindingSource CentroAsistenciaBindingSource;
        private VacunatonDataSetTableAdapters.VacunaXCiudadanosTableAdapter VacunaXCiudadanosTableAdapter;
        private VacunatonDataSetTableAdapters.CiudadanosTableAdapter CiudadanosTableAdapter;
        private VacunatonDataSetTableAdapters.VacunasTableAdapter VacunasTableAdapter;
        private VacunatonDataSetTableAdapters.CentroAsistenciaTableAdapter CentroAsistenciaTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}