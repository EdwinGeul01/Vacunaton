﻿
namespace P1_Vacunaton_21811039
{
    partial class Report_VacunasXCiuda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cbid = new System.Windows.Forms.CheckBox();
            this.txtdosis = new System.Windows.Forms.TextBox();
            this.cbdosis = new System.Windows.Forms.CheckBox();
            this.cbfecha = new System.Windows.Forms.CheckBox();
            this.dpfechaapli = new System.Windows.Forms.DateTimePicker();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunaXCiudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentroAsistenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(98, 18);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // cbid
            // 
            this.cbid.AutoSize = true;
            this.cbid.ForeColor = System.Drawing.Color.White;
            this.cbid.Location = new System.Drawing.Point(54, 21);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(37, 17);
            this.cbid.TabIndex = 2;
            this.cbid.Text = "ID";
            this.cbid.UseVisualStyleBackColor = true;
            this.cbid.CheckedChanged += new System.EventHandler(this.cbid_CheckedChanged);
            // 
            // txtdosis
            // 
            this.txtdosis.Location = new System.Drawing.Point(284, 20);
            this.txtdosis.Name = "txtdosis";
            this.txtdosis.Size = new System.Drawing.Size(100, 20);
            this.txtdosis.TabIndex = 3;
            // 
            // cbdosis
            // 
            this.cbdosis.AutoSize = true;
            this.cbdosis.ForeColor = System.Drawing.Color.White;
            this.cbdosis.Location = new System.Drawing.Point(215, 21);
            this.cbdosis.Name = "cbdosis";
            this.cbdosis.Size = new System.Drawing.Size(63, 17);
            this.cbdosis.TabIndex = 4;
            this.cbdosis.Text = "N Dosis";
            this.cbdosis.UseVisualStyleBackColor = true;
            this.cbdosis.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbfecha
            // 
            this.cbfecha.AutoSize = true;
            this.cbfecha.ForeColor = System.Drawing.Color.White;
            this.cbfecha.Location = new System.Drawing.Point(408, 20);
            this.cbfecha.Name = "cbfecha";
            this.cbfecha.Size = new System.Drawing.Size(74, 17);
            this.cbfecha.TabIndex = 6;
            this.cbfecha.Text = "FECHA A.";
            this.cbfecha.UseVisualStyleBackColor = true;
            this.cbfecha.CheckedChanged += new System.EventHandler(this.cbfecha_CheckedChanged);
            // 
            // dpfechaapli
            // 
            this.dpfechaapli.CustomFormat = "dd/MM/yyy";
            this.dpfechaapli.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpfechaapli.Location = new System.Drawing.Point(500, 19);
            this.dpfechaapli.Name = "dpfechaapli";
            this.dpfechaapli.Size = new System.Drawing.Size(127, 20);
            this.dpfechaapli.TabIndex = 93;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(657, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(128, 48);
            this.btnbuscar.TabIndex = 94;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 62);
            this.panel1.TabIndex = 97;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 517);
            this.panel2.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "REPORTE DE VACUNAS X CIUDADANO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Controls.Add(this.cbid);
            this.panel3.Controls.Add(this.txtdosis);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.cbdosis);
            this.panel3.Controls.Add(this.dpfechaapli);
            this.panel3.Controls.Add(this.cbfecha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(344, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 62);
            this.panel3.TabIndex = 96;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "VxCiudadano";
            reportDataSource5.Value = this.VacunaXCiudadanosBindingSource;
            reportDataSource6.Name = "Ciudadanos";
            reportDataSource6.Value = this.CiudadanosBindingSource;
            reportDataSource7.Name = "Vacunas";
            reportDataSource7.Value = this.VacunasBindingSource;
            reportDataSource8.Name = "CentrodeA";
            reportDataSource8.Value = this.CentroAsistenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "P1_Vacunaton_21811039.Consultas.VacunasXCiudadanos_C.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1141, 517);
            this.reportViewer1.TabIndex = 0;
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
            // Report_VacunasXCiuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report_VacunasXCiuda";
            this.Text = "Report_VacunasXCiuda";
            this.Load += new System.EventHandler(this.Report_VacunasXCiuda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunaXCiudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentroAsistenciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.CheckBox cbid;
        private System.Windows.Forms.TextBox txtdosis;
        private System.Windows.Forms.CheckBox cbdosis;
        private System.Windows.Forms.CheckBox cbfecha;
        private System.Windows.Forms.DateTimePicker dpfechaapli;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
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
    }
}