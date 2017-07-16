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
    public partial class FRM_Notification : Form
    {
        BL.CLS_notification cls = new BL.CLS_notification();
        DataTable dt;
        bool chare = true;

        public FRM_Notification()
        {
            InitializeComponent();
            load_all_pnotificatin_name();
            radioButton1.Checked = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void load_all_pnotification()
        {
            DataTable ds = new DataTable();
            ds = cls.LOAD_ALL_Pnotification_todgv();
            dataGridView1.DataSource = ds;
            lb_NUM_CUSTOMER.Text = "عددالمنتجات علي وشك النفاذ:" + " " + dataGridView1.RowCount.ToString();
        }
        public void load_all_pnotificatin_name()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            dt = new DataTable();
            dt = DAL.SelectData("load_pnotification_NAME", null);
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbCUT_Name.Items.Add(dt.Rows[i].ItemArray[0]);
        }

        private void FRM_Notification_Load(object sender, EventArgs e)
        {
            load_all_pnotification();
        }

        private void btn_search_cut_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            if (cmbCUT_Name.Text != "")
            {
                DataTable dt = new DataTable();
                dt = cls.SEARCH_AllPnotification_NAME(cmbCUT_Name.SelectedItem.ToString());
                dataGridView1.DataSource = dt;
                lb_NUM_CUSTOMER.Text = "عددالمنتجات علي وشك النفاذ:" + " " + dataGridView1.RowCount.ToString();
            }
            else
            {
                load_all_pnotification();
            }

        }

        private void btn_ADD_payedmoney_Click(object sender, EventArgs e)
        {
            PL.FRM_COM_Makeorder frm = new PL.FRM_COM_Makeorder();
            frm.ShowDialog();
            frm.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                flag(true);
            }
            if (radioButton1.Checked == true)
            {
                flag(false);
                load_all_pnotification();
            }

        }
        public void flag(bool _chare)
        {
            chare = _chare;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && chare == true)
            {
                radioButton1.Checked = false;
            }
            chare = true;
            cmbCUT_Name.SelectedIndex = 0;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
