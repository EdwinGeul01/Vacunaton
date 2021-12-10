
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CiudadanosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VacunatonDataSet = new P1_Vacunaton_21811039.VacunatonDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CiudadanosTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.CiudadanosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbidname = new System.Windows.Forms.CheckBox();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CiudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel1
            // 
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
            reportDataSource4.Name = "DataCiudadanos";
            reportDataSource4.Value = this.CiudadanosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "REPORTE DE  CENTRO DE CIUDADANOS";
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
            // txtinfo
            // 
            this.txtinfo.Enabled = false;
            this.txtinfo.Location = new System.Drawing.Point(443, 52);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(178, 20);
            this.txtinfo.TabIndex = 10;
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
            // Report_Ciudadanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report_Ciudadanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Ciudadanos";
            this.Load += new System.EventHandler(this.Report_Ciudadanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CiudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
    }
}