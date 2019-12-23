namespace FirmaProject
{
    partial class frmBuy
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
            this.btnCreateView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnQty = new System.Windows.Forms.RadioButton();
            this.rbtnPrice = new System.Windows.Forms.RadioButton();
            this.rbtnItemNa = new System.Windows.Forms.RadioButton();
            this.rbtnCustName = new System.Windows.Forms.RadioButton();
            this.rbtItemNr = new System.Windows.Forms.RadioButton();
            this.rbtnStart = new System.Windows.Forms.RadioButton();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtCustNr = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtActionNr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbBuyTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbBuyDesc = new System.Windows.Forms.TextBox();
            this.nudBuyQuan = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.cbxBuyItem = new System.Windows.Forms.ComboBox();
            this.cbxBuyCus = new System.Windows.Forms.ComboBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDele = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudPriceBuy = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyQuan)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.btnCreateView);
            this.pnlSearch.Controls.Add(this.btnClose);
            this.pnlSearch.Controls.Add(this.dgvSearch);
            this.pnlSearch.Controls.Add(this.btnShowSearch);
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txbSearch);
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Controls.Add(this.label12);
            this.pnlSearch.Location = new System.Drawing.Point(3, 425);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(830, 416);
            this.pnlSearch.TabIndex = 98;
            this.pnlSearch.Visible = false;
            // 
            // btnCreateView
            // 
            this.btnCreateView.Location = new System.Drawing.Point(718, 117);
            this.btnCreateView.Name = "btnCreateView";
            this.btnCreateView.Size = new System.Drawing.Size(92, 27);
            this.btnCreateView.TabIndex = 13;
            this.btnCreateView.Text = "View";
            this.btnCreateView.UseVisualStyleBackColor = true;
            this.btnCreateView.Click += new System.EventHandler(this.btnCreateView_Click);
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
            this.btnShowSearch.Location = new System.Drawing.Point(597, 117);
            this.btnShowSearch.Name = "btnShowSearch";
            this.btnShowSearch.Size = new System.Drawing.Size(102, 27);
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
            this.txbSearch.Location = new System.Drawing.Point(145, 118);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(444, 26);
            this.txbSearch.TabIndex = 8;
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnQty);
            this.groupBox1.Controls.Add(this.rbtnPrice);
            this.groupBox1.Controls.Add(this.rbtnItemNa);
            this.groupBox1.Controls.Add(this.rbtnCustName);
            this.groupBox1.Controls.Add(this.rbtItemNr);
            this.groupBox1.Controls.Add(this.rbtnStart);
            this.groupBox1.Controls.Add(this.rbtnEmail);
            this.groupBox1.Controls.Add(this.rbtnAdd);
            this.groupBox1.Controls.Add(this.rbtCustNr);
            this.groupBox1.Location = new System.Drawing.Point(10, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // rbtnQty
            // 
            this.rbtnQty.AutoSize = true;
            this.rbtnQty.Location = new System.Drawing.Point(649, 25);
            this.rbtnQty.Name = "rbtnQty";
            this.rbtnQty.Size = new System.Drawing.Size(54, 24);
            this.rbtnQty.TabIndex = 16;
            this.rbtnQty.Text = "Qty";
            this.rbtnQty.UseVisualStyleBackColor = true;
            // 
            // rbtnPrice
            // 
            this.rbtnPrice.AutoSize = true;
            this.rbtnPrice.Location = new System.Drawing.Point(583, 25);
            this.rbtnPrice.Name = "rbtnPrice";
            this.rbtnPrice.Size = new System.Drawing.Size(67, 24);
            this.rbtnPrice.TabIndex = 15;
            this.rbtnPrice.Text = "Price";
            this.rbtnPrice.UseVisualStyleBackColor = true;
            // 
            // rbtnItemNa
            // 
            this.rbtnItemNa.AutoSize = true;
            this.rbtnItemNa.Location = new System.Drawing.Point(319, 25);
            this.rbtnItemNa.Name = "rbtnItemNa";
            this.rbtnItemNa.Size = new System.Drawing.Size(114, 24);
            this.rbtnItemNa.TabIndex = 14;
            this.rbtnItemNa.Text = "Item Name";
            this.rbtnItemNa.UseVisualStyleBackColor = true;
            // 
            // rbtnCustName
            // 
            this.rbtnCustName.AutoSize = true;
            this.rbtnCustName.Location = new System.Drawing.Point(99, 26);
            this.rbtnCustName.Name = "rbtnCustName";
            this.rbtnCustName.Size = new System.Drawing.Size(115, 24);
            this.rbtnCustName.TabIndex = 4;
            this.rbtnCustName.Text = "Cust Name";
            this.rbtnCustName.UseVisualStyleBackColor = true;
            // 
            // rbtItemNr
            // 
            this.rbtItemNr.AutoSize = true;
            this.rbtItemNr.Checked = true;
            this.rbtItemNr.Location = new System.Drawing.Point(227, 25);
            this.rbtItemNr.Name = "rbtItemNr";
            this.rbtItemNr.Size = new System.Drawing.Size(86, 24);
            this.rbtItemNr.TabIndex = 13;
            this.rbtItemNr.TabStop = true;
            this.rbtItemNr.Text = "Item Nr";
            this.rbtItemNr.UseVisualStyleBackColor = true;
            // 
            // rbtnStart
            // 
            this.rbtnStart.AutoSize = true;
            this.rbtnStart.Location = new System.Drawing.Point(439, 25);
            this.rbtnStart.Name = "rbtnStart";
            this.rbtnStart.Size = new System.Drawing.Size(58, 24);
            this.rbtnStart.TabIndex = 3;
            this.rbtnStart.Text = "Day";
            this.rbtnStart.UseVisualStyleBackColor = true;
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Location = new System.Drawing.Point(508, 26);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(71, 24);
            this.rbtnEmail.TabIndex = 2;
            this.rbtnEmail.Text = "Email";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(708, 26);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(93, 24);
            this.rbtnAdd.TabIndex = 1;
            this.rbtnAdd.Text = "Address";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtCustNr
            // 
            this.rbtCustNr.AutoSize = true;
            this.rbtCustNr.Checked = true;
            this.rbtCustNr.Location = new System.Drawing.Point(6, 25);
            this.rbtCustNr.Name = "rbtCustNr";
            this.rbtCustNr.Size = new System.Drawing.Size(87, 24);
            this.rbtCustNr.TabIndex = 0;
            this.rbtCustNr.TabStop = true;
            this.rbtCustNr.Text = "Cust Nr";
            this.rbtCustNr.UseVisualStyleBackColor = true;
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
            this.pnlData.Controls.Add(this.btnLast);
            this.pnlData.Controls.Add(this.btnFirst);
            this.pnlData.Controls.Add(this.btnNext);
            this.pnlData.Controls.Add(this.btnPrev);
            this.pnlData.Controls.Add(this.label9);
            this.pnlData.Controls.Add(this.txtActionNr);
            this.pnlData.Controls.Add(this.label10);
            this.pnlData.Controls.Add(this.txbBuyTotal);
            this.pnlData.Controls.Add(this.label8);
            this.pnlData.Controls.Add(this.txbBuyDesc);
            this.pnlData.Controls.Add(this.nudBuyQuan);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.dtpDate);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.textBox3);
            this.pnlData.Controls.Add(this.cbxDate);
            this.pnlData.Controls.Add(this.cbxBuyItem);
            this.pnlData.Controls.Add(this.cbxBuyCus);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.nudPriceBuy);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(3, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(839, 416);
            this.pnlData.TabIndex = 99;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Red;
            this.btnLast.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLast.Location = new System.Drawing.Point(624, 90);
            this.btnLast.Margin = new System.Windows.Forms.Padding(1);
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
            this.btnFirst.Margin = new System.Windows.Forms.Padding(1);
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
            this.btnNext.Location = new System.Drawing.Point(624, 57);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
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
            this.btnPrev.Margin = new System.Windows.Forms.Padding(1);
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
            this.label9.Location = new System.Drawing.Point(20, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 18);
            this.label9.TabIndex = 118;
            this.label9.Text = "Action Nr";
            // 
            // txtActionNr
            // 
            this.txtActionNr.Location = new System.Drawing.Point(147, 25);
            this.txtActionNr.Name = "txtActionNr";
            this.txtActionNr.ReadOnly = true;
            this.txtActionNr.Size = new System.Drawing.Size(165, 26);
            this.txtActionNr.TabIndex = 117;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(365, 173);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 34);
            this.label10.TabIndex = 116;
            this.label10.Text = "Total";
            // 
            // txbBuyTotal
            // 
            this.txbBuyTotal.Location = new System.Drawing.Point(478, 173);
            this.txbBuyTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbBuyTotal.Name = "txbBuyTotal";
            this.txbBuyTotal.ReadOnly = true;
            this.txbBuyTotal.Size = new System.Drawing.Size(145, 26);
            this.txbBuyTotal.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 34);
            this.label8.TabIndex = 114;
            this.label8.Text = "Description";
            // 
            // txbBuyDesc
            // 
            this.txbBuyDesc.Location = new System.Drawing.Point(148, 269);
            this.txbBuyDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbBuyDesc.Multiline = true;
            this.txbBuyDesc.Name = "txbBuyDesc";
            this.txbBuyDesc.Size = new System.Drawing.Size(645, 82);
            this.txbBuyDesc.TabIndex = 113;
            // 
            // nudBuyQuan
            // 
            this.nudBuyQuan.Location = new System.Drawing.Point(148, 235);
            this.nudBuyQuan.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudBuyQuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBuyQuan.Name = "nudBuyQuan";
            this.nudBuyQuan.Size = new System.Drawing.Size(164, 26);
            this.nudBuyQuan.TabIndex = 112;
            this.nudBuyQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBuyQuan.ValueChanged += new System.EventHandler(this.nudBuyQuan_ValueChanged_1);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 111;
            this.label6.Text = "Quanitay";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(148, 171);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(164, 26);
            this.dtpDate.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 109;
            this.label7.Text = " Date";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 171);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 26);
            this.textBox3.TabIndex = 108;
            // 
            // cbxDate
            // 
            this.cbxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbxDate.Location = new System.Drawing.Point(148, 136);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(353, 28);
            this.cbxDate.TabIndex = 107;
            // 
            // cbxBuyItem
            // 
            this.cbxBuyItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuyItem.FormattingEnabled = true;
            this.cbxBuyItem.Location = new System.Drawing.Point(148, 97);
            this.cbxBuyItem.Name = "cbxBuyItem";
            this.cbxBuyItem.Size = new System.Drawing.Size(353, 28);
            this.cbxBuyItem.TabIndex = 106;
            // 
            // cbxBuyCus
            // 
            this.cbxBuyCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuyCus.FormattingEnabled = true;
            this.cbxBuyCus.Location = new System.Drawing.Point(148, 57);
            this.cbxBuyCus.Name = "cbxBuyCus";
            this.cbxBuyCus.Size = new System.Drawing.Size(353, 28);
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
            this.pnlControls.Location = new System.Drawing.Point(148, 345);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(645, 68);
            this.pnlControls.TabIndex = 104;
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
            // nudPriceBuy
            // 
            this.nudPriceBuy.Location = new System.Drawing.Point(148, 202);
            this.nudPriceBuy.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudPriceBuy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPriceBuy.Name = "nudPriceBuy";
            this.nudPriceBuy.Size = new System.Drawing.Size(164, 26);
            this.nudPriceBuy.TabIndex = 103;
            this.nudPriceBuy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPriceBuy.ValueChanged += new System.EventHandler(this.nudPriceBuy_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 102;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 34);
            this.label4.TabIndex = 101;
            this.label4.Text = "Day";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 34);
            this.label3.TabIndex = 100;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 46);
            this.label2.TabIndex = 99;
            this.label2.Text = "Buy";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 98;
            this.label1.Text = "Customer";
            // 
            // frmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 749);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBuy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.frmBuy_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyQuan)).EndInit();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceBuy)).EndInit();
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
        private System.Windows.Forms.RadioButton rbtnCustName;
        private System.Windows.Forms.RadioButton rbtnStart;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtCustNr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreateView;
        private System.Windows.Forms.RadioButton rbtnItemNa;
        private System.Windows.Forms.RadioButton rbtItemNr;
        private System.Windows.Forms.RadioButton rbtnQty;
        private System.Windows.Forms.RadioButton rbtnPrice;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtActionNr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbBuyTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbBuyDesc;
        private System.Windows.Forms.NumericUpDown nudBuyQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbxDate;
        private System.Windows.Forms.ComboBox cbxBuyItem;
        private System.Windows.Forms.ComboBox cbxBuyCus;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudPriceBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}