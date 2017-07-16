namespace Store_System.PL
{
    partial class FRM_Notification
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
            this.cmbCUT_Name = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lb_NUM_CUSTOMER = new System.Windows.Forms.Label();
            this.btn_search_cut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ADD_payedmoney = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCUT_Name
            // 
            this.cmbCUT_Name.BackColor = System.Drawing.Color.Linen;
            this.cmbCUT_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCUT_Name.FormattingEnabled = true;
            this.cmbCUT_Name.Location = new System.Drawing.Point(687, 34);
            this.cmbCUT_Name.Name = "cmbCUT_Name";
            this.cmbCUT_Name.Size = new System.Drawing.Size(116, 21);
            this.cmbCUT_Name.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(931, 408);
            this.dataGridView1.TabIndex = 25;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 17);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.Text = "كل المنتجات علي وشك النفاذ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // lb_NUM_CUSTOMER
            // 
            this.lb_NUM_CUSTOMER.AutoSize = true;
            this.lb_NUM_CUSTOMER.Location = new System.Drawing.Point(33, 42);
            this.lb_NUM_CUSTOMER.Name = "lb_NUM_CUSTOMER";
            this.lb_NUM_CUSTOMER.Size = new System.Drawing.Size(0, 13);
            this.lb_NUM_CUSTOMER.TabIndex = 29;
            // 
            // btn_search_cut
            // 
            this.btn_search_cut.BackColor = System.Drawing.Color.Linen;
            this.btn_search_cut.Location = new System.Drawing.Point(601, 34);
            this.btn_search_cut.Name = "btn_search_cut";
            this.btn_search_cut.Size = new System.Drawing.Size(60, 25);
            this.btn_search_cut.TabIndex = 28;
            this.btn_search_cut.Text = "بحث";
            this.btn_search_cut.UseVisualStyleBackColor = false;
            this.btn_search_cut.Click += new System.EventHandler(this.btn_search_cut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "بحث بدلالة اسم المنتج";
            // 
            // btn_ADD_payedmoney
            // 
            this.btn_ADD_payedmoney.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_payedmoney.Location = new System.Drawing.Point(849, 0);
            this.btn_ADD_payedmoney.Name = "btn_ADD_payedmoney";
            this.btn_ADD_payedmoney.Size = new System.Drawing.Size(60, 25);
            this.btn_ADD_payedmoney.TabIndex = 24;
            this.btn_ADD_payedmoney.Text = "اضافة";
            this.btn_ADD_payedmoney.UseVisualStyleBackColor = false;
            this.btn_ADD_payedmoney.Click += new System.EventHandler(this.btn_ADD_payedmoney_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tomato;
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Location = new System.Drawing.Point(2, 481);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(931, 56);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Linen;
            this.btn_cancel.Location = new System.Drawing.Point(49, 13);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 34);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "خروج";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tomato;
            this.groupBox2.Controls.Add(this.cmbCUT_Name);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.lb_NUM_CUSTOMER);
            this.groupBox2.Controls.Add(this.btn_ADD_payedmoney);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_search_cut);
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(931, 66);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // FRM_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Notification";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المنتجات علي وشك النفاذ من المخزن";
            this.Load += new System.EventHandler(this.FRM_Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCUT_Name;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lb_NUM_CUSTOMER;
        private System.Windows.Forms.Button btn_search_cut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ADD_payedmoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}