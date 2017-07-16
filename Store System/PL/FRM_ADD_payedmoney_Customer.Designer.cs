namespace Store_System.PL
{
    partial class FRM_ADD_payedmoney_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCustomername = new System.Windows.Forms.TextBox();
            this.lb_NAME = new System.Windows.Forms.Label();
            this.tbCustomerpayed_money = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ADD_payedmoneyCustomer = new System.Windows.Forms.Button();
            this.btn_Searchcustomer = new System.Windows.Forms.Button();
            this.lb_customerID = new System.Windows.Forms.Label();
            this.lb_totalmoney = new System.Windows.Forms.Label();
            this.lb_remainMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_orderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_OrderID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCustomername
            // 
            this.tbCustomername.Location = new System.Drawing.Point(70, 45);
            this.tbCustomername.Name = "tbCustomername";
            this.tbCustomername.ReadOnly = true;
            this.tbCustomername.Size = new System.Drawing.Size(176, 20);
            this.tbCustomername.TabIndex = 1;
            // 
            // lb_NAME
            // 
            this.lb_NAME.AutoSize = true;
            this.lb_NAME.Location = new System.Drawing.Point(6, 48);
            this.lb_NAME.Name = "lb_NAME";
            this.lb_NAME.Size = new System.Drawing.Size(58, 13);
            this.lb_NAME.TabIndex = 22;
            this.lb_NAME.Text = "اسم العميل ";
            this.lb_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCustomerpayed_money
            // 
            this.tbCustomerpayed_money.Location = new System.Drawing.Point(70, 103);
            this.tbCustomerpayed_money.Name = "tbCustomerpayed_money";
            this.tbCustomerpayed_money.Size = new System.Drawing.Size(175, 20);
            this.tbCustomerpayed_money.TabIndex = 3;
            this.tbCustomerpayed_money.TextChanged += new System.EventHandler(this.tbCustomerpayed_money_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "المبلغ";
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(70, 19);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.ReadOnly = true;
            this.TB_ID.Size = new System.Drawing.Size(176, 20);
            this.TB_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "الرقم";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "التاريخ";
            // 
            // btn_ADD_payedmoneyCustomer
            // 
            this.btn_ADD_payedmoneyCustomer.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_payedmoneyCustomer.Location = new System.Drawing.Point(106, 167);
            this.btn_ADD_payedmoneyCustomer.Name = "btn_ADD_payedmoneyCustomer";
            this.btn_ADD_payedmoneyCustomer.Size = new System.Drawing.Size(75, 50);
            this.btn_ADD_payedmoneyCustomer.TabIndex = 5;
            this.btn_ADD_payedmoneyCustomer.Text = "اضافة";
            this.btn_ADD_payedmoneyCustomer.UseVisualStyleBackColor = false;
            this.btn_ADD_payedmoneyCustomer.Click += new System.EventHandler(this.btn_ADD_payedmoneyCustomer_Click);
            // 
            // btn_Searchcustomer
            // 
            this.btn_Searchcustomer.BackColor = System.Drawing.Color.Linen;
            this.btn_Searchcustomer.Location = new System.Drawing.Point(292, 45);
            this.btn_Searchcustomer.Name = "btn_Searchcustomer";
            this.btn_Searchcustomer.Size = new System.Drawing.Size(34, 19);
            this.btn_Searchcustomer.TabIndex = 2;
            this.btn_Searchcustomer.Text = "...";
            this.btn_Searchcustomer.UseVisualStyleBackColor = false;
            this.btn_Searchcustomer.Click += new System.EventHandler(this.btn_Searchcustomer_Click);
            // 
            // lb_customerID
            // 
            this.lb_customerID.AutoSize = true;
            this.lb_customerID.Location = new System.Drawing.Point(252, 48);
            this.lb_customerID.Name = "lb_customerID";
            this.lb_customerID.Size = new System.Drawing.Size(0, 13);
            this.lb_customerID.TabIndex = 27;
            // 
            // lb_totalmoney
            // 
            this.lb_totalmoney.AutoSize = true;
            this.lb_totalmoney.Location = new System.Drawing.Point(251, 106);
            this.lb_totalmoney.Name = "lb_totalmoney";
            this.lb_totalmoney.Size = new System.Drawing.Size(9, 13);
            this.lb_totalmoney.TabIndex = 28;
            this.lb_totalmoney.Text = "l";
            // 
            // lb_remainMoney
            // 
            this.lb_remainMoney.AutoSize = true;
            this.lb_remainMoney.Location = new System.Drawing.Point(386, 106);
            this.lb_remainMoney.Name = "lb_remainMoney";
            this.lb_remainMoney.Size = new System.Drawing.Size(9, 13);
            this.lb_remainMoney.TabIndex = 29;
            this.lb_remainMoney.Text = "l";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "باقي المبلغ";
            // 
            // tb_orderID
            // 
            this.tb_orderID.Location = new System.Drawing.Point(70, 71);
            this.tb_orderID.Name = "tb_orderID";
            this.tb_orderID.ReadOnly = true;
            this.tb_orderID.Size = new System.Drawing.Size(176, 20);
            this.tb_orderID.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "رقم الفاتورة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OrderID
            // 
            this.btn_OrderID.BackColor = System.Drawing.Color.Linen;
            this.btn_OrderID.Location = new System.Drawing.Point(292, 72);
            this.btn_OrderID.Name = "btn_OrderID";
            this.btn_OrderID.Size = new System.Drawing.Size(34, 19);
            this.btn_OrderID.TabIndex = 33;
            this.btn_OrderID.Text = "...";
            this.btn_OrderID.UseVisualStyleBackColor = false;
            this.btn_OrderID.Click += new System.EventHandler(this.btn_OrderID_Click);
            // 
            // FRM_ADD_payedmoney_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(443, 244);
            this.Controls.Add(this.btn_OrderID);
            this.Controls.Add(this.tb_orderID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_remainMoney);
            this.Controls.Add(this.lb_totalmoney);
            this.Controls.Add(this.lb_customerID);
            this.Controls.Add(this.btn_Searchcustomer);
            this.Controls.Add(this.btn_ADD_payedmoneyCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbCustomername);
            this.Controls.Add(this.lb_NAME);
            this.Controls.Add(this.tbCustomerpayed_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_payedmoney_Customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مبلغ جديد";
            this.Load += new System.EventHandler(this.FRM_ADD_payedmoney_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbCustomername;
        public System.Windows.Forms.TextBox tbCustomerpayed_money;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_ADD_payedmoneyCustomer;
        public System.Windows.Forms.Button btn_Searchcustomer;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label lb_customerID;
        public System.Windows.Forms.Label lb_NAME;
        private System.Windows.Forms.Label lb_totalmoney;
        private System.Windows.Forms.Label lb_remainMoney;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_orderID;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_OrderID;
    }
}