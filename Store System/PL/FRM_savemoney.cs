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
    public partial class FRM_savemoney : Form
    {
        BL.CLS_Show_save cls = new BL.CLS_Show_save();
        public FRM_savemoney()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_searchORDER_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
             DataTable dt3 = new DataTable();
             dt1 = cls.SEARCH_SaveIN_SpaceficDate("SEARCH_SaveINCOM_SpaceficDate", Convert.ToDateTime(dateTimePicker2.Text), Convert.ToDateTime(dateTimePicker1.Text));
            dt2=cls.SEARCH_SaveIN_SpaceficDate("SEARCH_SaveINCustomer_SpaceficDate",Convert.ToDateTime(dateTimePicker2.Text),Convert.ToDateTime(dateTimePicker1.Text));
            dt3 = cls.SEARCH_SaveIN_SpaceficDate("SEARCH_SaveINPayed_SpaceficDate", Convert.ToDateTime(dateTimePicker2.Text), Convert.ToDateTime(dateTimePicker1.Text));
            dt1.Merge(dt2);
            dt1.Merge(dt3);
            dataGridView1.DataSource = dt1;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
