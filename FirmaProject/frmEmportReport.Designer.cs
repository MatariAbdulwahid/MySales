namespace FirmaProject
{
    partial class ImportReport
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
            this.Action_inBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Action_inTableAdapter = new FirmaProject.abdulGmbHDataSetTableAdapters.Action_inTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Action_inBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Action_inBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FirmaProject.ImportReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // abdulGmbHDataSet
            // 
            this.abdulGmbHDataSet.DataSetName = "abdulGmbHDataSet";
            this.abdulGmbHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Action_inBindingSource
            // 
            this.Action_inBindingSource.DataMember = "Action_in";
            this.Action_inBindingSource.DataSource = this.abdulGmbHDataSet;
            // 
            // Action_inTableAdapter
            // 
            this.Action_inTableAdapter.ClearBeforeFill = true;
            // 
            // ImportReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImportReport";
            this.Text = "Import Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmportReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Action_inBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Action_inBindingSource;
        private abdulGmbHDataSet abdulGmbHDataSet;
        private abdulGmbHDataSetTableAdapters.Action_inTableAdapter Action_inTableAdapter;
    }
}