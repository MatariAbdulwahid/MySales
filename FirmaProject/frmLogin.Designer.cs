namespace FirmaProject
{
    partial class frmLogin
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
            this.btnCustSearch2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txnPassw = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustSearch2
            // 
            this.btnCustSearch2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCustSearch2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSearch2.ForeColor = System.Drawing.Color.White;
            this.btnCustSearch2.Location = new System.Drawing.Point(173, 121);
            this.btnCustSearch2.Name = "btnCustSearch2";
            this.btnCustSearch2.Size = new System.Drawing.Size(119, 32);
            this.btnCustSearch2.TabIndex = 0;
            this.btnCustSearch2.Text = "Sign In";
            this.btnCustSearch2.UseVisualStyleBackColor = false;
            this.btnCustSearch2.Click += new System.EventHandler(this.btnCustSearch2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txnPassw
            // 
            this.txnPassw.BackColor = System.Drawing.Color.White;
            this.txnPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnPassw.Location = new System.Drawing.Point(132, 77);
            this.txnPassw.Name = "txnPassw";
            this.txnPassw.PasswordChar = '*';
            this.txnPassw.Size = new System.Drawing.Size(235, 24);
            this.txnPassw.TabIndex = 3;
            this.txnPassw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txnPassw_KeyDown);
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.White;
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(132, 46);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(235, 24);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbUserName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name";
            // 
            // CustSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::FirmaProject.Properties.Resources.onlie2;
            this.ClientSize = new System.Drawing.Size(440, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txnPassw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.btnCustSearch2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CustSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.CustSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustSearch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txnPassw;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label1;
    }
}