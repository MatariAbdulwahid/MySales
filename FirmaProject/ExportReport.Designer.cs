namespace FirmaProject
{
    partial class ExportReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.abdulGmbHDataSet = new FirmaProject.abdulGmbHDataSet();
            this.Action_OutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Action_OutTableAdapter = new FirmaProject.abdulGmbHDataSetTableAdapters.Action_OutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Action_OutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Action_OutBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FirmaProject.ExportReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // abdulGmbHDataSet
            // 
            this.abdulGmbHDataSet.DataSetName = "abdulGmbHDataSet";
            this.abdulGmbHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Action_OutBindingSource
            // 
            this.Action_OutBindingSource.DataMember = "Action_Out";
            this.Action_OutBindingSource.DataSource = this.abdulGmbHDataSet;
            // 
            // Action_OutTableAdapter
            // 
            this.Action_OutTableAdapter.ClearBeforeFill = true;
            // 
            // ExportReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ExportReport";
            this.Text = "ExportReport";
            this.Load += new System.EventHandler(this.ExportReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Action_OutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Action_OutBindingSource;
        private abdulGmbHDataSet abdulGmbHDataSet;
        private abdulGmbHDataSetTableAdapters.Action_OutTableAdapter Action_OutTableAdapter;
    }
}