using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaProject
{
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }
        DB db = new DB();

        public void ShowState(string SelectStatement, string TextForm)
        {
            Form frm = new Form();
            Font f = new Font("Arial", 14);
            DataGridView dgv = new DataGridView();
            frm.Font = f;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.Dock = DockStyle.Fill;
            dgv.ColumnHeadersHeight = 50;
            dgv.ReadOnly = true;
            dgv.ReadOnly = true;
            dgv.ReadOnly = true;
            dgv.ReadOnly = true;
            dgv.DataSource = db.RunReader(SelectStatement);
            frm.Controls.Add(dgv);
            frm.WindowState = FormWindowState.Normal;
            frm.ShowDialog();
            frm.Text = "Statistik about" + TextForm;
        }
        public void btnCustCount_Click(object sender, EventArgs e)
        {
            ShowState("select count (custno) as Count_Customer from customer", btnCustCount.Text);
        }

        public void btnOldCust_Click(object sender, EventArgs e)
        {
            //ShowState("select custname from customer where custno = 1", btnOldCust.Text);
            ShowState("select custname from customer where startdate = (select min(startdate) from customer) ", btnOldCust.Text);
        }

        public void btnMoreBuy_Click(object sender, EventArgs e)
        {
            ShowState("select custname , buying.custno , count(buying.custno) as More_Buying from customer , buying  where customer.custno = buying.custno group by buying.custno , custname having count (buying.custno )>= all(select count(custno) from buying group by custno)", btnMoreBuy.Text);
        }

        public void btnMoreSe_Click(object sender, EventArgs e)
        {
            ShowState("select custname , selling.custno , count(selling.custno) as More_Selling from customer , selling where customer.custno = selling.custno group by selling.custno , custname having count (selling.custno)>= all(select count(custno) from selling group by custno)", btnMoreSe.Text);
        }

        public void btnSellBuyMore_Click(object sender, EventArgs e)
        {
            ShowState("select 'buyer   '+custname as customer_name , buying.custno , count(buying.custno) as More_Buying from customer , buying  where customer.custno = buying.custno group by buying.custno , custname having count (buying.custno )>= all(select count(custno) from buying group by custno) union select 'seller  '+custname as customer_name , selling.custno , count(selling.custno) as More_Selling from customer , selling where customer.custno = selling.custno group by selling.custno , custname having count (selling.custno)>= all(select count(custno) from selling group by custno)", btnSellBuyMore.Text);
        }

        public void btnHighItemBuy_Click(object sender, EventArgs e)
        {
            ShowState("select itemname , buying.itemno ,count(buying.itemno) as number_of_buying from buying , item where buying.itemno = item.itemno group by buying.itemno , itemname having count(buying.itemno)>= all(select count(itemno) from buying group by itemno)", btnHighItemBuy.Text);
        }

        public void btnHighItemSell_Click(object sender, EventArgs e)
        {
            ShowState("select itemname , selling.itemno ,count(selling.itemno) as number_of_selling from selling , item where selling.itemno = item.itemno group by selling.itemno , itemname having count(selling.itemno)>= all(select count(itemno) from selling group by itemno)", btnHighItemSell.Text);
        }

        public void btnCountActionBuyNr_Click(object sender, EventArgs e)
        {
            ShowState("select count(actionno) as Count_0f_ActionNr from action_out", btnCountActionBuyNr.Text);
        }

        public void btnCountActionSellNr_Click(object sender, EventArgs e)
        {
            ShowState("select count(actionno) as Count_0f_ActionNr from action_in", btnCountActionSellNr.Text);
        }

        public void btnItemsCoutn_Click(object sender, EventArgs e)
        {
            ShowState("select count(itemno) as Count_0f_Items from item", btnCountActionSellNr.Text);
        }

        public void btnTotalBuy_Click(object sender, EventArgs e)
        {
            ShowState("select sum(price *qty) as Buying_Total from buying", btnTotalBuy.Text);
        }

        public void btnTotalSe_Click(object sender, EventArgs e)
        {
            ShowState("select sum(price *qty) as Selling_Total from selling", btnTotalSe.Text);
        }

        public void btnDefr_Click(object sender, EventArgs e)
        {
            ShowState("select sum(buying.price * buying.qty) - sum (selling.price * selling.qty) as difference_btn_Sell_buy from buying , selling", btnDefr.Text);
        }

        public void btnHighBuy_Click(object sender, EventArgs e)
        {
            ShowState("select buyno as buying_nu ,buying.custno as customer_nr , custname as customer_name , buying.itemno as item_nr , itemname as item_name ,dayname as day_name ,buydate as buying_date , qty as quantity , price as price , qty*price as Total , details as details from buying , item , customer , days where buying.itemno = item.itemno and buying.custno = customer.custno and buying.dayno =days.dayno and qty*price = (select max(qty*price)from buying) ", btnHighBuy.Text);
        }

        public void btnHighSe_Click(object sender, EventArgs e)
        {
            ShowState("select saleno as selling_nu ,selling.custno as customer_nr , custname as customer_name , selling.itemno as item_nr , itemname as item_name ,dayname as day_name ,seldate as selling_date , qty as quantity , price as price , qty*price as Total , details as details from selling , item , customer , days where selling.itemno = item.itemno and selling.custno = customer.custno and selling.dayno =days.dayno and qty*price = (select max(qty*price)from selling) ", btnHighBuy.Text);
        }

        public void btnStoreCount_Click(object sender, EventArgs e)
        {
            ShowState("select count (storeno) as store_count from store", btnStoreCount.Text);
        }

        public void btnCountOut_Click(object sender, EventArgs e)
        {
            ShowState("select count (actionno) as Action_out_count from action_out", btnCountOut.Text);
        }

        public void btnCountIn_Click(object sender, EventArgs e)
        {
            ShowState("select count (actionno) as Action_In_count from action_in", btnCountIn.Text);
        }

        public void btnHighAction_Click(object sender, EventArgs e)
        {

        }

        public void btnHighAction_Out_Click(object sender, EventArgs e)
        {
            ShowState("select actionno as Action_number , action_out.custno as Customer_number , custname as customer_name , action_out.itemno as item_number , itemname as itemname_ ,storename as storename_ , actiondate as date, action_out.storeno as store_number ,qty as quantity , price as price_ , price*qty as total , details as details_ from action_out , item , cutomer , store where action_out.custno=customer.custno and action_out.itemno = item.itemno and action_out.storeno = store.storeno and price*qty = (select max(price*qty) from action_out)", btnHighAction_Out.Text);
        }

        public void btnHighActionIn_Click(object sender, EventArgs e)
        {
            ShowState("select actionno as Action_number , action_in.custno as Customer_number , custname as customer_name , action_in.itemno as item_number , itemname as itemname_ ,storename as storename_ , actiondate as date, action_in.storeno as store_number ,action_in.qty as quantity , action_in.price as price_ , price*qty as total , action_in.details as details_ from action_in , item , cutomer , store where action_in.custno=customer.custno and action_in.itemno = item.itemno and action_in.storeno = store.storeno and price*qty =(select max(price*qty) from action_in)", btnHighActionIn.Text);
        }

        private void btnStatisOfCust_Click(object sender, EventArgs e)
        {

        }
        private void Fillcust()
        {
            cbxCust.DataSource = db.RunReader("select custno,custname from customer");
            cbxCust.DisplayMember = "custname";
            cbxCust.ValueMember = "custno";
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            Fillcust();
        }

        public void btnStaticSublay_Click(object sender, EventArgs e)
        {
            Showstat frm = new Showstat();
            frm.Text = "مورد";
            db.RunNonQuery("delete from Showstat", "");
            DataTable tblBuy = db.RunReader("select qty , price , buydate , itemname from item ,buying where buying.itemno = item.itemno and custno= " + cbxCust.SelectedValue);
            DataTable tblPay = db.RunReader("select *from payment_to where custno= " + cbxCust.SelectedValue);

            db.RunNonQuery("insert into showstat values (' كشف حساب " + cbxCust.Text + "')", "");
            db.RunNonQuery("insert into showstat values (' تحريرا في " + DateTime.Now.Date.ToShortDateString() + "')", "");
            db.RunNonQuery("insert into showstat values (' تفاصيل ما تم شرايه : ')" ,"");
            Decimal TotalBuy = 0;
            foreach (DataRow row in tblBuy.Rows)
            {
                db.RunNonQuery("insert into showstat values ('تم شراء " + row["qty"] + "# بسعر #" + row["price"] + "#دولار من الصنف [" + row["itemname"] + "]" + "بتاريخ " +((DateTime)row["buydate"]).ToShortDateString() + "الاجمالي مبلغ #" + (Convert.ToDecimal(row["price"]) * Convert.ToDecimal(row["qty"])).ToString() + "#دولار')", "");
                TotalBuy += Convert.ToDecimal(row["price"]) * Convert.ToDecimal(row["qty"]);

            }
            db.RunNonQuery("insert into showstat values ('اجمالي مبلغ الشراء #" + TotalBuy.ToString() + "#دولار ')", "");
            db.RunNonQuery("insert into showstat values ('اجمالي ماتم دفعة #" + TotalBuy.ToString() + "#دولار ')", "");
            decimal TotalPay = 0;
            foreach(DataRow row in tblPay.Rows)
            {
                db.RunNonQuery("insert into showstat values ('تم دفع #" + row["amount"] + "# دولار بيد" + row["person"] + "بتاريخ " + ((DateTime)row["paydate"]).ToShortDateString() + "')", "");
                TotalPay += Convert.ToDecimal(row["amount"]);
            }
            db.RunNonQuery("insert into showstat values ('اجمالي ما تم دفعة #" + TotalPay + "# دولار')", "");
            decimal TotalDef = TotalBuy - TotalPay;
            if (TotalDef == 0)
            {
                db.RunNonQuery("insert into showstat values ('بافي لــ " + cbxCust.Text + "لاشي ')", "");
                    
            } else if (TotalDef > 0)
            {
                db.RunNonQuery("insert into showstat values ('بافي ل " + cbxCust.Text + "#" + TotalDef + "# دولار')", ""); 
            }
            else
            {
                db.RunNonQuery("insert into showstat values ('" + cbxCust.Text + "علية/ها #" + Math.Abs(TotalDef) + "#دولار')", "");
            }


            frm.ShowDialog();
        }

        public void btnStatisOfCust_Click_1(object sender, EventArgs e)
        {
            Showstat frm = new Showstat();
            frm.Text = "مورد";
            db.RunNonQuery("delete from Showstat", "");
            DataTable tblSell = db.RunReader("select qty , price , seldate , itemname from item ,selling where selling.itemno = item.itemno and custno= " + cbxCust.SelectedValue);
            DataTable tblPay_me = db.RunReader("select *from payment_me where custno= " + cbxCust.SelectedValue);

            db.RunNonQuery("insert into showstat values (' كشف حساب " + cbxCust.Text + "')", "");
            db.RunNonQuery("insert into showstat values (' تحريرا في " + DateTime.Now.Date.ToShortDateString() + "')", "");
            db.RunNonQuery("insert into showstat values (' تفاصيل ما تم بيعة : ')", "");
            Decimal TotalSell = 0;
            foreach (DataRow row in tblSell.Rows)
            {
                db.RunNonQuery("insert into showstat values ('تم بيع " + row["qty"] + "# بسعر #" + row["price"] + "#دولار من الصنف [" + row["itemname"] + "]" + "بتاريخ " + ((DateTime)row["buydate"]).ToShortDateString() + "الاجمالي مبلغ #" + (Convert.ToDecimal(row["price"]) * Convert.ToDecimal(row["qty"])).ToString() + "#دولار')", "");
                TotalSell += Convert.ToDecimal(row["price"]) * Convert.ToDecimal(row["qty"]);

            }
            db.RunNonQuery("insert into showstat values ('اجمالي مبلغ البيع #" + TotalSell.ToString() + "#دولار ')", "");
            db.RunNonQuery("insert into showstat values ('اجمالي ماتم دفعة #" + TotalSell.ToString() + "#دولار ')", "");
            decimal TotalPay_me = 0;
            foreach (DataRow row in tblPay_me.Rows)
            {
                db.RunNonQuery("insert into showstat values ('تم دفع #" + row["amount"] + "# دولار بيد" + row["person"] + "بتاريخ " + ((DateTime)row["paydate"]).ToShortDateString() + "')", "");
                TotalPay_me += Convert.ToDecimal(row["amount"]);
            }
            db.RunNonQuery("insert into showstat values ('اجمالي ما تم تحصيلة #" + TotalPay_me + "# دولار')", "");
            decimal TotalDef = TotalSell - TotalPay_me;
            if (TotalDef == 0)
            {
                db.RunNonQuery("insert into showstat values ('بافي لــ " + cbxCust.Text + "لاشي ')", "");

            }
            else if (TotalDef > 0)
            {
                db.RunNonQuery("insert into showstat values ('بافي ل " + cbxCust.Text + "#" + TotalDef + "# دولار')", "");
            }
            else
            {
                db.RunNonQuery("insert into showstat values ('" + cbxCust.Text + "علية/ها #" + Math.Abs(TotalDef) + "#دولار')", "");
            }


            frm.ShowDialog();
        }
    }

}
