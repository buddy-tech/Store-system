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
    public partial class FRM_ALL_CAT : Form
    {
        BL.ClSADDneWpRODUCT add = new BL.ClSADDneWpRODUCT();
        BL.CLS_ADD_CAT add_cat = new BL.CLS_ADD_CAT();
        bool chare = true;
        private static FRM_ALL_CAT frm;
        static void frm_closed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_ALL_CAT get_MainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_ALL_CAT();
                    frm.FormClosed += new FormClosedEventHandler(frm_closed);
                }
                return frm;
            }
        }

        public FRM_ALL_CAT()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FRM_ALL_CAT_Load(object sender, EventArgs e)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("getAllcategorie", null);
            DAL.close();
            this.dataGridView1.DataSource = dt;
            lb_NUM_CUSTOMER.Text = "عددالاصناف:" + " " + dataGridView1.RowCount.ToString();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = add.SEARCH_CATEGORIES(tb_search.Text);
            this.dataGridView1.DataSource = dt;
            lb_NUM_CUSTOMER.Text = "عددالاصناف:" + " " + dataGridView1.RowCount.ToString();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من تعديل الصنف؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                FRM_ADD_CATEGORIES frm = new FRM_ADD_CATEGORIES();
                frm.tb_IDcat.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.tbnew_cat.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.Text = "تعديل الصنف" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.btn_addcategories.Text = "تعديل";
                frm.state = "update";
               // FRM_ALL_CAT_Load(sender,e);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف الصنف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                add_cat.DELETE_CATEGORIE(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                FRM_ALL_CAT_Load(sender, e);
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
               this. FRM_ALL_CAT_Load(sender, e);
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
            tb_search.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.تعديلToolStripMenuItem_Click(sender, e);        }
        private void btn_ADD_Customer_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_CATEGORIES frm = new PL.FRM_ADD_CATEGORIES();
            frm.ShowDialog();
            frm.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.حذفToolStripMenuItem_Click(sender, e);
        }

        

       
    }
}
