
namespace P1_Vacunaton_21811039
{
    partial class Report_Ciudadanos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CiudadanosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VacunatonDataSet = new P1_Vacunaton_21811039.VacunatonDataSet();
            this.EnfermedadesXCiudadanosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EnfermedadesBasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbidname = new System.Windows.Forms.CheckBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CiudadanosTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.CiudadanosTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EnfermedadesXCiudadanosTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.EnfermedadesXCiudadanosTableAdapter();
            this.EnfermedadesBasesTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.EnfermedadesBasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermedadesXCiudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermedadesBasesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CiudadanosBindingSource
            // 
            this.CiudadanosBindingSource.DataMember = "Ciudadanos";
            this.CiudadanosBindingSource.DataSource = this.VacunatonDataSet;
            // 
            // VacunatonDataSet
            // 
            this.VacunatonDataSet.DataSetName = "VacunatonDataSet";
            this.VacunatonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EnfermedadesXCiudadanosBindingSource
            // 
            this.EnfermedadesXCiudadanosBindingSource.DataMember = "EnfermedadesXCiudadanos";
            this.EnfermedadesXCiudadanosBindingSource.DataSource = this.VacunatonDataSet;
            // 
            // EnfermedadesBasesBindingSource
            // 
            this.EnfermedadesBasesBindingSource.DataMember = "EnfermedadesBases";
            this.EnfermedadesBasesBindingSource.DataSource = this.VacunatonDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbidname);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtinfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(256, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "MOSTRAR CIUDADANOS X ENFERMEDADES";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "REPORTE DE CIUDADANOS";
            // 
            // cbidname
            // 
            this.cbidname.AutoSize = true;
            this.cbidname.Location = new System.Drawing.Point(443, 29);
            this.cbidname.Name = "cbidname";
            this.cbidname.Size = new System.Drawing.Size(135, 17);
            this.cbidname.TabIndex = 11;
            this.cbidname.Text = "Buscar por id o nombre";
            this.cbidname.UseVisualStyleBackColor = true;
            this.cbidname.CheckedChanged += new System.EventHandler(this.cbidname_CheckedChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(627, 50);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(150, 32);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.Enabled = false;
            this.txtinfo.Location = new System.Drawing.Point(443, 52);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(178, 20);
            this.txtinfo.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataCiudadanos";
            reportDataSource1.Value = this.CiudadanosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "P1_Vacunaton_21811039.Consultas.Report_Ciudadanos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // CiudadanosTableAdapter
            // 
            this.CiudadanosTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reportViewer2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 350);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "CiudadanoXEnfermedad";
            reportDataSource2.Value = this.EnfermedadesXCiudadanosBindingSource;
            reportDataSource3.Name = "Enfermedad";
            reportDataSource3.Value = this.EnfermedadesBasesBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "P1_Vacunaton_21811039.Consultas.Report_CiudadanosXEnfermedades.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 350);
            this.reportViewer2.TabIndex = 0;
            // 
            // EnfermedadesXCiudadanosTableAdapter
            // 
            this.EnfermedadesXCiudadanosTableAdapter.ClearBeforeFill = true;
            // 
            // EnfermedadesBasesTableAdapter
            // 
            this.EnfermedadesBasesTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Ciudadanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Report_Ciudadanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Ciudadanos";
            this.Load += new System.EventHandler(this.Report_Ciudadanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CiudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermedadesXCiudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermedadesBasesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CiudadanosBindingSource;
        private VacunatonDataSet VacunatonDataSet;
        private VacunatonDataSetTableAdapters.CiudadanosTableAdapter CiudadanosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbidname;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource EnfermedadesXCiudadanosBindingSource;
        private System.Windows.Forms.BindingSource EnfermedadesBasesBindingSource;
        private VacunatonDataSetTableAdapters.EnfermedadesXCiudadanosTableAdapter EnfermedadesXCiudadanosTableAdapter;
        private VacunatonDataSetTableAdapters.EnfermedadesBasesTableAdapter EnfermedadesBasesTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}