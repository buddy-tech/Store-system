namespace Store_System.PL
{
    partial class FRM_ADD_COMPAYE
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
            this.tbCOMname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCOMPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCOMAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.btn_ADD_Customer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCOMname
            // 
            this.tbCOMname.Location = new System.Drawing.Point(42, 51);
            this.tbCOMname.Name = "tbCOMname";
            this.tbCOMname.Size = new System.Drawing.Size(150, 20);
            this.tbCOMname.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "اسم المورد ";
            // 
            // tbCOMPhone
            // 
            this.tbCOMPhone.Location = new System.Drawing.Point(43, 110);
            this.tbCOMPhone.Name = "tbCOMPhone";
            this.tbCOMPhone.Size = new System.Drawing.Size(149, 20);
            this.tbCOMPhone.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "التليفون ";
            // 
            // tbCOMAddress
            // 
            this.tbCOMAddress.Location = new System.Drawing.Point(43, 80);
            this.tbCOMAddress.Name = "tbCOMAddress";
            this.tbCOMAddress.Size = new System.Drawing.Size(149, 20);
            this.tbCOMAddress.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "العنوان ";
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(42, 25);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(150, 20);
            this.TB_ID.TabIndex = 8;
            // 
            // btn_ADD_Customer
            // 
            this.btn_ADD_Customer.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_Customer.Location = new System.Drawing.Point(93, 151);
            this.btn_ADD_Customer.Name = "btn_ADD_Customer";
            this.btn_ADD_Customer.Size = new System.Drawing.Size(75, 50);
            this.btn_ADD_Customer.TabIndex = 14;
            this.btn_ADD_Customer.Text = "اضافة";
            this.btn_ADD_Customer.UseVisualStyleBackColor = false;
            this.btn_ADD_Customer.Click += new System.EventHandler(this.btn_ADD_Customer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "الرقم";
            // 
            // FRM_ADD_COMPAYE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.tbCOMname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCOMPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCOMAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.btn_ADD_Customer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_COMPAYE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مورد جديد ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbCOMname;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbCOMPhone;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbCOMAddress;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_ID;
        public System.Windows.Forms.Button btn_ADD_Customer;
        private System.Windows.Forms.Label label1;
    }
}