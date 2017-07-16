namespace Store_System.PL
{
    partial class FRM_AddNEWUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_PSWconfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_usertype = new System.Windows.Forms.ComboBox();
            this.tbUSERname = new System.Windows.Forms.TextBox();
            this.tbPSW = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.btn_ADD_Customer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_PSWconfirm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_usertype);
            this.groupBox1.Controls.Add(this.tbUSERname);
            this.groupBox1.Controls.Add(this.tbPSW);
            this.groupBox1.Controls.Add(this.TB_ID);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 182);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = " تاكيد كلمة السر";
            // 
            // tb_PSWconfirm
            // 
            this.tb_PSWconfirm.Location = new System.Drawing.Point(40, 104);
            this.tb_PSWconfirm.Name = "tb_PSWconfirm";
            this.tb_PSWconfirm.PasswordChar = '*';
            this.tb_PSWconfirm.Size = new System.Drawing.Size(162, 20);
            this.tb_PSWconfirm.TabIndex = 29;
            this.tb_PSWconfirm.Validated += new System.EventHandler(this.tb_PSWconfirm_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "نوع المستخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "كلمة السر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "الرقم";
            // 
            // cmb_usertype
            // 
            this.cmb_usertype.BackColor = System.Drawing.Color.Linen;
            this.cmb_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usertype.FormattingEnabled = true;
            this.cmb_usertype.Items.AddRange(new object[] {
            "مدير",
            "عادي"});
            this.cmb_usertype.Location = new System.Drawing.Point(40, 138);
            this.cmb_usertype.Name = "cmb_usertype";
            this.cmb_usertype.Size = new System.Drawing.Size(163, 21);
            this.cmb_usertype.TabIndex = 30;
            // 
            // tbUSERname
            // 
            this.tbUSERname.Location = new System.Drawing.Point(37, 43);
            this.tbUSERname.Name = "tbUSERname";
            this.tbUSERname.Size = new System.Drawing.Size(163, 20);
            this.tbUSERname.TabIndex = 27;
            // 
            // tbPSW
            // 
            this.tbPSW.Location = new System.Drawing.Point(38, 72);
            this.tbPSW.Name = "tbPSW";
            this.tbPSW.PasswordChar = '*';
            this.tbPSW.Size = new System.Drawing.Size(162, 20);
            this.tbPSW.TabIndex = 28;
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(37, 17);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.ReadOnly = true;
            this.TB_ID.Size = new System.Drawing.Size(163, 20);
            this.TB_ID.TabIndex = 26;
            // 
            // btn_ADD_Customer
            // 
            this.btn_ADD_Customer.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_Customer.Location = new System.Drawing.Point(76, 204);
            this.btn_ADD_Customer.Name = "btn_ADD_Customer";
            this.btn_ADD_Customer.Size = new System.Drawing.Size(95, 46);
            this.btn_ADD_Customer.TabIndex = 32;
            this.btn_ADD_Customer.Text = "اضافة المستخدم";
            this.btn_ADD_Customer.UseVisualStyleBackColor = false;
            this.btn_ADD_Customer.Click += new System.EventHandler(this.btn_ADD_Customer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(222, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 46);
            this.button1.TabIndex = 33;
            this.button1.Text = "الخروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_AddNEWUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(341, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ADD_Customer);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AddNEWUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم جيد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tb_PSWconfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbUSERname;
        public System.Windows.Forms.TextBox tbPSW;
        public System.Windows.Forms.TextBox TB_ID;
        public System.Windows.Forms.Button btn_ADD_Customer;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cmb_usertype;
    }
}