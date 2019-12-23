namespace FirmaProject
{
    partial class Showstat
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
            this.abdulGmbHDataSet = new FirmaProject.abdulGmbHDataSet();
            this.ShowstatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShowstatTableAdapter = new FirmaProject.abdulGmbHDataSetTableAdapters.ShowstatTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowstatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // abdulGmbHDataSet
            // 
            this.abdulGmbHDataSet.DataSetName = "abdulGmbHDataSet";
            this.abdulGmbHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShowstatBindingSource
            // 
            this.ShowstatBindingSource.DataMember = "Showstat";
            this.ShowstatBindingSource.DataSource = this.abdulGmbHDataSet;
            // 
            // ShowstatTableAdapter
            // 
            this.ShowstatTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ShowstatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FirmaProject.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(903, 455);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // Showstat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 455);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Showstat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Showstat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Showstat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowstatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ShowstatBindingSource;
        private abdulGmbHDataSet abdulGmbHDataSet;
        private abdulGmbHDataSetTableAdapters.ShowstatTableAdapter ShowstatTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}