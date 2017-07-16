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
    public partial class FRM_AddNEWUser : Form
    {
        BL.CLS_LOGIN cls = new BL.CLS_LOGIN();
        public string state = "add";
        public FRM_AddNEWUser()
        {
            InitializeComponent();
            TB_ID.Text = cls.fillID();  
        }

        private void btn_ADD_Customer_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                if (tbUSERname.Text == string.Empty || tbPSW.Text == string.Empty || tb_PSWconfirm.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل جميع البيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (tbPSW.Text != tb_PSWconfirm.Text)
                {
                    MessageBox.Show("رجاء كلمات السر غير متطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cls.ADD_users(tbUSERname.Text, tbPSW.Text, cmb_usertype.SelectedItem.ToString());
                MessageBox.Show("تم بنجاح اضافة مستخدم  جديد", "اضافةمستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TB_ID.Text = cls.fillID();
                tbUSERname.Clear();
                tbPSW.Clear();
                tb_PSWconfirm.Clear();
            }
            if (state == "update")
            {
                if (tbUSERname.Text == string.Empty || tbPSW.Text == string.Empty || tb_PSWconfirm.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل جميع البيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (tbPSW.Text != tb_PSWconfirm.Text)
                {
                    MessageBox.Show("رجاء كلمات السر غير متطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cls.Update_users(Convert.ToInt32( TB_ID.Text), tbUSERname.Text, tbPSW.Text, cmb_usertype.SelectedItem.ToString());
                MessageBox.Show("تم بنجاح تعديل معلومات المستخدم  ", "تعديل مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_PSWconfirm_Validated(object sender, EventArgs e)
        {
            if (tbPSW.Text!=tb_PSWconfirm.Text)
            {
                  MessageBox.Show("رجاء كلمات السر غير متطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

    }
}
