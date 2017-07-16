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
    public partial class MANG_FRM_customers : Form
    {
        BL.CLS_LoadAll_customer cls =new BL.CLS_LoadAll_customer();
        DataTable dt;
        bool chare=true;
       public string customer_name;
       public string customer_ID;
       
        public MANG_FRM_customers()
        {
            InitializeComponent();
            load_all_Customer();
            radioButton1.Checked = true ;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void load_all_Customer()
        {
            DataTable ds = new DataTable();
            ds = cls.LOAD_ALL_CUSTOMER_todgv();
            dataGridView1.DataSource = ds;
            lb_NUM_CUSTOMER.Text = "عددالعملاء:" + " " + dataGridView1.RowCount.ToString();
        }
        public void load_all_CustomerName()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = new DataTable();
            dt = DAL.SelectData("load_Customer_NAME", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbCUT_Name.Items.Add(dt.Rows[i].ItemArray[0]);
        }
        private void MANG_FRM_customer_Load(object sender, EventArgs e)
        {
            load_all_CustomerName(); 
        }

        private void btn_search_cut_Click_1(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            if(cmbCUT_Name.Text!="")
            {
            DataTable dt = new DataTable();
            dt = cls.SEARCH_AllCUT_NAME(cmbCUT_Name.SelectedItem.ToString());
            dataGridView1.DataSource = dt;
            lb_NUM_CUSTOMER.Text = "عددالعملاء:" + " " + dataGridView1.RowCount.ToString();
            }
            else
            {
                load_all_Customer();
            }
        }

        //private void cmbCUT_Name_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (cmbCUT_Name.Text != "")
        //    {
        //        dt2 = new DataTable();
        //        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //        dt2 = cls.SEARCH_CUT_NAME(cmbCUT_Name.Text);
        //        for (int i = 0; i < dt2.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < dt.Rows.Count; j++)
        //            {
        //                if (dt2.Rows[i].ItemArray[0].ToString() != dt.Rows[j].ItemArray[0].ToString())
        //                    cmbCUT_Name.Items.Remove(dt.Rows[j].ItemArray[0]);
        //            }
        //        }

        //    }
        //    else
        //    {
        //        cmbCUT_Name.Items.Remove(dt2.Rows[0].ItemArray[0]);
        //        load_all_CustomerName();
        //        load_all_Customer();
        //    }

        //}

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من تعديل معلومات العميل؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                FRM_ADD_Customer frm = new FRM_ADD_Customer();
                frm.TB_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.tbCustomername.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.tbCustomerAddress.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.tbCustomerPhone.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.Text = "تعديل معلومات العميل " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.btn_ADD_Customer.Text = "تعديل";
                frm.state = "update";
                frm.ShowDialog();  
                load_all_Customer();

            }
            else
            {
                MessageBox.Show("تم الغاء عملية التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void btn_ADD_Customer_Click(object sender, EventArgs e)
        {
            FRM_ADD_Customer frm = new FRM_ADD_Customer();
            frm.ShowDialog();

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف العميل؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls.DELETE_Customer(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                load_all_Customer();
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                load_all_Customer();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customer_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            customer_name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.تعديلToolStripMenuItem_Click(sender,e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.حذفToolStripMenuItem_Click(sender, e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
