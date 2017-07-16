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
    public partial class FRM_paymoney : Form
    {
        BL.CLS_Show_save add = new BL.CLS_Show_save();
        public string state = "add";
        public FRM_paymoney()
        {
            InitializeComponent();
            tbPayID.Text = add.fillID();
        }
        private void btn_ADD_payedmoney_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                add.Add_Paymoney_INFO(tb_PayName.Text, tb_payDescription.Text, Convert.ToDecimal(tb_Payamount.Text), Convert.ToDateTime(dateTimePicker1.Text));
                add.Add_moneySaver_Payed_INFO(Convert.ToInt32(tbPayID.Text), 1, 1, Convert.ToDateTime(dateTimePicker1.Text), 5); //user name
                MessageBox.Show("تم بنجاح اضافة مصروف  جديد", "اضافةمصروف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (state == "update")
            {
                add.update_payedmoney_INFO(Convert.ToInt32(tbPayID.Text), tb_PayName.Text, tb_payDescription.Text, Convert.ToDecimal(tb_Payamount.Text), Convert.ToDateTime(dateTimePicker1.Text));
                add.Add_moneySaver_Payed_INFO(Convert.ToInt32(tbPayID.Text), 1, 1, Convert.ToDateTime(dateTimePicker1.Text), 5); //user name
                MessageBox.Show("تم بنجاح تعديل مصروف  جديد", "تعديل مصروف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

    }
}
