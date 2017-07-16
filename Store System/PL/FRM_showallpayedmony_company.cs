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
    public partial class FRM_showallpayedmony_company : Form
    {
        BL.CLS_showAll_payedmoneyCustomer cls = new BL.CLS_showAll_payedmoneyCustomer();

        public FRM_showallpayedmony_company()
        {
            InitializeComponent();
        }
        private void btn_searchcustomerNAme_Click(object sender, EventArgs e)
        {
            PL.mAINFRM_Companies frm = new PL.mAINFRM_Companies();
            frm.ShowDialog();
            lb_customerID.Text = frm.COM_ID;
            tb_Customername.Text = frm.COM_name;
        }
        public void load_all_PAYEDmoneyorders_COM()
        {
            DataTable ds = new DataTable();
            ds = cls.SEARCH_ALLCOMOrders_todgv(Convert.ToInt32(lb_customerID.Text));
            dataGridView1.DataSource = ds;
        }
        public void load_all_PAYEDmoney_COM()
        {
            DataTable ds = new DataTable();
            ds = cls.SEARCH_ALLpaymentmoneyFor_COMOrders_todgv(Convert.ToInt32(lb_customerID.Text));
            dataGridView2.DataSource = ds;
        }


        private void btn_show_Click(object sender, EventArgs e)
        {

            if (tb_Customername.Text != "")
            {
                decimal totalmoney1 = 0;
                decimal totalmoney2 = 0;
                load_all_PAYEDmoneyorders_COM();
                load_all_PAYEDmoney_COM();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    totalmoney1 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                lb_Totalmoney_orders.Text = totalmoney1.ToString();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    totalmoney2 += Convert.ToDecimal(dataGridView2.Rows[i].Cells[3].Value);
                lb_moneytaken.Text = totalmoney2.ToString();
            }
            else
            {
                MessageBox.Show("برجاء ادخل اسم المورد", "ادخال اسم المورد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
