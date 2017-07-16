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
    public partial class FRM_MANG_PAYEDmoney_customer : Form
    {
        BL.CLS_load_allPayedmoneyCustomer cls = new BL.CLS_load_allPayedmoneyCustomer();
        DataTable dt;
        bool chare = true;

        public FRM_MANG_PAYEDmoney_customer()
        {
            InitializeComponent();
            load_all_PAYEDmoney_Customer();
            radioButton1.Checked = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void load_all_PAYEDmoney_Customer()
        {
            DataTable ds = new DataTable();
            ds = cls.LOAD_ALL_paytedmoneyCUSTOMER_todgv();
            
            dataGridView1.DataSource = ds;
            lb_NUM_CUSTOMER.Text = "عدد المقبوضات من العملاء:" + " " + dataGridView1.RowCount.ToString();
        }
        public void load_all_CustomerName()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = new DataTable();
            dt = DAL.SelectData("load_Customer_NAME", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbCUT_Name.Items.Add(dt.Rows[i].ItemArray[0]);
        }

        private void FRM_MANG_PAYEDmoney_customer_Load(object sender, EventArgs e)
        {
            load_all_CustomerName();
        }

        private void btn_search_cut_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            if (cmbCUT_Name.Text != "")
            {
                DataTable dt = new DataTable();
                dt = cls.SEARCH_AllCustomer_NAME(cmbCUT_Name.SelectedItem.ToString());
                dataGridView1.DataSource = dt;
                lb_NUM_CUSTOMER.Text = "عددالمقبوضات من العملاء:" + " " + dataGridView1.RowCount.ToString();
            }
            else
            {
                load_all_PAYEDmoney_Customer();
            }

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من تعديل معلومات المقبوضات من العميل؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                FRM_ADD_payedmoney_Customer frm = new FRM_ADD_payedmoney_Customer();
                frm.TB_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.tbCustomername.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.tbCustomerpayed_money.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.Text = "تعديل معلومات المقبوضات من العميل " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.btn_ADD_payedmoneyCustomer.Text = "تعديل";
                frm.kind = "customer";
                frm.state = "update";
                frm.ShowDialog();
                load_all_PAYEDmoney_Customer();

            }
            else
            {
                MessageBox.Show("تم الغاء عملية التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف المقبوضات من العميل؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls.Delete_Payedmoney_customer(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                load_all_PAYEDmoney_Customer();
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_ADD_payedmoneyCustomer_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_payedmoney_Customer frm = new PL.FRM_ADD_payedmoney_Customer();
            frm.kind = "customer";
            frm.ShowDialog();
            load_all_PAYEDmoney_Customer();
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
                load_all_PAYEDmoney_Customer();
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
            cmbCUT_Name.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.تعديلToolStripMenuItem_Click(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.حذفToolStripMenuItem_Click(sender, e);
        }



    }
}
