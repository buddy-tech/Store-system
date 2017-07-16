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
    public partial class FRM_add_PhoneNote : Form
    {
        BL.CLS_PhoneNote add = new BL.CLS_PhoneNote();
        public string state = "add";
        public FRM_add_PhoneNote()
        {
            InitializeComponent();
            TB_ID.Text = add.fillID();
        }

        private void btn_ADD_Customer_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                add.ADD_PhoneNote(tbname.Text,tbPhone.Text);
                MessageBox.Show("تم بنجاح اضافة تليفون شخص جديد", "اضافةرقم تليفون ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (state == "update")
            {
                add.update_Phonenote_INFO(Convert.ToInt32(TB_ID.Text), tbname.Text, tbPhone.Text);
                MessageBox.Show("تم بنجاح تعديل معلومات رقم التليفون  ", "تعديل معلومات رقم تليفون  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

    }
}
