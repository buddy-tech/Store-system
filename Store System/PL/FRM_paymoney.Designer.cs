namespace Store_System.PL
{
    partial class FRM_paymoney
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
            this.btn_ADD_payedmoney = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbPayID = new System.Windows.Forms.TextBox();
            this.lb_NAME = new System.Windows.Forms.Label();
            this.tb_Payamount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_PayName = new System.Windows.Forms.TextBox();
            this.tb_payDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ADD_payedmoney
            // 
            this.btn_ADD_payedmoney.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_payedmoney.Location = new System.Drawing.Point(112, 197);
            this.btn_ADD_payedmoney.Name = "btn_ADD_payedmoney";
            this.btn_ADD_payedmoney.Size = new System.Drawing.Size(75, 50);
            this.btn_ADD_payedmoney.TabIndex = 5;
            this.btn_ADD_payedmoney.Text = "اضافة";
            this.btn_ADD_payedmoney.UseVisualStyleBackColor = false;
            this.btn_ADD_payedmoney.Click += new System.EventHandler(this.btn_ADD_payedmoney_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "التاريخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // tbPayID
            // 
            this.tbPayID.Location = new System.Drawing.Point(75, 21);
            this.tbPayID.Name = "tbPayID";
            this.tbPayID.ReadOnly = true;
            this.tbPayID.Size = new System.Drawing.Size(176, 20);
            this.tbPayID.TabIndex = 0;
            // 
            // lb_NAME
            // 
            this.lb_NAME.AutoSize = true;
            this.lb_NAME.Location = new System.Drawing.Point(12, 46);
            this.lb_NAME.Name = "lb_NAME";
            this.lb_NAME.Size = new System.Drawing.Size(58, 13);
            this.lb_NAME.TabIndex = 40;
            this.lb_NAME.Text = "اسم العميل ";
            this.lb_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Payamount
            // 
            this.tb_Payamount.Location = new System.Drawing.Point(76, 133);
            this.tb_Payamount.Name = "tb_Payamount";
            this.tb_Payamount.Size = new System.Drawing.Size(175, 20);
            this.tb_Payamount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "المبلغ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "الرقم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "البيان ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_PayName
            // 
            this.tb_PayName.Location = new System.Drawing.Point(76, 46);
            this.tb_PayName.Name = "tb_PayName";
            this.tb_PayName.Size = new System.Drawing.Size(175, 20);
            this.tb_PayName.TabIndex = 1;
            // 
            // tb_payDescription
            // 
            this.tb_payDescription.Location = new System.Drawing.Point(75, 72);
            this.tb_payDescription.Multiline = true;
            this.tb_payDescription.Name = "tb_payDescription";
            this.tb_payDescription.Size = new System.Drawing.Size(175, 55);
            this.tb_payDescription.TabIndex = 2;
            // 
            // FRM_paymoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(290, 273);
            this.Controls.Add(this.tb_payDescription);
            this.Controls.Add(this.tb_PayName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ADD_payedmoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbPayID);
            this.Controls.Add(this.lb_NAME);
            this.Controls.Add(this.tb_Payamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_paymoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مصروف جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_ADD_payedmoney;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox tbPayID;
        public System.Windows.Forms.Label lb_NAME;
        public System.Windows.Forms.TextBox tb_Payamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_PayName;
        public System.Windows.Forms.TextBox tb_payDescription;
    }
}