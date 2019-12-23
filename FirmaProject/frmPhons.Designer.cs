namespace FirmaProject
{
    partial class frmPhons
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.abdulGmbHDataSet = new FirmaProject.abdulGmbHDataSet();
            this.Phone_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Phone_CustomerTableAdapter = new FirmaProject.abdulGmbHDataSetTableAdapters.Phone_CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_CustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Phone_CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FirmaProject.phonReport.rdlc";
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
            // Phone_CustomerBindingSource
            // 
            this.Phone_CustomerBindingSource.DataMember = "Phone_Customer";
            this.Phone_CustomerBindingSource.DataSource = this.abdulGmbHDataSet;
            // 
            // Phone_CustomerTableAdapter
            // 
            this.Phone_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPhons";
            this.Text = "frmPhons";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_CustomerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Phone_CustomerBindingSource;
        private abdulGmbHDataSet abdulGmbHDataSet;
        private abdulGmbHDataSetTableAdapters.Phone_CustomerTableAdapter Phone_CustomerTableAdapter;
    }
}