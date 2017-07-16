namespace Store_System.PL
{
    partial class FRM_add_PhoneNote
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.btn_ADD_Customer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(102, 55);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(150, 20);
            this.tbname.TabIndex = 10;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(102, 90);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(149, 20);
            this.tbPhone.TabIndex = 12;
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(102, 29);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.ReadOnly = true;
            this.TB_ID.Size = new System.Drawing.Size(150, 20);
            this.TB_ID.TabIndex = 8;
            // 
            // btn_ADD_Customer
            // 
            this.btn_ADD_Customer.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_Customer.Location = new System.Drawing.Point(138, 131);
            this.btn_ADD_Customer.Name = "btn_ADD_Customer";
            this.btn_ADD_Customer.Size = new System.Drawing.Size(75, 50);
            this.btn_ADD_Customer.TabIndex = 14;
            this.btn_ADD_Customer.Text = "اضافة";
            this.btn_ADD_Customer.UseVisualStyleBackColor = false;
            this.btn_ADD_Customer.Click += new System.EventHandler(this.btn_ADD_Customer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "اسم الشخص ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "التليفون ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "الرقم";
            // 
            // FRM_add_PhoneNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(287, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.btn_ADD_Customer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_add_PhoneNote";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة تليفون";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbname;
        public System.Windows.Forms.TextBox tbPhone;
        public System.Windows.Forms.TextBox TB_ID;
        public System.Windows.Forms.Button btn_ADD_Customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}