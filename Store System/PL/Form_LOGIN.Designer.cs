namespace Store_System.PL
{
    partial class Form_LOGIN
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
            this.tbNAme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btn_OUT = new System.Windows.Forms.Button();
            this.tbPSW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم : ";
            // 
            // tbNAme
            // 
            this.tbNAme.Location = new System.Drawing.Point(151, 38);
            this.tbNAme.Name = "tbNAme";
            this.tbNAme.Size = new System.Drawing.Size(178, 20);
            this.tbNAme.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(81, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة السر: ";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Linen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogin.Location = new System.Drawing.Point(231, 132);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "دخول ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_OUT
            // 
            this.btn_OUT.BackColor = System.Drawing.Color.Linen;
            this.btn_OUT.Location = new System.Drawing.Point(85, 132);
            this.btn_OUT.Name = "btn_OUT";
            this.btn_OUT.Size = new System.Drawing.Size(70, 23);
            this.btn_OUT.TabIndex = 3;
            this.btn_OUT.Text = "الغاء";
            this.btn_OUT.UseVisualStyleBackColor = false;
            this.btn_OUT.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPSW
            // 
            this.tbPSW.Location = new System.Drawing.Point(151, 84);
            this.tbPSW.Name = "tbPSW";
            this.tbPSW.PasswordChar = '*';
            this.tbPSW.Size = new System.Drawing.Size(178, 20);
            this.tbPSW.TabIndex = 1;
            // 
            // Form_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(368, 183);
            this.Controls.Add(this.tbPSW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btn_OUT);
            this.Controls.Add(this.tbNAme);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_LOGIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة الدخول : ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPSW;
        public System.Windows.Forms.TextBox tbNAme;
    }
}