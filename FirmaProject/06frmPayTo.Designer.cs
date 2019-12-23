namespace FirmaProject
{
    partial class frmPayTo
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAmount = new System.Windows.Forms.RadioButton();
            this.rbtnCustNr = new System.Windows.Forms.RadioButton();
            this.rbtnPaydate = new System.Windows.Forms.RadioButton();
            this.rbtnPerson = new System.Windows.Forms.RadioButton();
            this.rbtActionNr = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPerson = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtActionNr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbBuyDesc = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbxBuyCus = new System.Windows.Forms.ComboBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDele = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.txbSearch);
            this.pnlSearch.Controls.Add(this.btnClose);
            this.pnlSearch.Controls.Add(this.dgvSearch);
            this.pnlSearch.Controls.Add(this.btnShowSearch);
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Controls.Add(this.label12);
            this.pnlSearch.Location = new System.Drawing.Point(3, 395);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(830, 416);
            this.pnlSearch.TabIndex = 103;
            this.pnlSearch.Visible = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(163, 117);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(444, 26);
            this.txbSearch.TabIndex = 14;
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
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
            this.btnShowSearch.Location = new System.Drawing.Point(662, 117);
            this.btnShowSearch.Name = "btnShowSearch";
            this.btnShowSearch.Size = new System.Drawing.Size(102, 28);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAmount);
            this.groupBox1.Controls.Add(this.rbtnCustNr);
            this.groupBox1.Controls.Add(this.rbtnPaydate);
            this.groupBox1.Controls.Add(this.rbtnPerson);
            this.groupBox1.Controls.Add(this.rbtActionNr);
            this.groupBox1.Location = new System.Drawing.Point(10, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // rbtnAmount
            // 
            this.rbtnAmount.AutoSize = true;
            this.rbtnAmount.Location = new System.Drawing.Point(413, 26);
            this.rbtnAmount.Name = "rbtnAmount";
            this.rbtnAmount.Size = new System.Drawing.Size(67, 24);
            this.rbtnAmount.TabIndex = 15;
            this.rbtnAmount.Text = "Price";
            this.rbtnAmount.UseVisualStyleBackColor = true;
            // 
            // rbtnCustNr
            // 
            this.rbtnCustNr.AutoSize = true;
            this.rbtnCustNr.Location = new System.Drawing.Point(133, 25);
            this.rbtnCustNr.Name = "rbtnCustNr";
            this.rbtnCustNr.Size = new System.Drawing.Size(87, 24);
            this.rbtnCustNr.TabIndex = 4;
            this.rbtnCustNr.Text = "Cust Nr";
            this.rbtnCustNr.UseVisualStyleBackColor = true;
            // 
            // rbtnPaydate
            // 
            this.rbtnPaydate.AutoSize = true;
            this.rbtnPaydate.Location = new System.Drawing.Point(283, 25);
            this.rbtnPaydate.Name = "rbtnPaydate";
            this.rbtnPaydate.Size = new System.Drawing.Size(58, 24);
            this.rbtnPaydate.TabIndex = 3;
            this.rbtnPaydate.Text = "Day";
            this.rbtnPaydate.UseVisualStyleBackColor = true;
            // 
            // rbtnPerson
            // 
            this.rbtnPerson.AutoSize = true;
            this.rbtnPerson.Location = new System.Drawing.Point(528, 26);
            this.rbtnPerson.Name = "rbtnPerson";
            this.rbtnPerson.Size = new System.Drawing.Size(83, 24);
            this.rbtnPerson.TabIndex = 1;
            this.rbtnPerson.Text = "Person";
            this.rbtnPerson.UseVisualStyleBackColor = true;
            // 
            // rbtActionNr
            // 
            this.rbtActionNr.AutoSize = true;
            this.rbtActionNr.Checked = true;
            this.rbtActionNr.Location = new System.Drawing.Point(7, 25);
            this.rbtActionNr.Name = "rbtActionNr";
            this.rbtActionNr.Size = new System.Drawing.Size(101, 24);
            this.rbtActionNr.TabIndex = 0;
            this.rbtActionNr.TabStop = true;
            this.rbtActionNr.Text = "Action Nr";
            this.rbtActionNr.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(308, 46);
            this.label12.TabIndex = 3;
            this.label12.Text = "Customer search";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.txbPerson);
            this.pnlData.Controls.Add(this.btnLast);
            this.pnlData.Controls.Add(this.btnFirst);
            this.pnlData.Controls.Add(this.btnNext);
            this.pnlData.Controls.Add(this.btnPrev);
            this.pnlData.Controls.Add(this.label9);
            this.pnlData.Controls.Add(this.txtActionNr);
            this.pnlData.Controls.Add(this.label8);
            this.pnlData.Controls.Add(this.txbBuyDesc);
            this.pnlData.Controls.Add(this.dtpDate);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.textBox3);
            this.pnlData.Controls.Add(this.cbxBuyCus);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.nudAmount);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(3, 7);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(838, 382);
            this.pnlData.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 124;
            this.label4.Text = "Custname";
            // 
            // txbPerson
            // 
            this.txbPerson.Location = new System.Drawing.Point(147, 112);
            this.txbPerson.Name = "txbPerson";
            this.txbPerson.Size = new System.Drawing.Size(166, 26);
            this.txbPerson.TabIndex = 123;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Red;
            this.btnLast.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLast.Location = new System.Drawing.Point(623, 89);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 20);
            this.btnLast.TabIndex = 122;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Red;
            this.btnFirst.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFirst.Location = new System.Drawing.Point(558, 57);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 20);
            this.btnFirst.TabIndex = 121;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Red;
            this.btnNext.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNext.Location = new System.Drawing.Point(623, 57);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 20);
            this.btnNext.TabIndex = 120;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Red;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPrev.Location = new System.Drawing.Point(558, 91);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 20);
            this.btnPrev.TabIndex = 119;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 118;
            this.label9.Text = "Action Nr";
            // 
            // txtActionNr
            // 
            this.txtActionNr.Location = new System.Drawing.Point(147, 25);
            this.txtActionNr.Name = "txtActionNr";
            this.txtActionNr.ReadOnly = true;
            this.txtActionNr.Size = new System.Drawing.Size(166, 26);
            this.txtActionNr.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 34);
            this.label8.TabIndex = 114;
            this.label8.Text = "Description";
            // 
            // txbBuyDesc
            // 
            this.txbBuyDesc.Location = new System.Drawing.Point(148, 218);
            this.txbBuyDesc.Margin = new System.Windows.Forms.Padding(5);
            this.txbBuyDesc.Multiline = true;
            this.txbBuyDesc.Name = "txbBuyDesc";
            this.txbBuyDesc.Size = new System.Drawing.Size(646, 82);
            this.txbBuyDesc.TabIndex = 113;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(148, 148);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(164, 26);
            this.dtpDate.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 109;
            this.label7.Text = " Date";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 148);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 26);
            this.textBox3.TabIndex = 108;
            // 
            // cbxBuyCus
            // 
            this.cbxBuyCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuyCus.FormattingEnabled = true;
            this.cbxBuyCus.Location = new System.Drawing.Point(148, 57);
            this.cbxBuyCus.Name = "cbxBuyCus";
            this.cbxBuyCus.Size = new System.Drawing.Size(352, 28);
            this.cbxBuyCus.TabIndex = 105;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Controls.Add(this.btnEdit);
            this.pnlControls.Controls.Add(this.btnSearch);
            this.pnlControls.Controls.Add(this.btnDele);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Location = new System.Drawing.Point(148, 311);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(645, 68);
            this.pnlControls.TabIndex = 104;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(108, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(212, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDele
            // 
            this.btnDele.Location = new System.Drawing.Point(320, 15);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(83, 35);
            this.btnDele.TabIndex = 2;
            this.btnDele.Text = "Delete";
            this.btnDele.UseVisualStyleBackColor = true;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(423, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(148, 178);
            this.nudAmount.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(163, 26);
            this.nudAmount.TabIndex = 103;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 102;
            this.label5.Text = "Amount";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 46);
            this.label2.TabIndex = 99;
            this.label2.Text = "Payment";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 34);
            this.label1.TabIndex = 98;
            this.label1.Text = "Customer";
            // 
            // frmPayTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 749);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmPayTo";
            this.Text = "frmPayTo";
            this.Load += new System.EventHandler(this.frmPayTo_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAmount;
        private System.Windows.Forms.RadioButton rbtnCustNr;
        private System.Windows.Forms.RadioButton rbtnPaydate;
        private System.Windows.Forms.RadioButton rbtnPerson;
        private System.Windows.Forms.RadioButton rbtActionNr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPerson;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtActionNr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbBuyDesc;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbxBuyCus;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}