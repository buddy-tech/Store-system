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
    public partial class FRM_SinALL_Orders : Form
    {
        BL.CSL_load_allORERS cls = new BL.CSL_load_allORERS();
        bool  chare = true;
        public string customer_name;
        public string customer_ID;
        public bool state = true;
        public string Order_Type;
        public string Order_ID;
        public string Order_Date;
        public string usertype_ID;

        public FRM_SinALL_Orders()
        {
            InitializeComponent();
            load_all_Orders();
            radioButton1.Checked = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_search_cut_Click(object sender, EventArgs e)
        {
                PL.MANG_FRM_customers frm = new PL.MANG_FRM_customers();
                frm.ShowDialog();
                tb_customerName.Text = frm.customer_name;
        }
        public void load_all_Orders()
        {  
            DataTable ds = new DataTable();
                ds = cls.LOAD_ALL_Orders_todgv();
                dataGridView1.DataSource = ds;
        }

        private void btn_ADD_Customer_Click(object sender, EventArgs e)
        {
                 PL.FRM_MAKEORDER frm = new PL.FRM_MAKEORDER();
                 frm.ShowDialog();
        }

        private void btn_searchORDER_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
                if (tb_customerName.Text != "")
                {
                    DataTable dt = new DataTable();
                    dt = cls.SEARCH_AllORDERS(tb_customerName.Text, Convert.ToDateTime(dateTimePicker2.Text), Convert.ToDateTime(dateTimePicker1.Text));
                    dataGridView1.DataSource = dt;
                    lb_NUM_ORDERS.Text = "عددالفواتير:" + " " + dataGridView1.RowCount.ToString();
                }
                else
                {
                    load_all_Orders();
                }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                if (radioButton1.Checked == false)
                {
                    flag(true);
                }
                if (radioButton1.Checked == true)
                {
                    flag(false);
                    load_all_Orders();
                    tb_customerName.Text = "";
                }
        }
        public void flag(bool _chare)
        {
            chare = _chare;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && chare == true)
            {
                radioButton1.Checked = false;
            }

            chare = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Order_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Order_Date = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Order_Type = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            customer_ID = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            customer_name = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            usertype_ID = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            this.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
