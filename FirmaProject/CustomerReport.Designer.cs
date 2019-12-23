namespace FirmaProject
{
    partial class CustomerReport
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
            this.rpvCust = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new FirmaProject.abdulGmbHDataSetTableAdapters.CustomerTableAdapter();
            this.buyingTableAdapter = new FirmaProject.abdulGmbHDataSetTableAdapters.BuyingTableAdapter();
            this.customerBuyingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBuyingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowstatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBuyingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBuyingBindingSource1)).BeginInit();
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
            // rpvCust
            // 
            this.rpvCust.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1Customer";
            reportDataSource1.Value = this.customerBindingSource;
            this.rpvCust.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvCust.LocalReport.ReportEmbeddedResource = "FirmaProject.Customer.rdlc";
            this.rpvCust.Location = new System.Drawing.Point(0, 0);
            this.rpvCust.Name = "rpvCust";
            this.rpvCust.ServerReport.BearerToken = null;
            this.rpvCust.Size = new System.Drawing.Size(800, 393);
            this.rpvCust.TabIndex = 0;
            this.rpvCust.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.abdulGmbHDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // buyingTableAdapter
            // 
            this.buyingTableAdapter.ClearBeforeFill = true;
            // 
            // customerBuyingBindingSource
            // 
            this.customerBuyingBindingSource.DataMember = "CustomerBuying";
            this.customerBuyingBindingSource.DataSource = this.customerBindingSource;
            // 
            // customerBuyingBindingSource1
            // 
            this.customerBuyingBindingSource1.DataMember = "CustomerBuying";
            this.customerBuyingBindingSource1.DataSource = this.customerBindingSource;
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.rpvCust);
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abdulGmbHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowstatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBuyingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBuyingBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ShowstatBindingSource;
        private abdulGmbHDataSet abdulGmbHDataSet;
        private abdulGmbHDataSetTableAdapters.ShowstatTableAdapter ShowstatTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvCust;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private abdulGmbHDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBuyingBindingSource;
        private abdulGmbHDataSetTableAdapters.BuyingTableAdapter buyingTableAdapter;
        private System.Windows.Forms.BindingSource customerBuyingBindingSource1;
    }
}