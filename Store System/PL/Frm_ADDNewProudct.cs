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
    public partial class Frm_ADDNewProudct : Form
    {
        BL.ClSADDneWpRODUCT add = new BL.ClSADDneWpRODUCT();
        public string state = "add";
        public Frm_ADDNewProudct()
        {
            InitializeComponent();
            TB_ID.Text=add.fillID();
        }

        private void Frm_ADDNewProudct_Load(object sender, EventArgs e)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("load_categoires", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmb_categories.Items.Add(dt.Rows[i].ItemArray[0]);
            dt = DAL.SelectData("LOAD_STROEnAME", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmb_storename.Items.Add(dt.Rows[i].ItemArray[0]);
            dt = DAL.SelectData("load_type", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmb_Ptype.Items.Add(dt.Rows[i].ItemArray[0]);


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                int store_ID = add.get_SGID("GET_STOREID", cmb_storename.SelectedItem.ToString());
                int categore_ID = add.get_SGID("GetCatID", cmb_categories.SelectedItem.ToString());
                int Ptype_ID = add.get_SGID("GetPtypeID", cmb_Ptype.SelectedItem.ToString());

                add.ADD_product(store_ID, tbproductname.Text, categore_ID,Ptype_ID, Convert.ToDecimal(tbbuyprice.Text), Convert.ToDecimal(tbSellSprice.Text), Convert.ToDecimal(tbselPprice.Text), Convert.ToDecimal(tbminiprice.Text), Convert.ToInt32(tbminiqty.Text), Convert.ToInt32(tbqty.Text));
                MessageBox.Show("تم بنجاح اضافة المنتج", "اضافةمنتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if(state=="update")
            {
                int store_ID = add.get_SGID("GET_STOREID", cmb_storename.SelectedItem.ToString());
                int categore_ID = add.get_SGID("GetCatID", cmb_categories.SelectedItem.ToString());
                int Ptype_ID = add.get_SGID("GetPtypeID", cmb_Ptype.SelectedItem.ToString());
                add.update_product_INFO(Convert.ToInt32(TB_ID.Text),store_ID, tbproductname.Text, categore_ID,Ptype_ID, Convert.ToDecimal(tbbuyprice.Text), Convert.ToDecimal(tbSellSprice.Text), Convert.ToDecimal(tbselPprice.Text), Convert.ToDecimal(tbminiprice.Text), Convert.ToInt32(tbminiqty.Text), Convert.ToInt32(tbqty.Text));
                MessageBox.Show("تم بنجاح تعديل المنتج", "تعديل منتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_CATEGORIES frm = new FRM_ADD_CATEGORIES();
            frm.ShowDialog();
        }

        private void tbbuyprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void tbminiqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbSellSprice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void tbselPprice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void tbminiprice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_STOREm frm = new FRM_STOREm();
            frm.ShowDialog();
        }

        private void cmb_Ptype_Leave(object sender, EventArgs e)
        {
            lb_sector.Text =  "وحدة";
            lb_sentence.Text =cmb_Ptype.SelectedItem.ToString();
        }
        
       

       

       

       
    }
}
