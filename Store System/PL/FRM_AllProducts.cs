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
    public partial class FRM_AllProducts : Form
    {
        BL.cls_allPRODUCTin_stores cls = new BL.cls_allPRODUCTin_stores();
        DataTable dt, dt2, dt3;
        bool chare = true;

        public FRM_AllProducts()
        {
            InitializeComponent();
            load_all_products_name();
            radioButton1.Checked = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        public void load_all_products_name()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = new DataTable();
            dt = DAL.SelectData("Load_productName", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbCUT_Name.Items.Add(dt.Rows[i].ItemArray[0]);
        }


        public void load_all_products()
        {
            DataTable ds = new DataTable();
            ds = cls.LOAD_ALL_PRODUCTtodgv();
            dataGridView1.DataSource = ds;
            lb_NUM_PRODUCT.Text = "عدد المنتجات:" + " " + dataGridView1.RowCount.ToString();
        }

        private void FRM_AllProducts_Load(object sender, EventArgs e)
        {
            load_all_products();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            if (cmbCUT_Name.Text != "")
            {
                DataTable dt = new DataTable();
                dt = cls.SEARCH_PRODUCTtodgv(cmbCUT_Name.SelectedItem.ToString());
                dataGridView1.DataSource = dt;
                lb_NUM_PRODUCT.Text = "عددالمنتجات:" + " " + dataGridView1.RowCount.ToString();
            }
            else
            {
                load_all_products();
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من تعديل المنتج؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Frm_ADDNewProudct frm = new Frm_ADDNewProudct();
                frm.TB_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.cmb_categories.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.tbproductname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.tbbuyprice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.tbselPprice.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.tbSellSprice.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.tbminiprice.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.tbqty.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.cmb_storename.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frm.tbminiqty.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frm.Text = "تعديل المنتج" + this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.btn_add.Text = "تعديل";
                frm.state = "update";
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف المنتج؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls.DELETE_products(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                load_all_products();
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                flag(true);
            }
            if (radioButton1.Checked == true)
            {
                flag(false);
                load_all_products();
            }

        }

        private void radioButton1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && chare == true)
            {
                radioButton1.Checked = false;
            }

            chare = true;

        }
        public void flag(bool _chare)
        {
            chare = _chare;
        }

        private void btn_ADD_payedmoney_Click(object sender, EventArgs e)
        {
            PL.Frm_ADDNewProudct frm = new PL.Frm_ADDNewProudct();
            frm.ShowDialog();
            frm.Close();
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
