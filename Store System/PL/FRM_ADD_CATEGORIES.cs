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
    public partial class FRM_ADD_CATEGORIES : Form
    {
        public string state = "add";
        BL.CLS_ADD_CAT prd = new BL.CLS_ADD_CAT();
        public FRM_ADD_CATEGORIES()
        {
            InitializeComponent();
        }
        public void load_Allcat()
        {
            
             DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("getAllcategorie", null);
            FRM_ALL_CAT.get_MainForm.dataGridView1.DataSource = dt;
            DAL.close();
        }
        private void btn_addcategories_Click(object sender, EventArgs e)
        {
            if (state=="add")
            {
                tb_IDcat.Text = prd.fillID();
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
                param[0].Value = tbnew_cat.Text;
                DataTable dt = new DataTable();
                dt = DAL.SelectData("insert_NewCategory", param);
                DAL.close();

            }
            else if(state=="update")
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = tb_IDcat.Text;
                param[1] = new SqlParameter("@name", SqlDbType.VarChar,50);
                param[1].Value = tbnew_cat.Text;
                DataTable dt = new DataTable();
                dt = DAL.SelectData("update_categore", param);
                DAL.close();
                MessageBox.Show("تمت عملية التعديل بنجاح", "تعديل الصنف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                load_Allcat();
            }
        }

        private void tbnew_cat_Validated(object sender, EventArgs e)
        {
            if(state=="add")
            {
                DataTable dt = new DataTable();
                dt = prd.verify_categorieName(tbnew_cat.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الصنف موجود سابقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbnew_cat.Focus();
                    tbnew_cat.SelectionStart = 0;
                    tbnew_cat.SelectionLength = tbnew_cat.MaxLength;
                }
            }
        }

       

      
    }
}
