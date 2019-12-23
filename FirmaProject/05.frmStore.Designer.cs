namespace FirmaProject
{
    partial class frmStore
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnStoreName = new System.Windows.Forms.RadioButton();
            this.rbtnStorePhons = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtStoreNr = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbStorPhon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbStAdr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbStName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbStNr = new System.Windows.Forms.TextBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDele = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.btnClose);
            this.pnlSearch.Controls.Add(this.dgvSearch);
            this.pnlSearch.Controls.Add(this.btnShowSearch);
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txbSearch);
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Location = new System.Drawing.Point(8, 393);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(830, 416);
            this.pnlSearch.TabIndex = 131;
            this.pnlSearch.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(777, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(10, 152);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(807, 185);
            this.dgvSearch.TabIndex = 11;
            // 
            // btnShowSearch
            // 
            this.btnShowSearch.Location = new System.Drawing.Point(661, 118);
            this.btnShowSearch.Name = "btnShowSearch";
            this.btnShowSearch.Size = new System.Drawing.Size(122, 27);
            this.btnShowSearch.TabIndex = 10;
            this.btnShowSearch.Text = "Search";
            this.btnShowSearch.UseVisualStyleBackColor = true;
            this.btnShowSearch.Click += new System.EventHandler(this.btnShowSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Word Search";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(179, 119);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(444, 26);
            this.txbSearch.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnStoreName);
            this.groupBox1.Controls.Add(this.rbtnStorePhons);
            this.groupBox1.Controls.Add(this.rbtnAdd);
            this.groupBox1.Controls.Add(this.rbtStoreNr);
            this.groupBox1.Location = new System.Drawing.Point(10, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // rbtnStoreName
            // 
            this.rbtnStoreName.AutoSize = true;
            this.rbtnStoreName.Location = new System.Drawing.Point(158, 25);
            this.rbtnStoreName.Name = "rbtnStoreName";
            this.rbtnStoreName.Size = new System.Drawing.Size(122, 24);
            this.rbtnStoreName.TabIndex = 4;
            this.rbtnStoreName.Text = "Store Name";
            this.rbtnStoreName.UseVisualStyleBackColor = true;
            // 
            // rbtnStorePhons
            // 
            this.rbtnStorePhons.AutoSize = true;
            this.rbtnStorePhons.Location = new System.Drawing.Point(483, 25);
            this.rbtnStorePhons.Name = "rbtnStorePhons";
            this.rbtnStorePhons.Size = new System.Drawing.Size(77, 24);
            this.rbtnStorePhons.TabIndex = 2;
            this.rbtnStorePhons.Text = "Phons";
            this.rbtnStorePhons.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(331, 25);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(93, 24);
            this.rbtnAdd.TabIndex = 1;
            this.rbtnAdd.Text = "Address";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtStoreNr
            // 
            this.rbtStoreNr.AutoSize = true;
            this.rbtStoreNr.Checked = true;
            this.rbtStoreNr.Location = new System.Drawing.Point(6, 25);
            this.rbtStoreNr.Name = "rbtStoreNr";
            this.rbtStoreNr.Size = new System.Drawing.Size(94, 24);
            this.rbtStoreNr.TabIndex = 0;
            this.rbtStoreNr.TabStop = true;
            this.rbtStoreNr.Text = "Store Nr";
            this.rbtStoreNr.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Store search";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnLast);
            this.pnlData.Controls.Add(this.btnFirst);
            this.pnlData.Controls.Add(this.btnNext);
            this.pnlData.Controls.Add(this.btnPrev);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.txbStorPhon);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.txbStAdr);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.txbStName);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.txbStNr);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Location = new System.Drawing.Point(8, 12);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(830, 375);
            this.pnlData.TabIndex = 132;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Red;
            this.btnLast.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLast.Location = new System.Drawing.Point(660, 103);
            this.btnLast.Margin = new System.Windows.Forms.Padding(1);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 20);
            this.btnLast.TabIndex = 146;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Red;
            this.btnFirst.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFirst.Location = new System.Drawing.Point(594, 70);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(1);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 20);
            this.btnFirst.TabIndex = 145;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Red;
            this.btnNext.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNext.Location = new System.Drawing.Point(660, 70);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 20);
            this.btnNext.TabIndex = 144;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Red;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPrev.Location = new System.Drawing.Point(594, 104);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(1);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 20);
            this.btnPrev.TabIndex = 143;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 34);
            this.label6.TabIndex = 140;
            this.label6.Text = "Phons";
            // 
            // txbStorPhon
            // 
            this.txbStorPhon.Location = new System.Drawing.Point(149, 172);
            this.txbStorPhon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbStorPhon.Name = "txbStorPhon";
            this.txbStorPhon.Size = new System.Drawing.Size(353, 26);
            this.txbStorPhon.TabIndex = 139;
            this.txbStorPhon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbStorPhon_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 34);
            this.label5.TabIndex = 138;
            this.label5.Text = "Adress";
            // 
            // txbStAdr
            // 
            this.txbStAdr.Location = new System.Drawing.Point(149, 138);
            this.txbStAdr.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbStAdr.Name = "txbStAdr";
            this.txbStAdr.Size = new System.Drawing.Size(353, 26);
            this.txbStAdr.TabIndex = 137;
            this.txbStAdr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbStAdr_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 34);
            this.label3.TabIndex = 136;
            this.label3.Text = "Store Name";
            // 
            // txbStName
            // 
            this.txbStName.Location = new System.Drawing.Point(149, 101);
            this.txbStName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbStName.Name = "txbStName";
            this.txbStName.Size = new System.Drawing.Size(353, 26);
            this.txbStName.TabIndex = 135;
            this.txbStName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbStName_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 34);
            this.label1.TabIndex = 134;
            this.label1.Text = "Store Number";
            // 
            // txbStNr
            // 
            this.txbStNr.Location = new System.Drawing.Point(149, 70);
            this.txbStNr.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbStNr.Name = "txbStNr";
            this.txbStNr.ReadOnly = true;
            this.txbStNr.Size = new System.Drawing.Size(183, 26);
            this.txbStNr.TabIndex = 133;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Controls.Add(this.btnEdit);
            this.pnlControls.Controls.Add(this.btnSearch);
            this.pnlControls.Controls.Add(this.btnDele);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Location = new System.Drawing.Point(85, 249);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(645, 68);
            this.pnlControls.TabIndex = 132;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(108, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 36);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(212, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDele
            // 
            this.btnDele.Location = new System.Drawing.Point(320, 15);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(83, 36);
            this.btnDele.TabIndex = 2;
            this.btnDele.Text = "Delete";
            this.btnDele.UseVisualStyleBackColor = true;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(424, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 36);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 46);
            this.label2.TabIndex = 131;
            this.label2.Text = "Store";
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 431);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmStore";
            this.Text = "Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStore_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnStoreName;
        private System.Windows.Forms.RadioButton rbtnStorePhons;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtStoreNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbStorPhon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbStAdr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbStNr;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
    }
}