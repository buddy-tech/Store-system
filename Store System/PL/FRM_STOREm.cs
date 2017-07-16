using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Store_System.PL
{
    public partial class FRM_STOREm : Form
    {
        bool chare;
        int position;
        BL.CLS_STORE cls_store = new BL.CLS_STORE();
        public FRM_STOREm()
        {
            InitializeComponent();
            tb_IDSTORE.Text = cls_store.fillID();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            radioButton1.Checked = true;
            chare = true;

        }

        private void btn_addcategories_Click(object sender, EventArgs e)
        {
            cls_store.ADD_INFO_store(tbnew_STORE.Text);
            MessageBox.Show("تمت عملية الاضافة بنجاح", "اضافة مخزن جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_update.Enabled = true ;
            btn_delete.Enabled = true ;
            btn_addcategories.Enabled = false;
            radioButton1.Checked = false;

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من تعديل الصنف؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==DialogResult.Yes)
            {
                cls_store.update_INFO_store(Convert.ToInt32(tb_IDSTORE.Text), tbnew_STORE.Text);
                MessageBox.Show("تمت عملية التعديل بنجاح", "تعديل اسم المخزن", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("تمت الغاء عملية التعديل بنجاح", "تعديل اسم المخزن", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        #region navigate
        void navigate(int ind)
        {
            DataTable dt = cls_store.get_all_store();
            DataRowCollection drc = dt.Rows;
            tb_IDSTORE.Text = drc[ind][0].ToString();
            tbnew_STORE.Text = drc[ind][1].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            navigate(0);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            position = cls_store.get_all_store().Rows.Count - 1;
            navigate(position);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (position == 0)
            {
                MessageBox.Show("هذا هو اول عنصر");
                return;
            }
            position -= 1;
            navigate(position);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (position == cls_store.get_all_store().Rows.Count - 1)
            {
                MessageBox.Show("هذا هو اخر عنصر");
                return;
            }
            position += 1;
            navigate(position);
        }
        #endregion

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف المخزن ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls_store.DELETE_INFO_store(Convert.ToInt32(tb_IDSTORE.Text));
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button4_Click(sender, e);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        public void flag(bool _chare) 
        {
            chare = _chare;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                btn_addcategories.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                flag(true);
            }
            if (radioButton1.Checked == true)
            {
                tb_IDSTORE.Text = cls_store.fillID();
                tbnew_STORE.Text = null;
                btn_addcategories.Enabled = true;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                flag(false);
            }
        }        
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true &&chare==true)
            {     
                radioButton1.Checked=false;
            }
            chare = true;
           
        }
    }
}

