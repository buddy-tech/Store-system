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
    public partial class Form_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public string usertype_name;
        public static PL.Form_LOGIN frm;
        static void frm_closed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Form_LOGIN get_MainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new PL.Form_LOGIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_closed);
                }
                return frm;
            }
        }

        public Form_LOGIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(tbNAme.Text, tbPSW.Text);
            if (dt.Rows.Count>0)
            {
                if (dt.Rows[0][3].ToString() == "مدير")
                {
                    form_MAIN.get_MainForm.المبيعاتToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.المخازنToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.المشترياتToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.الموردينToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.العملاءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.المنتجاتToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.انشاءنسخةاحتياطيةToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.استعادةنسخةمحفوظةToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.تسجيلالخروجToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.ادارةالمنتجاتToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.ادارةالمخازنToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.جردكلالمخازنToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.ادارةالموردينToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.مدفوعاتالموردينToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.كشفحسابموردToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.حساباتالموردينToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.ادارةالعملاءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.مدفوعاتالعملاءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.كشفحسابعميلToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.حساباتالعملاءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.فاتورةشراءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.عرضفواتيرالشراءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.فاتورةمرتجعشراءToolStripMenuItem.Enabled = true;
                    form_MAIN.get_MainForm.فاتورةبيعToolStripMenuItem.Enabled = true;
                    form_MAIN.get_MainForm.عرضفواتيرالبيعToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.فاتورةمرتجعبيعToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.دليلالتليفونToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.اشعاراتToolStripMenuItem.Enabled = true;
                    form_MAIN.get_MainForm.الخزنةToolStripMenuItem.Enabled = true;
                    form_MAIN.get_MainForm.المستخدمينToolStripMenuItem.Enabled = true;
                    usertype_name = tbNAme.Text;
                    this.Close();
                }
                else if (dt.Rows[0][3].ToString() == "عادي")
                {
                    form_MAIN.get_MainForm.المبيعاتToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.المخازنToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.المشترياتToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.الموردينToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.العملاءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.المنتجاتToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.انشاءنسخةاحتياطيةToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.استعادةنسخةمحفوظةToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.تسجيلالخروجToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.ادارةالمنتجاتToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.ادارةالمخازنToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.جردكلالمخازنToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.ادارةالموردينToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.مدفوعاتالموردينToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.كشفحسابموردToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.حساباتالموردينToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.ادارةالعملاءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.مدفوعاتالعملاءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.كشفحسابعميلToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.حساباتالعملاءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.فاتورةشراءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.عرضفواتيرالشراءToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.فاتورةمرتجعشراءToolStripMenuItem.Enabled = true;
                    form_MAIN.get_MainForm.فاتورةبيعToolStripMenuItem.Enabled = true;
                    form_MAIN.get_MainForm.عرضفواتيرالبيعToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.فاتورةمرتجعبيعToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.دليلالتليفونToolStripMenuItem1.Enabled = true;
                    form_MAIN.get_MainForm.اشعاراتToolStripMenuItem.Enabled = true;
                    form_MAIN.get_MainForm.الخزنةToolStripMenuItem.Visible = false;
                    form_MAIN.get_MainForm.المستخدمينToolStripMenuItem.Visible = false;
                    usertype_name = tbNAme.Text;
                    this.Close();

                }

            }
            else
            {
                MessageBox.Show(" من فضلك ادخل البيانات صحيحة!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
