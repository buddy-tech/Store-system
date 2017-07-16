namespace Store_System.PL
{
    partial class FRM_ADD_Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ADD_Customer = new System.Windows.Forms.Button();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرقم";
            // 
            // btn_ADD_Customer
            // 
            this.btn_ADD_Customer.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_Customer.Location = new System.Drawing.Point(94, 143);
            this.btn_ADD_Customer.Name = "btn_ADD_Customer";
            this.btn_ADD_Customer.Size = new System.Drawing.Size(75, 50);
            this.btn_ADD_Customer.TabIndex = 4;
            this.btn_ADD_Customer.Text = "اضافة";
            this.btn_ADD_Customer.UseVisualStyleBackColor = false;
            this.btn_ADD_Customer.Click += new System.EventHandler(this.btn_ADD_Customer_Click);
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(43, 17);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(150, 20);
            this.TB_ID.TabIndex = 0;
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(44, 72);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(149, 20);
            this.tbCustomerAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "العنوان ";
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Location = new System.Drawing.Point(44, 102);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(149, 20);
            this.tbCustomerPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "التليفون ";
            // 
            // tbCustomername
            // 
            this.tbCustomername.Location = new System.Drawing.Point(43, 43);
            this.tbCustomername.Name = "tbCustomername";
            this.tbCustomername.Size = new System.Drawing.Size(150, 20);
            this.tbCustomername.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم العميل ";
            // 
            // FRM_ADD_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(274, 215);
            this.Controls.Add(this.tbCustomername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCustomerPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCustomerAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.btn_ADD_Customer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_Customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة عميل جديد ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TB_ID;
        public System.Windows.Forms.TextBox tbCustomerAddress;
        public System.Windows.Forms.TextBox tbCustomerPhone;
        public System.Windows.Forms.TextBox tbCustomername;
        public System.Windows.Forms.Button btn_ADD_Customer;
    }
}