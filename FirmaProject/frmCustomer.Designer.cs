namespace FirmaProject
{
    partial class frmCustomer
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
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnPhonRem = new System.Windows.Forms.Button();
            this.btnPhonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDele = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpCudate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCuAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCuEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCNr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCustName = new System.Windows.Forms.RadioButton();
            this.rbtnStart = new System.Windows.Forms.RadioButton();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtCustNr = new System.Windows.Forms.RadioButton();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlData.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.SystemColors.Control;
            this.pnlData.Controls.Add(this.btnLast);
            this.pnlData.Controls.Add(this.btnFirst);
            this.pnlData.Controls.Add(this.btnNext);
            this.pnlData.Controls.Add(this.btnPrev);
            this.pnlData.Controls.Add(this.label9);
            this.pnlData.Controls.Add(this.panel1);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.dtpCudate);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.txbCuAd);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.txbCuEmail);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.textBox3);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.txbCName);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.txbCNr);
            this.pnlData.Location = new System.Drawing.Point(10, 7);
            this.pnlData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(830, 416);
            this.pnlData.TabIndex = 0;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Red;
            this.btnLast.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLast.Location = new System.Drawing.Point(702, 95);
            this.btnLast.Margin = new System.Windows.Forms.Padding(1);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 20);
            this.btnLast.TabIndex = 31;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Red;
            this.btnFirst.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFirst.Location = new System.Drawing.Point(636, 62);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(1);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 20);
            this.btnFirst.TabIndex = 30;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Red;
            this.btnNext.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNext.Location = new System.Drawing.Point(702, 62);
            this.btnNext.Margin = new System.Windows.Forms.Padding(1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 20);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Red;
            this.btnPrev.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPrev.Location = new System.Drawing.Point(636, 96);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(1);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 20);
            this.btnPrev.TabIndex = 28;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(5, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 34);
            this.label9.TabIndex = 27;
            this.label9.Text = "Phones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgvPhones);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.btnPhonRem);
            this.panel1.Controls.Add(this.btnPhonAdd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbPhone);
            this.panel1.Location = new System.Drawing.Point(132, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 144);
            this.panel1.TabIndex = 26;
            // 
            // dgvPhones
            // 
            this.dgvPhones.AllowUserToDeleteRows = false;
            this.dgvPhones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhone,
            this.colType});
            this.dgvPhones.Location = new System.Drawing.Point(193, 3);
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.Size = new System.Drawing.Size(427, 138);
            this.dgvPhones.TabIndex = 17;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPhone.HeaderText = "phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 120;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Vodafone",
            "O2",
            "Telekom",
            "Debtal",
            "Blau"});
            this.cbType.Location = new System.Drawing.Point(3, 82);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(179, 27);
            this.cbType.TabIndex = 16;
            // 
            // btnPhonRem
            // 
            this.btnPhonRem.Location = new System.Drawing.Point(84, 115);
            this.btnPhonRem.Name = "btnPhonRem";
            this.btnPhonRem.Size = new System.Drawing.Size(96, 26);
            this.btnPhonRem.TabIndex = 15;
            this.btnPhonRem.Text = "Remove";
            this.btnPhonRem.UseVisualStyleBackColor = true;
            this.btnPhonRem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPhonAdd
            // 
            this.btnPhonAdd.Location = new System.Drawing.Point(3, 115);
            this.btnPhonAdd.Name = "btnPhonAdd";
            this.btnPhonAdd.Size = new System.Drawing.Size(75, 26);
            this.btnPhonAdd.TabIndex = 14;
            this.btnPhonAdd.Text = "Add";
            this.btnPhonAdd.UseVisualStyleBackColor = true;
            this.btnPhonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Type";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(0, 26);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(182, 26);
            this.txbPhone.TabIndex = 1;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Controls.Add(this.btnEdit);
            this.pnlControls.Controls.Add(this.btnSearch);
            this.pnlControls.Controls.Add(this.btnDele);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Location = new System.Drawing.Point(61, 350);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(645, 68);
            this.pnlControls.TabIndex = 25;
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
            this.btnEdit.Enabled = false;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnDele
            // 
            this.btnDele.Enabled = false;
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
            // dtpCudate
            // 
            this.dtpCudate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCudate.Location = new System.Drawing.Point(132, 95);
            this.dtpCudate.Name = "dtpCudate";
            this.dtpCudate.Size = new System.Drawing.Size(444, 26);
            this.dtpCudate.TabIndex = 11;
            this.dtpCudate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpCudate_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adress";
            // 
            // txbCuAd
            // 
            this.txbCuAd.Location = new System.Drawing.Point(132, 167);
            this.txbCuAd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbCuAd.Name = "txbCuAd";
            this.txbCuAd.Size = new System.Drawing.Size(444, 26);
            this.txbCuAd.TabIndex = 9;
            this.txbCuAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCuAd_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-Mail";
            // 
            // txbCuEmail
            // 
            this.txbCuEmail.Location = new System.Drawing.Point(132, 133);
            this.txbCuEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbCuEmail.Name = "txbCuEmail";
            this.txbCuEmail.Size = new System.Drawing.Size(444, 26);
            this.txbCuEmail.TabIndex = 7;
            this.txbCuEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCuEmail_KeyDown);
            this.txbCuEmail.Leave += new System.EventHandler(this.txbCuEmail_Leave);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "First date";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 96);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 26);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Name";
            // 
            // txbCName
            // 
            this.txbCName.Location = new System.Drawing.Point(132, 62);
            this.txbCName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbCName.Name = "txbCName";
            this.txbCName.Size = new System.Drawing.Size(444, 26);
            this.txbCName.TabIndex = 3;
            this.txbCName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCName_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Number";
            // 
            // txbCNr
            // 
            this.txbCNr.Location = new System.Drawing.Point(132, 31);
            this.txbCNr.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbCNr.Name = "txbCNr";
            this.txbCNr.ReadOnly = true;
            this.txbCNr.Size = new System.Drawing.Size(177, 26);
            this.txbCNr.TabIndex = 0;
            this.txbCNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCNr_KeyDown);
            this.txbCNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCNr_KeyPress);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(308, 46);
            this.label10.TabIndex = 3;
            this.label10.Text = "Customer search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCustName);
            this.groupBox1.Controls.Add(this.rbtnStart);
            this.groupBox1.Controls.Add(this.rbtnEmail);
            this.groupBox1.Controls.Add(this.rbtnAdd);
            this.groupBox1.Controls.Add(this.rbtCustNr);
            this.groupBox1.Location = new System.Drawing.Point(10, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // rbtnCustName
            // 
            this.rbtnCustName.AutoSize = true;
            this.rbtnCustName.Location = new System.Drawing.Point(158, 25);
            this.rbtnCustName.Name = "rbtnCustName";
            this.rbtnCustName.Size = new System.Drawing.Size(150, 23);
            this.rbtnCustName.TabIndex = 4;
            this.rbtnCustName.Text = "Customer Name";
            this.rbtnCustName.UseVisualStyleBackColor = true;
            // 
            // rbtnStart
            // 
            this.rbtnStart.AutoSize = true;
            this.rbtnStart.Location = new System.Drawing.Point(348, 25);
            this.rbtnStart.Name = "rbtnStart";
            this.rbtnStart.Size = new System.Drawing.Size(95, 23);
            this.rbtnStart.TabIndex = 3;
            this.rbtnStart.Text = "Start day";
            this.rbtnStart.UseVisualStyleBackColor = true;
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Location = new System.Drawing.Point(496, 25);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(69, 23);
            this.rbtnEmail.TabIndex = 2;
            this.rbtnEmail.Text = "Email";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(625, 25);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(91, 23);
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
            this.rbtCustNr.Size = new System.Drawing.Size(124, 23);
            this.rbtCustNr.TabIndex = 0;
            this.rbtCustNr.TabStop = true;
            this.rbtCustNr.Text = "Customer Nr";
            this.rbtCustNr.UseVisualStyleBackColor = true;
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
            this.pnlSearch.Location = new System.Drawing.Point(10, 430);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(830, 416);
            this.pnlSearch.TabIndex = 32;
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
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Word Search";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(845, 415);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCNr;
        private System.Windows.Forms.DateTimePicker dtpCudate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCuAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCuEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Button btnPhonRem;
        private System.Windows.Forms.Button btnPhonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCustName;
        private System.Windows.Forms.RadioButton rbtnStart;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtCustNr;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}