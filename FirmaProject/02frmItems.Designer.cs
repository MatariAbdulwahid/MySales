namespace FirmaProject
{
    partial class frmItems
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbItSym = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbItemNr = new System.Windows.Forms.TextBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnItemExit = new System.Windows.Forms.Button();
            this.btnItemEdit = new System.Windows.Forms.Button();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.btnItemDele = new System.Windows.Forms.Button();
            this.btnItemClear = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.nUdItemPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnItemNa = new System.Windows.Forms.RadioButton();
            this.rbtnSym = new System.Windows.Forms.RadioButton();
            this.rbtnPrice = new System.Windows.Forms.RadioButton();
            this.rbtItemNr = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdItemPrice)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sympol";
            // 
            // txbItSym
            // 
            this.txbItSym.Location = new System.Drawing.Point(137, 135);
            this.txbItSym.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbItSym.Name = "txbItSym";
            this.txbItSym.Size = new System.Drawing.Size(353, 26);
            this.txbItSym.TabIndex = 5;
            this.txbItSym.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbItSym_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name";
            // 
            // txbItemName
            // 
            this.txbItemName.Location = new System.Drawing.Point(137, 102);
            this.txbItemName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.Size = new System.Drawing.Size(353, 26);
            this.txbItemName.TabIndex = 3;
            this.txbItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbItemName_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Items";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items Number";
            // 
            // txbItemNr
            // 
            this.txbItemNr.Location = new System.Drawing.Point(137, 68);
            this.txbItemNr.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbItemNr.Name = "txbItemNr";
            this.txbItemNr.ReadOnly = true;
            this.txbItemNr.Size = new System.Drawing.Size(177, 26);
            this.txbItemNr.TabIndex = 0;
            this.txbItemNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbItemNr_KeyDown);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnLast);
            this.pnlData.Controls.Add(this.btnFirst);
            this.pnlData.Controls.Add(this.btnNext);
            this.pnlData.Controls.Add(this.btnPrev);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.nUdItemPrice);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.txbItSym);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.txbItemName);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.txbItemNr);
            this.pnlData.Location = new System.Drawing.Point(14, 13);
            this.pnlData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(827, 366);
            this.pnlData.TabIndex = 1;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Red;
            this.btnLast.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLast.Location = new System.Drawing.Point(612, 109);
            this.btnLast.Margin = new System.Windows.Forms.Padding(1);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 20);
            this.btnLast.TabIndex = 35;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Red;
            this.btnFirst.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFirst.Location = new System.Drawing.Point(546, 76);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(1);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 20);
            this.btnFirst.TabIndex = 34;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Red;
            this.btnNext.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNext.Location = new System.Drawing.Point(612, 76);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 20);
            this.btnNext.TabIndex = 33;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Red;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPrev.Location = new System.Drawing.Point(546, 110);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(1);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 20);
            this.btnPrev.TabIndex = 32;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnItemExit);
            this.pnlControls.Controls.Add(this.btnItemEdit);
            this.pnlControls.Controls.Add(this.btnItemSearch);
            this.pnlControls.Controls.Add(this.btnItemDele);
            this.pnlControls.Controls.Add(this.btnItemClear);
            this.pnlControls.Controls.Add(this.btnItemAdd);
            this.pnlControls.Location = new System.Drawing.Point(72, 246);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(645, 68);
            this.pnlControls.TabIndex = 26;
            // 
            // btnItemExit
            // 
            this.btnItemExit.Location = new System.Drawing.Point(540, 15);
            this.btnItemExit.Name = "btnItemExit";
            this.btnItemExit.Size = new System.Drawing.Size(85, 36);
            this.btnItemExit.TabIndex = 5;
            this.btnItemExit.Text = "Exit";
            this.btnItemExit.UseVisualStyleBackColor = true;
            this.btnItemExit.Click += new System.EventHandler(this.btnItemExit_Click);
            // 
            // btnItemEdit
            // 
            this.btnItemEdit.Location = new System.Drawing.Point(108, 15);
            this.btnItemEdit.Name = "btnItemEdit";
            this.btnItemEdit.Size = new System.Drawing.Size(86, 36);
            this.btnItemEdit.TabIndex = 4;
            this.btnItemEdit.Text = "Edit";
            this.btnItemEdit.UseVisualStyleBackColor = true;
            this.btnItemEdit.Click += new System.EventHandler(this.btnItemEdit_Click);
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Location = new System.Drawing.Point(212, 15);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(90, 36);
            this.btnItemSearch.TabIndex = 3;
            this.btnItemSearch.Text = "Search";
            this.btnItemSearch.UseVisualStyleBackColor = true;
            this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
            // 
            // btnItemDele
            // 
            this.btnItemDele.Location = new System.Drawing.Point(320, 15);
            this.btnItemDele.Name = "btnItemDele";
            this.btnItemDele.Size = new System.Drawing.Size(83, 36);
            this.btnItemDele.TabIndex = 2;
            this.btnItemDele.Text = "Delete";
            this.btnItemDele.UseVisualStyleBackColor = true;
            this.btnItemDele.Click += new System.EventHandler(this.btnItemDele_Click);
            // 
            // btnItemClear
            // 
            this.btnItemClear.Location = new System.Drawing.Point(424, 15);
            this.btnItemClear.Name = "btnItemClear";
            this.btnItemClear.Size = new System.Drawing.Size(91, 36);
            this.btnItemClear.TabIndex = 1;
            this.btnItemClear.Text = "Clear";
            this.btnItemClear.UseVisualStyleBackColor = true;
            this.btnItemClear.Click += new System.EventHandler(this.btnItemClear_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(0, 15);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(90, 36);
            this.btnItemAdd.TabIndex = 0;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // nUdItemPrice
            // 
            this.nUdItemPrice.Location = new System.Drawing.Point(137, 170);
            this.nUdItemPrice.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nUdItemPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUdItemPrice.Name = "nUdItemPrice";
            this.nUdItemPrice.Size = new System.Drawing.Size(353, 26);
            this.nUdItemPrice.TabIndex = 13;
            this.nUdItemPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUdItemPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nUdItemPrice_KeyDown);
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
            this.pnlSearch.Controls.Add(this.label10);
            this.pnlSearch.Location = new System.Drawing.Point(14, 376);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(830, 416);
            this.pnlSearch.TabIndex = 36;
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
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnItemNa);
            this.groupBox1.Controls.Add(this.rbtnSym);
            this.groupBox1.Controls.Add(this.rbtnPrice);
            this.groupBox1.Controls.Add(this.rbtItemNr);
            this.groupBox1.Location = new System.Drawing.Point(10, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // rbtnItemNa
            // 
            this.rbtnItemNa.AutoSize = true;
            this.rbtnItemNa.Location = new System.Drawing.Point(158, 25);
            this.rbtnItemNa.Name = "rbtnItemNa";
            this.rbtnItemNa.Size = new System.Drawing.Size(114, 24);
            this.rbtnItemNa.TabIndex = 4;
            this.rbtnItemNa.Text = "Item Name";
            this.rbtnItemNa.UseVisualStyleBackColor = true;
            // 
            // rbtnSym
            // 
            this.rbtnSym.AutoSize = true;
            this.rbtnSym.Location = new System.Drawing.Point(348, 25);
            this.rbtnSym.Name = "rbtnSym";
            this.rbtnSym.Size = new System.Drawing.Size(85, 24);
            this.rbtnSym.TabIndex = 3;
            this.rbtnSym.Text = "Symbol";
            this.rbtnSym.UseVisualStyleBackColor = true;
            // 
            // rbtnPrice
            // 
            this.rbtnPrice.AutoSize = true;
            this.rbtnPrice.Location = new System.Drawing.Point(496, 25);
            this.rbtnPrice.Name = "rbtnPrice";
            this.rbtnPrice.Size = new System.Drawing.Size(67, 24);
            this.rbtnPrice.TabIndex = 2;
            this.rbtnPrice.Text = "Price";
            this.rbtnPrice.UseVisualStyleBackColor = true;
            // 
            // rbtItemNr
            // 
            this.rbtItemNr.AutoSize = true;
            this.rbtItemNr.Checked = true;
            this.rbtItemNr.Location = new System.Drawing.Point(6, 25);
            this.rbtItemNr.Name = "rbtItemNr";
            this.rbtItemNr.Size = new System.Drawing.Size(86, 24);
            this.rbtItemNr.TabIndex = 0;
            this.rbtItemNr.TabStop = true;
            this.rbtItemNr.Text = "Item Nr";
            this.rbtItemNr.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(308, 46);
            this.label10.TabIndex = 3;
            this.label10.Text = "Item search";
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(845, 598);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmItems";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUdItemPrice)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbItSym;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbItemNr;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.NumericUpDown nUdItemPrice;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnItemExit;
        private System.Windows.Forms.Button btnItemEdit;
        private System.Windows.Forms.Button btnItemSearch;
        private System.Windows.Forms.Button btnItemDele;
        private System.Windows.Forms.Button btnItemClear;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnItemNa;
        private System.Windows.Forms.RadioButton rbtnSym;
        private System.Windows.Forms.RadioButton rbtnPrice;
        private System.Windows.Forms.RadioButton rbtItemNr;
        private System.Windows.Forms.Label label10;
    }
}