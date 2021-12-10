
namespace P1_Vacunaton_21811039
{
    partial class Report_Enfermedades
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
            this.EnfermedadesBasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VacunatonDataSet = new P1_Vacunaton_21811039.VacunatonDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EnfermedadesBasesTableAdapter = new P1_Vacunaton_21811039.VacunatonDataSetTableAdapters.EnfermedadesBasesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbidname = new System.Windows.Forms.CheckBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtinfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermedadesBasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacunatonDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnfermedadesBasesBindingSource
            // 
            this.EnfermedadesBasesBindingSource.DataMember = "EnfermedadesBases";
            this.EnfermedadesBasesBindingSource.DataSource = this.VacunatonDataSet;
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
            this.panel1.Controls.Add(this.txtinfo);
            this.panel1.Controls.Add(this.btnbuscar);
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
            reportDataSource5.Name = "DataEnfermedades";
            reportDataSource5.Value = this.EnfermedadesBasesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "P1_Vacunaton_21811039.Consultas.Report_Enfermedades.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // EnfermedadesBasesTableAdapter
            // 
            this.EnfermedadesBasesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "REPORTE DE  ENFERMEDADES";
            // 
            // cbidname
            // 
            this.cbidname.AutoSize = true;
            this.cbidname.Location = new System.Drawing.Point(452, 31);
            this.cbidname.Name = "cbidname";
            this.cbidname.Size = new System.Drawing.Size(135, 17);
            this.cbidname.TabIndex = 15;
            this.cbidname.Text = "Buscar por id o nombre";
            this.cbidname.UseVisualStyleBackColor = true;
            this.cbidname.CheckedChanged += new System.EventHandler(this.cbidname_CheckedChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(636, 52);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(150, 32);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.Enabled = false;
            this.txtinfo.Location = new System.Drawing.Point(452, 54);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(178, 20);
            this.txtinfo.TabIndex = 14;
            // 
            // Report_Enfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report_Enfermedades";
            this.Text = "Report_Enfermedades";
            this.Load += new System.EventHandler(this.Report_Enfermedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnfermedadesBasesBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource EnfermedadesBasesBindingSource;
        private VacunatonDataSet VacunatonDataSet;
        private VacunatonDataSetTableAdapters.EnfermedadesBasesTableAdapter EnfermedadesBasesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbidname;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Button btnbuscar;
    }
}