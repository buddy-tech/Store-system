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
    public partial class FRM_ADD_Customer : Form
    {
        BL.Cls_ADD_Customer add = new BL.Cls_ADD_Customer();
        public string state = "add";
        public FRM_ADD_Customer()
        {
            InitializeComponent();
            TB_ID.Text=add.fillID();
        }
        private void btn_ADD_Customer_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                add.ADD_Customer(tbCustomername.Text, tbCustomerAddress.Text, tbCustomerPhone.Text);
                MessageBox.Show("تم بنجاح اضافة عميل  جديد", "اضافةعميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if(state=="update")
            {
                add.update_Customer_INFO(Convert.ToInt32(TB_ID.Text), tbCustomername.Text, tbCustomerAddress.Text, tbCustomerPhone.Text);
                MessageBox.Show("تم بنجاح تعديل معلومات العميل  ", "تعديل معلومات عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }


    }
}
