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
    public partial class FRM_COM_Makeorder : Form
    {     
        BL.CLS_MakeORDER cls = new BL.CLS_MakeORDER();
        frm_AllProduct_IN_sALLSTORES frm = new frm_AllProduct_IN_sALLSTORES();
        DataTable dt;
        public string state = "add";
        public string Old_QTY;
        public int counter = 0;

        public FRM_COM_Makeorder()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FRM_COM_Makeorder_Load(object sender, EventArgs e)
        {
            tb_usertypeName.Text = Form_LOGIN.get_MainForm.usertype_name;
            tb_ORDER_ID.Text = cls.fillCOMID();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = new DataTable();
            dt = DAL.SelectData("Load_OrderType", null);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmb_OrderType.Items.Add(dt.Rows[i].ItemArray[0]);
                cmb_OrderType.Text = dt.Rows[0].ItemArray[0].ToString();
            }
            dt = DAL.SelectData("load_type", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmb_type.Items.Add(dt.Rows[i].ItemArray[0]);

        }           //true
        private void btn_SProduct_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            lb_nameProduct.Text = frm.product_Name;
            lb_AllQuntity.Text = frm.product_Quantity;
            tb_productID.Text = frm.product_ID;
            tb_storeName.Text = frm.Store_name;
            cmb_type.Text = frm.product_Type;
            tb_price.Text = frm.price_Sentence;


        }                 //true
         
        private void btn_SCustomer_Click(object sender, EventArgs e)
        {
            PL.mAINFRM_Companies frm = new PL.mAINFRM_Companies();
            frm.ShowDialog();
            tb_customer_name.Text = frm.COM_name;
            lb_CustomerID.Text = frm.COM_ID;
        }            //true


        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }      //true
        private void cmb_type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_type.Text.ToString() == "وحدة ")
                tb_price.Text = frm.price_Sector;
            else if (cmb_type.Text.ToString() == "كرتونة ")
                tb_price.Text = frm.price_Sentence;

        }      //true
        
        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Quantity.Text!="")
                lb_RQuantiity.Text = (Convert.ToInt32(lb_AllQuntity.Text)+ Convert.ToInt32(tb_Quantity.Text)).ToString();
            else
                MessageBox.Show("تمن فضلك ادخل كمية من الصنف", "اضافة كمية من صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }             //true
        private void btn_AddOrder_Click(object sender, EventArgs e)
        {        
            int exist=0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
			  if (tb_productID.Text==dataGridView1.Rows[i].Cells[0].Value.ToString())
              {
                  exist++;
                  MessageBox.Show( "موجود مسبقا في الفاتورة " +" " +  lb_nameProduct.Text + " " +" هذا الصنف ", "اضافةصنف موجود", MessageBoxButtons.OK, MessageBoxIcon.Information);              
              }
              break;
			}
            if (exist == 0)
            {
                if (state == "add")
                {
                    decimal overAll_total = 0;
                    int OTID = Convert.ToInt32(cls.GETID("GETID_Type", cmb_OrderType.SelectedItem.ToString()));
                    int TID = Convert.ToInt32(cls.GETID("GET_Prodcut_type", cmb_OrderType.SelectedItem.ToString()));
                    int usertype_ID = Convert.ToInt32(cls.GETID("Get_usertype_ID", tb_usertypeName.Text));
                    decimal total_PProduct = Convert.ToInt32(tb_Quantity.Text) * Convert.ToDecimal(tb_price.Text);

                    if (counter == 0)
                        cls.ADD_COM_Order(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(lb_CustomerID.Text), OTID,usertype_ID);
                    counter++;
                    cls.ADD_COM_OrderDetails(TID, Convert.ToInt32(tb_productID.Text), Convert.ToInt32(tb_ORDER_ID.Text), Convert.ToInt32(tb_Quantity.Text), total_PProduct);
                    cls.Update_MProduct_QTY(Convert.ToInt32(tb_productID.Text), Convert.ToInt32(tb_Quantity.Text),1);
                    MessageBox.Show(lb_nameProduct.Text +" "+ "تم بنجاح اضافة طلب من الصنف", "اضافةطلب من صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int rowId = dataGridView1.Rows.Add();
                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    // Add the data
                    row.Cells["Column1"].Value = tb_productID.Text;
                    row.Cells["Column2"].Value = lb_nameProduct.Text;
                    row.Cells["Column3"].Value = cmb_type.Text.ToString();
                    row.Cells["Column4"].Value = tb_price.Text;
                    row.Cells["Column5"].Value = tb_Quantity.Text;
                    row.Cells["Column6"].Value = total_PProduct.ToString();
                    row.Cells["Column7"].Value = tb_usertypeName.ToString();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                         overAll_total +=  Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    lb_overALLtotal.Text = overAll_total.ToString();

                }
                else if (state == "update")
                {
                    decimal overAll_total = 0;
                    int TID = Convert.ToInt32(cls.GETID("GET_Prodcut_type", cmb_OrderType.SelectedItem.ToString()));
                    decimal total_PProduct = Convert.ToInt32(tb_Quantity.Text) * Convert.ToDecimal(tb_price.Text);
                    cls.Update_COM_OrderDetails(TID, Convert.ToInt32(tb_productID.Text), Convert.ToInt32(tb_ORDER_ID.Text), Convert.ToInt32(tb_Quantity.Text), total_PProduct);
                    cls.Update_BProduct_QTY(Convert.ToInt32(tb_productID.Text),Convert.ToInt32(Old_QTY),Convert.ToInt32(tb_Quantity.Text));
                    MessageBox.Show(lb_nameProduct.Text +" "+ "تم بنجاح تعديل الطلب من الصنف", "تعديل طلب من صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int rowId = dataGridView1.Rows.Add();
                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    // Add the data
                    row.Cells["Column1"].Value = tb_productID.Text;
                    row.Cells["Column2"].Value = lb_nameProduct.Text;
                    row.Cells["Column3"].Value = cmb_type.Text.ToString();
                    row.Cells["Column4"].Value = tb_price.Text;
                    row.Cells["Column5"].Value = tb_Quantity.Text;
                    row.Cells["Column6"].Value = total_PProduct.ToString();
                    row.Cells["Column7"].Value = tb_usertypeName.ToString();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        overAll_total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    lb_overALLtotal.Text = overAll_total.ToString();
                }

            }
            

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal overAll_total = 0;          
            if (MessageBox.Show("هل انت متاكد من تعديل الصنف؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Old_QTY=dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                btn_AddOrder.Text = "تعديل";
                state = "update";
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    dataGridView1.Rows.RemoveAt(item.Index);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    overAll_total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                lb_overALLtotal.Text = overAll_total.ToString();

            }
            else
                MessageBox.Show("تم الغاء عملية التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                tb_productID.Text = row.Cells[0].Value.ToString();
                lb_nameProduct.Text = row.Cells[1].Value.ToString();
                cmb_type.Text = row.Cells[2].Value.ToString(); ;
                tb_price.Text = row.Cells[3].Value.ToString();
                tb_Quantity.Text = row.Cells[4].Value.ToString();
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int New_QTY = 0;
            decimal overAll_total = 0;
            if (MessageBox.Show("هل انت متاكد من حذف هذا الصنف من الفاتورة؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Old_QTY=this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cls.Update_BProduct_QTY(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value),New_QTY,Convert.ToInt32(Old_QTY));
                cls.DELETE_PinCOM_OrderDetails(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف الصنف من الفاتورة بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                     dataGridView1.Rows.RemoveAt(item.Index);
            }  

            else
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                overAll_total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
            lb_overALLtotal.Text = overAll_total.ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم حفظ الفاتورة بنجاح", "عملية حفظ الفاتورة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cls.save_OverAlltotalORDERCOM(Convert.ToInt32(tb_ORDER_ID.Text), Convert.ToDecimal(lb_overALLtotal.Text));
            tb_ORDER_ID.Text = cls.fillCOMID();
            tb_customer_name.Text = "";
            lb_CustomerID.Text = "";
            lb_nameProduct.Text = "";
            tb_productID.Text = "";
            tb_price.Text = "";
            tb_Quantity.Text = "";
            lb_AllQuntity.Text = "";
            lb_RQuantiity.Text = "";
            cmb_type.SelectedIndex = 2;
            dataGridView1.Rows.Clear();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
