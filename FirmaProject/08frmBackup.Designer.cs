namespace FirmaProject
{
    partial class frmBackup
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSetBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 46);
            this.label2.TabIndex = 86;
            this.label2.Text = "Backup";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 41);
            this.button2.TabIndex = 88;
            this.button2.Text = "Backup restore";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSetBackup
            // 
            this.btnSetBackup.Location = new System.Drawing.Point(261, 86);
            this.btnSetBackup.Name = "btnSetBackup";
            this.btnSetBackup.Size = new System.Drawing.Size(281, 47);
            this.btnSetBackup.TabIndex = 87;
            this.btnSetBackup.Text = "New Backup";
            this.btnSetBackup.UseVisualStyleBackColor = true;
            this.btnSetBackup.Click += new System.EventHandler(this.btnSetBackup_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSetBackup);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBackup";
            this.Text = "Backup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSetBackup;
    }
}