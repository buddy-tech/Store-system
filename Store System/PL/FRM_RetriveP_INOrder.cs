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
    public partial class FRM_RetriveP_INOrder : Form
    {
        BL.CLS_MakeORDER cls = new BL.CLS_MakeORDER();
        PL.frm_AllProduct_IN_sALLSTORES frm =new PL.frm_AllProduct_IN_sALLSTORES();
        DataTable dt;
        string state="add";
        string Old_QTY;
        public FRM_RetriveP_INOrder()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void FRM_RetriveP_INOrder_Load(object sender, EventArgs e)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = new DataTable();
            dt = DAL.SelectData("Load_OrderType", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmb_OrderType.Items.Add(dt.Rows[i].ItemArray[0]);

            dt = DAL.SelectData("load_type", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmb_type.Items.Add(dt.Rows[i].ItemArray[0]);



        }

        private void btn_SearchAll_Orders_Click(object sender, EventArgs e)
        {
            PL.FRM_SinALL_Orders frm = new PL.FRM_SinALL_Orders();
            frm.ShowDialog();   
            tb_ORDER_ID.Text = frm.Order_ID;
            dateTimePicker1.Text = frm.Order_Date;
            cmb_OrderType.Text = frm.Order_Type;
            tb_customer_name.Text = frm.customer_name;
            lb_CustomerID.Text = frm.customer_ID;
            tb_usertypeName.Text = frm.usertype_ID;
            dt=cls.Load_AllOrderDetails_SOrderID(Convert.ToInt32( frm.Order_ID));
            dataGridView1.DataSource = dt;
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal overAll_total = 0;
            lb_AllQuntity.Text = cls.Load_ProductQTY(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            if (MessageBox.Show("هل انت متاكد من تعديل الصنف؟", "عملية التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
             {
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
                tb_usertypeName.Text = row.Cells[5].Value.ToString();
            }

        }

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
                    decimal total_PProduct = Convert.ToInt32(tb_Quantity.Text) * Convert.ToDecimal(tb_price.Text);
                    cls.ADD_OrderDetails(TID, Convert.ToInt32(tb_productID.Text), Convert.ToInt32(tb_ORDER_ID.Text), Convert.ToInt32(tb_Quantity.Text), total_PProduct);
                    cls.Update_MProduct_QTY(Convert.ToInt32(tb_productID.Text), Convert.ToInt32(tb_Quantity.Text),-1);
                    MessageBox.Show(lb_nameProduct.Text + " " + "تم بنجاح اضافة طلب من الصنف", "اضافةطلب من صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = cls.Load_AllOrderDetails_SOrderID(Convert.ToInt32(tb_ORDER_ID.Text));
                    dataGridView1.DataSource = dt;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        overAll_total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    lb_overALLtotal.Text = overAll_total.ToString();
                }
                else if(state=="update")
                {
                    decimal overAll_total = 0;
                    int TID = Convert.ToInt32(cls.GETID("GET_Prodcut_type", cmb_OrderType.SelectedItem.ToString()));
                    decimal total_PProduct = Convert.ToInt32(tb_Quantity.Text) * Convert.ToDecimal(tb_price.Text);
                    cls.Update_OrderDetails(TID, Convert.ToInt32(tb_productID.Text), Convert.ToInt32(tb_ORDER_ID.Text), Convert.ToInt32(tb_Quantity.Text), total_PProduct);

                    MessageBox.Show(lb_nameProduct.Text + " " + "تم بنجاح تعديل الطلب من الصنف", "تعديل طلب من صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = cls.Load_AllOrderDetails_SOrderID(Convert.ToInt32(tb_ORDER_ID.Text));
                    dataGridView1.DataSource = dt;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        overAll_total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                    lb_overALLtotal.Text = overAll_total.ToString();

                }
            }


        }

        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void cmb_type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_type.Text.ToString() == "وحدة ")
                tb_price.Text = frm.price_Sector;
            else if (cmb_type.Text.ToString() == "كرتونة ")
                tb_price.Text = frm.price_Sentence;


        }

        private void btn_SProduct_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            lb_nameProduct.Text = frm.product_Name;
            lb_AllQuntity.Text = frm.product_Quantity;
            tb_productID.Text = frm.product_ID;
            tb_storeName.Text = frm.Store_name;
            cmb_type.Text = frm.product_Type;
            tb_price.Text = frm.price_Sentence;



        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Quantity.Text.ToString() != "")
            {  
                 if(state=="add")
                 {      
                     lb_AllQuntity.Text = cls.Load_ProductQTY(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                      lb_RQuantiity.Text = (Convert.ToInt32(lb_AllQuntity.Text) - Convert.ToInt32(tb_Quantity.Text)).ToString();
                 }
                 else if (state == "update")
                         lb_RQuantiity.Text = (Convert.ToInt32(lb_AllQuntity.Text) - (Convert.ToInt32(tb_Quantity.Text))).ToString();
            }
            else
                MessageBox.Show("تمن فضلك ادخل كمية من الصنف", "اضافة كمية من صنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int new_QTY = 0;
            Old_QTY=this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            decimal overAll_total = 0;
            if (MessageBox.Show("هل انت متاكد من حذف هذا الصنف من الفاتورة؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls.Update_BProduct_QTY(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(Old_QTY), new_QTY);
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
            cls.save_OverAlltotalORDER(Convert.ToInt32(tb_ORDER_ID.Text), Convert.ToDecimal(lb_overALLtotal.Text));
            tb_customer_name.Text = "";
            lb_CustomerID.Text = "";
            lb_nameProduct.Text = "";
            tb_productID.Text = "";
            tb_price.Text = "";
            tb_Quantity.Text = "";
            lb_AllQuntity.Text = "";
            lb_RQuantiity.Text = "";
            tb_usertypeName.Text = "";
            cmb_type.SelectedIndex = 2;
            dataGridView1.Rows.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.تعديلToolStripMenuItem_Click(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.حذفToolStripMenuItem_Click(sender, e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
