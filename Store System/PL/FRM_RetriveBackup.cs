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
    public partial class FRM_RetriveBackup : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS; DataBase=master; Integrated Security=true;");
        SqlCommand cmd;
        public FRM_RetriveBackup()
        {
            InitializeComponent();
        }

        private void btn_selectpath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                tb_path.Text = openFileDialog1.FileName;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addBackup_Click(object sender, EventArgs e)
        {
            conn.Open();
            string strqry = "Alter database Stroe_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE Stroe System to DISK = '" + tb_path.Text + "'";
            cmd = new SqlCommand(strqry, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("تم استرجاع النسخة الاحتياطية بنجاح", " استرجاع النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
