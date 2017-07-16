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
    public partial class FRM_ADD_COMPAYE : Form
    {
        PL.mAINFRM_Companies frm = new PL.mAINFRM_Companies();
        BL.Cls_ADD_COM add = new BL.Cls_ADD_COM();
        public string state = "add";
        public FRM_ADD_COMPAYE()
        {
            InitializeComponent();
            TB_ID.Text = add.fillID();
        }

        private void btn_ADD_Customer_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                add.ADD_COM(tbCOMname.Text, tbCOMAddress.Text, tbCOMPhone.Text);
                MessageBox.Show("تم بنجاح اضافة مورد  جديد", "اضافةمورد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
            }
            else if (state == "update")
            {
                add.update_COM_INFO(Convert.ToInt32(TB_ID.Text), tbCOMname.Text, tbCOMAddress.Text, tbCOMPhone.Text);
                MessageBox.Show("تم بنجاح تعديل معلومات المورد  ", "تعديل معلومات ومرد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

    }
}
