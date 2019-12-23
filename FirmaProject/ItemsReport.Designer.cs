namespace FirmaProject
{
    partial class frmItemsReport
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
            this.rpvItem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.abdulGmbHDataSet = new FirmaProject.abdulGmbHDataSet();
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemTableAdapter = new FirmaProject.abdulGmbHDataSetTableAdapters.ItemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvItem
            // 
            this.rpvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ItemBindingSource;
            this.rpvItem.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvItem.LocalReport.ReportEmbeddedResource = "FirmaProject.Items.rdlc";
            this.rpvItem.Location = new System.Drawing.Point(0, 0);
            this.rpvItem.Name = "rpvItem";
            this.rpvItem.ServerReport.BearerToken = null;
            this.rpvItem.Size = new System.Drawing.Size(800, 450);
            this.rpvItem.TabIndex = 0;
            this.rpvItem.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // abdulGmbHDataSet
            // 
            this.abdulGmbHDataSet.DataSetName = "abdulGmbHDataSet";
            this.abdulGmbHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataMember = "Item";
            this.ItemBindingSource.DataSource = this.abdulGmbHDataSet;
            // 
            // ItemTableAdapter
            // 
            this.ItemTableAdapter.ClearBeforeFill = true;
            // 
            // frmItemsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvItem);
            this.Name = "frmItemsReport";
            this.Text = "ItemsReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvItem;
        private System.Windows.Forms.BindingSource ItemBindingSource;
        private abdulGmbHDataSet abdulGmbHDataSet;
        private abdulGmbHDataSetTableAdapters.ItemTableAdapter ItemTableAdapter;
    }
}