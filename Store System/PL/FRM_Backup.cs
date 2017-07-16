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
using System.Data;
namespace Store_System.PL
{
    public partial class FRM_Backup : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS; DataBase=Stroe_DB; Integrated Security=true;");
        SqlCommand cmd;
        public FRM_Backup()
        {
            InitializeComponent();
        }   

        private void btn_selectpath_Click(object sender, EventArgs e)
        {   

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addBackup_Click(object sender, EventArgs e)
        {
            //string DB = "Stroe System";
                conn.Open();
                string filename = tb_path.Text + "\\Stroe_DB" + " - " + DateTime.Now.ToShortDateString().Replace('/', '-') + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strqry = "BACKUP DATABASE Stroe_DB to DISK ='" + filename + ".bak'";
                cmd = new SqlCommand(strqry, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم انشاء النسخة الاحتياطية بنجاح", " انشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }
    }
}
