
namespace P1_Vacunaton_21811039
{
    partial class Report_CentroA
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
            this.CentroAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VacunatonDataSet = new P1_Vacunaton_21811039.VacunatonDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CentroAsistenciaTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.CentroAsistenciaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CentroAsistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CentroAsistenciaBindingSource
            // 
            this.CentroAsistenciaBindingSource.DataMember = "CentroAsistencia";
            this.CentroAsistenciaBindingSource.DataSource = this.VacunatonDataSet;
            // 
            // VacunatonDataSet
            // 
            this.VacunatonDataSet.DataSetName = "VacunatonDataSet";
            this.VacunatonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CentroA";
            reportDataSource1.Value = this.CentroAsistenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "P1_Vacunaton_21811039.Consultas.Report_CentroA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // CentroAsistenciaTableAdapter
            // 
            this.CentroAsistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 2;
            // 
            // Report_CentroA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report_CentroA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_CentroA";
            this.Load += new System.EventHandler(this.Report_CentroA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CentroAsistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CentroAsistenciaBindingSource;
        private VacunatonDataSet VacunatonDataSet;
        private VacunatonDataSetTableAdapters.CentroAsistenciaTableAdapter CentroAsistenciaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}