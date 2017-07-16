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
    public partial class FRM_ShowAllpayedmoney_customer : Form
    {
        BL.CLS_showAll_payedmoneyCustomer cls = new BL.CLS_showAll_payedmoneyCustomer();
        public FRM_ShowAllpayedmoney_customer()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btn_searchcustomerNAme_Click(object sender, EventArgs e)
        {
            PL.MANG_FRM_customers frm = new PL.MANG_FRM_customers();
            frm.ShowDialog();
            lb_customerID.Text = frm.customer_ID;
            tb_Customername.Text = frm.customer_name;
        }
        public void load_all_PAYEDmoneyorders_Customer()
        {
            DataTable ds = new DataTable();
            ds = cls.SEARCH_ALLCustomerOrders_todgv(Convert.ToInt32( lb_customerID.Text));
            dataGridView1.DataSource = ds;
        }
        public void load_all_PAYEDmoney_Customer()
        {
            DataTable ds = new DataTable();
            ds = cls.SEARCH_ALLpaymentmoneyFor_CustomerOrders_todgv(Convert.ToInt32(lb_customerID.Text));
            dataGridView2.DataSource = ds;
        }


        private void btn_show_Click(object sender, EventArgs e)
        {

            if (tb_Customername.Text != "")
            {
                decimal totalmoney1 = 0;
                decimal totalmoney2 = 0;
                load_all_PAYEDmoneyorders_Customer();
                load_all_PAYEDmoney_Customer();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    totalmoney1 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                lb_Totalmoney_orders.Text = totalmoney1.ToString();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    totalmoney2 += Convert.ToDecimal(dataGridView2.Rows[i].Cells[3].Value);
                lb_moneytaken.Text = totalmoney2.ToString();
            }
            else 
            {
                MessageBox.Show("برجاء ادخل اسم العميل", "ادخال اسم العميل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
