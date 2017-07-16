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
    public partial class mAINFRM_Companies : Form
    {
        BL.CLS_Load_All_Companies cls = new BL.CLS_Load_All_Companies();
        DataTable dt;
        public string COM_name;
        public string COM_ID;
        bool chare = true; 
        public void load_all_COM()
        {
            DataTable ds = new DataTable();
            ds = cls.LOAD_ALL_COM_todgv();
            dataGridView1.DataSource = ds;
            lb_NUM_COM.Text = "عدد الموردين:" + " " + dataGridView1.RowCount.ToString();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public mAINFRM_Companies()
        {
            InitializeComponent();
            load_all_COM();
            radioButton1.Checked = true;
        }
        public void load_all_COM_Name()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = new DataTable();
            dt = DAL.SelectData("load_COM_NAME", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmb_NAME_COM.Items.Add(dt.Rows[i].ItemArray[0]);
        }
        private void mAINFRM_Companies_Load(object sender, EventArgs e)
        {
             load_all_COM_Name();
        }

        private void btn_search_COM_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            if(cmb_NAME_COM.Text!="")
            {
            DataTable dt = new DataTable();
            dt = cls.SEARCH_AllCUT_NAME(cmb_NAME_COM.SelectedItem.ToString());
            dataGridView1.DataSource = dt;
            lb_NUM_COM.Text = "عددالعملاء:" + " " + dataGridView1.RowCount.ToString();
            }
            else
            {
                load_all_COM();
            }

        }
        private void تعديلToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من تعديل معلومات المورد؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                FRM_ADD_COMPAYE frm = new FRM_ADD_COMPAYE();
                frm.TB_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.tbCOMname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.tbCOMAddress.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.tbCOMPhone.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.Text = "تعديل معلومات المورد " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.btn_ADD_Customer.Text = "تعديل";
                frm.state = "update";
                frm.ShowDialog();
                load_all_COM();

            }
            else
            {
                MessageBox.Show("تم الغاء عملية التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void حذفToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف العميل؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls.DELETE_COM(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                load_all_COM();
                cmb_NAME_COM.Items.Clear();
                load_all_COM_Name();
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
                load_all_COM();
                cmb_NAME_COM.SelectedItem = "";
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

        private void btn_ADD_COM_Click(object sender, EventArgs e)
        {
            FRM_ADD_COMPAYE frm = new FRM_ADD_COMPAYE();
            frm.ShowDialog();
            load_all_COM();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            COM_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            COM_name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.تعديلToolStripMenuItem_Click_1(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.حذفToolStripMenuItem_Click_1(sender, e);
        }


        



    }
}
