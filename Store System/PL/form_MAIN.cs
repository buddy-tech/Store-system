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
    public partial class form_MAIN : Form
    {
        public static form_MAIN frm;
        static void  frm_closed(object sender,FormClosedEventArgs  e)
        {
            frm = null;
        }
        public static form_MAIN get_MainForm
        {
            get 
            {
                if (frm==null)
                {
                    frm = new form_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_closed);
                }
                return frm;
            }
        }
        public form_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.انشاءنسخةاحتياطيةToolStripMenuItem1.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem1.Enabled = false;
            this.تسجيلالخروجToolStripMenuItem1.Enabled = false;
            this.ادارةالمنتجاتToolStripMenuItem1.Enabled = false;
            this.ادارةالمخازنToolStripMenuItem1.Enabled = false;
            this.جردكلالمخازنToolStripMenuItem1.Enabled = false;
            this.ادارةالموردينToolStripMenuItem1.Enabled = false;
            this.مدفوعاتالموردينToolStripMenuItem1.Enabled = false;
            this.كشفحسابموردToolStripMenuItem1.Enabled = false;
            this.حساباتالموردينToolStripMenuItem1.Enabled = false;
            this.ادارةالعملاءToolStripMenuItem1.Enabled = false;
            this.مدفوعاتالعملاءToolStripMenuItem1.Enabled = false;
            this.كشفحسابعميلToolStripMenuItem1.Enabled = false;
            this.حساباتالعملاءToolStripMenuItem1.Enabled = false;
            this.فاتورةشراءToolStripMenuItem1.Enabled = false;
            this.عرضفواتيرالشراءToolStripMenuItem1.Enabled = false;
            this.فاتورةمرتجعشراءToolStripMenuItem.Enabled = false;
            this.فاتورةبيعToolStripMenuItem.Enabled = false;
            this.عرضفواتيرالبيعToolStripMenuItem1.Enabled = false;
            this.فاتورةمرتجعبيعToolStripMenuItem1.Enabled = false;
            this.دليلالتليفونToolStripMenuItem1.Enabled = false;
            this.اشعاراتToolStripMenuItem.Enabled = false;
            this.المبيعاتToolStripMenuItem1.Enabled = false;
            this.المخازنToolStripMenuItem1.Enabled = false;
            this.المشترياتToolStripMenuItem1.Enabled = false;
            this.الموردينToolStripMenuItem1.Enabled = false;
            this.العملاءToolStripMenuItem1.Enabled = false;
            this.المنتجاتToolStripMenuItem1.Enabled = false;
            form_MAIN.get_MainForm.الخزنةToolStripMenuItem.Enabled = false;
            form_MAIN.get_MainForm.المستخدمينToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.Form_LOGIN frm = new Form_LOGIN();
            frm.ShowDialog();

        }

        private void فاتورةشراءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_COM_Makeorder frm = new FRM_COM_Makeorder();
            frm.ShowDialog();

        }

        private void فاتورةمرتجعشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_RetriveCOM frm = new FRM_RetriveCOM();
            frm.ShowDialog();

        }

        private void فاتورةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_MAKEORDER frm = new FRM_MAKEORDER();
            frm.ShowDialog();

        }

        private void فاتورةمرتجعبيعToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_RetriveP_INOrder frm = new FRM_RetriveP_INOrder();
            frm.ShowDialog();

        }

        private void عرضفواتيرالبيعToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_SinALL_Orders frm = new FRM_SinALL_Orders();
            frm.ShowDialog();

        }

        private void عرضفواتيرالشراءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_Sin_COMorders frm = new PL.FRM_Sin_COMorders();
            frm.ShowDialog();
        }
        private void اشعاراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_Notification frm = new FRM_Notification();
            frm.ShowDialog();

        }

        private void دليلالتليفونToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_ALLPhoneNote frm = new FRM_ALLPhoneNote();
            frm.ShowDialog();

        }

        private void ادارةالعملاءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.MANG_FRM_customers frm = new MANG_FRM_customers();
            frm.ShowDialog();

        }

        private void مدفوعاتالعملاءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_payedmoney_Customer frm = new FRM_ADD_payedmoney_Customer();
            frm.ShowDialog();

        }

        private void كشفحسابعميلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_ShowAllpayedmoney_customer frm = new FRM_ShowAllpayedmoney_customer();
            frm.ShowDialog();

        }

        private void حساباتالعملاءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_AllCusotmerOrders_notfinish frm = new FRM_AllCusotmerOrders_notfinish();
            frm.ShowDialog();

        }

        private void ادارةالموردينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.mAINFRM_Companies frm = new mAINFRM_Companies();
            frm.ShowDialog();

        }

        private void مدفوعاتالموردينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDpayedCOM frm = new FRM_ADDpayedCOM();
            frm.ShowDialog();

        }

        private void كشفحسابموردToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_showallpayedmony_company frm = new FRM_showallpayedmony_company();
            frm.ShowDialog();

        }

        private void حساباتالموردينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_AllCOM_notyetfinishTheyMoney frm = new FRM_AllCOM_notyetfinishTheyMoney();
            frm.ShowDialog();
        }

        private void ادارةالمخازنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_STOREm frm = new FRM_STOREm();
            frm.ShowDialog();

        }

        private void جردكلالمخازنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.frm_AllProduct_IN_sALLSTORES frm = new frm_AllProduct_IN_sALLSTORES();
            frm.ShowDialog();

        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_Backup frm = new FRM_Backup();
            frm.ShowDialog();

        }

        private void استعادةنسخةمحفوظةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_RetriveBackup frm = new FRM_RetriveBackup();
            frm.ShowDialog();

        }

        private void المصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BL.FRM_Allpayedmoney frm = new BL.FRM_Allpayedmoney();
            frm.ShowDialog();
        }

        private void تقريرشاملبحركةالخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_savemoney frm = new FRM_savemoney();
            frm.ShowDialog();
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_AddNEWUser frm = new FRM_AddNEWUser();
            frm.ShowDialog();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_ShowAllUsers frm = new FRM_ShowAllUsers();
            frm.ShowDialog();
        }

        private void ادارةالمنتجاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_CATEGORIES frm = new FRM_ADD_CATEGORIES();
            frm.ShowDialog();

        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_ALL_CAT frm = new FRM_ALL_CAT();
            frm.ShowDialog();
        }

        private void اضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Frm_ADDNewProudct frm = new Frm_ADDNewProudct();
            frm.ShowDialog();

        }

        private void ادارةالمنتجاتToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PL.FRM_AllProducts frm = new FRM_AllProducts();
            frm.ShowDialog();

        }

        private void تسجيلالخروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.انشاءنسخةاحتياطيةToolStripMenuItem1.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem1.Enabled = false;
            this.تسجيلالخروجToolStripMenuItem1.Enabled = false;
            this.ادارةالمنتجاتToolStripMenuItem1.Enabled = false;
            this.ادارةالمخازنToolStripMenuItem1.Enabled = false;
            this.جردكلالمخازنToolStripMenuItem1.Enabled = false;
            this.ادارةالموردينToolStripMenuItem1.Enabled = false;
            this.مدفوعاتالموردينToolStripMenuItem1.Enabled = false;
            this.كشفحسابموردToolStripMenuItem1.Enabled = false;
            this.حساباتالموردينToolStripMenuItem1.Enabled = false;
            this.ادارةالعملاءToolStripMenuItem1.Enabled = false;
            this.مدفوعاتالعملاءToolStripMenuItem1.Enabled = false;
            this.كشفحسابعميلToolStripMenuItem1.Enabled = false;
            this.حساباتالعملاءToolStripMenuItem1.Enabled = false;
            this.فاتورةشراءToolStripMenuItem1.Enabled = false;
            this.عرضفواتيرالشراءToolStripMenuItem1.Enabled = false;
            this.فاتورةمرتجعشراءToolStripMenuItem.Enabled = false;
            this.فاتورةبيعToolStripMenuItem.Enabled = false;
            this.عرضفواتيرالبيعToolStripMenuItem1.Enabled = false;
            this.فاتورةمرتجعبيعToolStripMenuItem1.Enabled = false;
            this.دليلالتليفونToolStripMenuItem1.Enabled = false;
            this.اشعاراتToolStripMenuItem.Enabled = false;
            this.المبيعاتToolStripMenuItem1.Enabled = false;
            this.المخازنToolStripMenuItem1.Enabled = false;
            this.المشترياتToolStripMenuItem1.Enabled = false;
            this.الموردينToolStripMenuItem1.Enabled = false;
            this.العملاءToolStripMenuItem1.Enabled = false;
            this.المنتجاتToolStripMenuItem1.Enabled = false;
            form_MAIN.get_MainForm.الخزنةToolStripMenuItem.Enabled = false;
            form_MAIN.get_MainForm.المستخدمينToolStripMenuItem.Enabled = false;

        }
    
        
    }
}
