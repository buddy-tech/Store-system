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
    public partial class frm_AllProduct_IN_sALLSTORES : Form
    {
        BL.cls_allPRODUCTin_stores cls = new BL.cls_allPRODUCTin_stores();
        DataTable dt,dt2,dt3;
        bool chare = true;
        public string product_Name;
        public string product_ID;
        public string product_Quantity;
        public string product_Type;
        public string price_Sentence;
        public string price_Sector;
        public string Store_name;
        public frm_AllProduct_IN_sALLSTORES()
        {
            InitializeComponent();
            load_all_products();
            radioButton1.Checked = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void load_all_products()
        {
            DataTable ds = new DataTable();
            ds = cls.LOAD_ALL_PRODUCTtodgv();
            dataGridView1.DataSource = ds;
            lb_NUM_PRODUCT.Text = "عدد المنتجات:" + " " + dataGridView1.RowCount.ToString();
        }
        private void frm_AllProduct_IN_sALLSTORES_Load(object sender, EventArgs e)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
             dt = new DataTable();
            dt = DAL.SelectData("load_categoires", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbCAT_Name.Items.Add(dt.Rows[i].ItemArray[0]);
            dt3 = DAL.SelectData("LOAD_STROEnAME", null);
            for (int i = 0; i < dt3.Rows.Count; i++)
                cmbstore_NAME.Items.Add(dt3.Rows[i].ItemArray[0]);
        }

        private void cmbCAT_Name_TextChanged(object sender, EventArgs e)
        {
            if (cmbCAT_Name.Text != "")
            {
                dt2 = new DataTable();
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                dt2 = cls.SEARCH_CATEGORIES(cmbCAT_Name.Text);
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (dt2.Rows[i].ItemArray[0].ToString() != dt.Rows[j].ItemArray[0].ToString())
                            cmbCAT_Name.Items.Remove(dt.Rows[j].ItemArray[0]);
                    }
                }
            }
            else 
            {
                cmbCAT_Name.Items.Remove(dt2.Rows[0].ItemArray[0]);
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                dt = new DataTable();
                dt = DAL.SelectData("load_categoires", null);
                for (int i = 0; i < dt.Rows.Count; i++)
                    cmbCAT_Name.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }

        private void cmbstore_NAME_TextChanged(object sender, EventArgs e)
        {
            if (cmbstore_NAME.Text != "")
            {
                dt2 = new DataTable();
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                dt2 = cls.SEARCH_storeNAME(cmbstore_NAME.Text);
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    for (int j = 0; j < dt3.Rows.Count; j++)
                    {
                        if (dt2.Rows[i].ItemArray[0].ToString() != dt3.Rows[j].ItemArray[0].ToString())
                            cmbstore_NAME.Items.Remove(dt3.Rows[j].ItemArray[0]);
                    }
                }
            }
            else
            {
                cmbstore_NAME.Items.Remove(dt2.Rows[0].ItemArray[0]);
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                dt3 = new DataTable();
                dt3 = DAL.SelectData("LOAD_STROEnAME", null);
                for (int i = 0; i < dt3.Rows.Count; i++)
                    cmbstore_NAME.Items.Add(dt3.Rows[i].ItemArray[0]);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            DataTable dt = new DataTable();
            if (cmbstore_NAME.Text.ToString() == "" && cmbCAT_Name.Text.ToString() == "")
                load_all_products();
            else if (cmbstore_NAME.Text != "" && cmbCAT_Name.Text == "" || cmbstore_NAME.Text == "" && cmbCAT_Name.Text != "")
                MessageBox.Show(" لابد من اختيار اسم المخزن  واسم الصنف من فضلك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dt = cls.SEARCH_ALL_PRODUCTtodgv(cmbstore_NAME.SelectedItem.ToString(), cmbCAT_Name.SelectedItem.ToString());
                dataGridView1.DataSource = dt;
                lb_NUM_PRODUCT.Text = "عدد المنتجات:" + " " + dataGridView1.RowCount.ToString();
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من تعديل المنتج؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Frm_ADDNewProudct frm = new Frm_ADDNewProudct();
                frm.TB_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm. cmb_categories.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {       
            product_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            product_Name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            product_Type=dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            product_Quantity = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            price_Sector = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            price_Sentence = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Store_name = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ADD_Customer_Click(object sender, EventArgs e)
        {
            PL.Frm_ADDNewProudct frm = new PL.Frm_ADDNewProudct();
            frm.ShowDialog();
            frm.Close();
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
