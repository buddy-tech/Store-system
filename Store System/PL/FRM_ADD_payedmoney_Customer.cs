using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.PL
{
    public partial class FRM_ADD_payedmoney_Customer : Form
    {
        BL.CLS_Addpayedmoney_customer cls = new BL.CLS_Addpayedmoney_customer();
        BL.CLS_Show_save cls2 = new BL.CLS_Show_save();
        PL.Form_LOGIN frm = new PL.Form_LOGIN();
        public string state = "add";
        public string kind = "customer";

        public FRM_ADD_payedmoney_Customer()
        {
            InitializeComponent();

        }
        private void btn_Searchcustomer_Click(object sender, EventArgs e)
        {
            if (kind == "customer")
            {
                PL.MANG_FRM_customers frm = new PL.MANG_FRM_customers();
                frm.ShowDialog();
                tbCustomername.Text = frm.customer_name;
                lb_customerID.Text = frm.customer_ID;
            }
            else if(kind=="company")
            {
                PL.mAINFRM_Companies frm = new PL.mAINFRM_Companies();
                frm.ShowDialog();
                tbCustomername.Text = frm.COM_name;
                lb_customerID.Text = frm.COM_ID;
            }

        }

        private void btn_ADD_payedmoneyCustomer_Click(object sender, EventArgs e)
        {
            string usertypeID = cls2.GETID("Get_UserTypeID", frm.tbNAme.Text);
            if (kind == "customer")
            {
                int Rorder = cls2.remainmoney_orderID("check_remainingmoney_order", Convert.ToInt32(tb_orderID.Text));
                if (state == "add")
                {
                    cls.ADD_Payedmoney_Customer(Convert.ToInt32(lb_customerID.Text), Convert.ToDecimal(tbCustomerpayed_money.Text), Convert.ToDateTime(dateTimePicker1.Text),Convert.ToInt32(tb_orderID.Text));
                    cls.update_RemainMoney_Customer_INFO(Convert.ToInt32(lb_customerID.Text), Convert.ToInt32(tb_orderID.Text), Convert.ToDecimal(lb_remainMoney.Text));
                    if(Rorder==0)
                    cls2.Add_moneySaver_Customer_INFO(Convert.ToInt32(lb_customerID.Text), 2, 1, Convert.ToDateTime(dateTimePicker1.Text),Convert.ToInt32(tb_orderID.Text),2,Convert.ToDecimal(tbCustomerpayed_money.Text));  //usertypeID
                    else
                        cls2.Add_moneySaver_Customer_INFO(Convert.ToInt32(lb_customerID.Text), 2, 1, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(tb_orderID.Text), 1, Convert.ToDecimal(tbCustomerpayed_money.Text));  //usertypeID
                    MessageBox.Show(tbCustomername.Text + " " + "تم بنجاح اضافة مبلغ من العميل ", "اضافة مبلغ من عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (state == "update")
                {
                    string customer_ID = cls.GETID("GET_ID_Customer", tbCustomername.Text);
                    lb_customerID.Text = customer_ID;
                    cls.update_Payedmoney_Customer_INFO(Convert.ToInt32(TB_ID.Text), Convert.ToInt32(lb_customerID.Text), Convert.ToDecimal(tbCustomerpayed_money.Text), Convert.ToDateTime(dateTimePicker1.Text),Convert.ToInt32(tb_orderID.Text));
                    if (Rorder == 0)
                        cls2.Add_moneySaver_Customer_INFO(Convert.ToInt32(lb_customerID.Text), 2, 1, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(tb_orderID.Text), 2, Convert.ToDecimal(tbCustomerpayed_money.Text));  //usertypeID
                    else
                        cls2.Add_moneySaver_Customer_INFO(Convert.ToInt32(lb_customerID.Text), 2, 1, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(tb_orderID.Text), 1, Convert.ToDecimal(tbCustomerpayed_money.Text));  //usertypeID
                    MessageBox.Show("تم بنجاح تعديل معلومات المبلغ المقبوض من العميل  ", "تعديل معلومات المبلغ من عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

            else if (kind == "company")
            {
                int Rorder = cls2.remainmoney_orderID("check_remainingmoney_order", Convert.ToInt32(tb_orderID.Text));
                if (state == "add")
                {
                    cls.ADD_Payedmoney_COM(Convert.ToInt32(lb_customerID.Text), Convert.ToDecimal(tbCustomerpayed_money.Text), Convert.ToDateTime(dateTimePicker1.Text),Convert.ToInt32(tb_orderID.Text));
                    if (Rorder == 0)
                        cls2.Add_moneySaver_COM_INFO(Convert.ToInt32(lb_customerID.Text), 1, 1, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(tb_orderID.Text), 4, Convert.ToDecimal(tbCustomerpayed_money.Text));  //usertypeID
                    else
                        cls2.Add_moneySaver_COM_INFO(Convert.ToInt32(lb_customerID.Text), 1, 1, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(tb_orderID.Text), 3, Convert.ToDecimal(tbCustomerpayed_money.Text));  //usertypeID
                    MessageBox.Show(tbCustomername.Text + " " + "تم بنجاح اضافة مبلغ للمورد ", "اضافة مبلغ لمورد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (state == "update")
                {
                    string com_ID = cls.GETID("GET_ID_COM", tbCustomername.Text);
                    lb_customerID.Text = com_ID;
                    cls.update_Payedmoney_COM_INFO(Convert.ToInt32(TB_ID.Text), Convert.ToInt32(lb_customerID.Text), Convert.ToDecimal(tbCustomerpayed_money.Text), Convert.ToDateTime(dateTimePicker1.Text),Convert.ToInt32(tb_orderID.Text));
                    if (Rorder == 0)
                        cls2.Add_moneySaver_COM_INFO(Convert.ToInt32(lb_customerID.Text), 1, 1, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(tb_orderID.Text), 4, Convert.ToDecimal(tbCustomerpayed_money.Text));  //usertypeID
                    else
                        cls2.Add_moneySaver_COM_INFO(Convert.ToInt32(lb_customerID.Text), 1, 1, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(tb_orderID.Text), 3, Convert.ToDecimal(tbCustomerpayed_money.Text));  //usertypeID
                    MessageBox.Show("تم بنجاح تعديل معلومات المبلغ المدفوعة للمورد  ", "تعديل معلومات المبلغ للمورد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }

        }

        private void FRM_ADD_payedmoney_Customer_Load(object sender, EventArgs e)
        {
            if (kind == "customer")
                TB_ID.Text = cls.fillIDCustomer();
            else if (kind == "company")
                TB_ID.Text = cls.fillIDCOM();

        }

        private void tbCustomerpayed_money_TextChanged(object sender, EventArgs e)
        {
            if (kind == "customer")
            {
                if (lb_totalmoney.Text != "0")
                    lb_remainMoney.Text = (Convert.ToDecimal(lb_totalmoney.Text) - Convert.ToDecimal(tbCustomerpayed_money.Text)).ToString();
                else
                    MessageBox.Show("هذا العميل قد سدد مبلغ هذة الفاتورة ", " تعديل المبلغ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (kind == "company")
            {
                if (lb_totalmoney.Text != "0")
                    lb_remainMoney.Text = (Convert.ToDecimal(lb_totalmoney.Text) - Convert.ToDecimal(tbCustomerpayed_money.Text)).ToString();
                else
                    MessageBox.Show("هذا المورد قد سدد لة هذة الفاتورة ", " تعديل المبلغ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_OrderID_Click(object sender, EventArgs e)
        {
            if (kind == "customer")
            {

                PL.FRM_AllCusotmerOrders_notfinish frm = new PL.FRM_AllCusotmerOrders_notfinish();
                frm.ShowDialog();
                tb_orderID.Text = frm.Order_ID;
                lb_totalmoney.Text = cls.fillRemainMoneyCustomer(Convert.ToInt32(lb_customerID.Text), Convert.ToInt32(tb_orderID.Text));
            }

            else if (kind == "company")
            {

                PL.FRM_AllCOM_notyetfinishTheyMoney frm = new PL.FRM_AllCOM_notyetfinishTheyMoney();
                frm.ShowDialog();
                tb_orderID.Text = frm.Order_ID;
                lb_totalmoney.Text = cls.fillRemainMoneyCOM(Convert.ToInt32(lb_customerID.Text), Convert.ToInt32(tb_orderID.Text));
            }
        }
    }
}
