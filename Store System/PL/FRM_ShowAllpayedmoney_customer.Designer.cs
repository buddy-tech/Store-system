namespace Store_System.PL
{
    partial class FRM_ShowAllpayedmoney_customer
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
            this.tb_Customername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_searchcustomerNAme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Totalmoney_orders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_customerID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_moneytaken = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Customername
            // 
            this.tb_Customername.Location = new System.Drawing.Point(475, 16);
            this.tb_Customername.Name = "tb_Customername";
            this.tb_Customername.Size = new System.Drawing.Size(126, 20);
            this.tb_Customername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "بحث بدلالة اسم العميل";
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Linen;
            this.btn_show.Location = new System.Drawing.Point(269, 14);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(117, 23);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "عرض كشف الحساب";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(724, 194);
            this.dataGridView1.TabIndex = 19;
            // 
            // btn_searchcustomerNAme
            // 
            this.btn_searchcustomerNAme.BackColor = System.Drawing.Color.Linen;
            this.btn_searchcustomerNAme.Location = new System.Drawing.Point(412, 14);
            this.btn_searchcustomerNAme.Name = "btn_searchcustomerNAme";
            this.btn_searchcustomerNAme.Size = new System.Drawing.Size(25, 23);
            this.btn_searchcustomerNAme.TabIndex = 20;
            this.btn_searchcustomerNAme.Text = "...";
            this.btn_searchcustomerNAme.UseVisualStyleBackColor = false;
            this.btn_searchcustomerNAme.Click += new System.EventHandler(this.btn_searchcustomerNAme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tomato;
            this.groupBox1.Controls.Add(this.lb_Totalmoney_orders);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 31);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lb_Totalmoney_orders
            // 
            this.lb_Totalmoney_orders.AutoSize = true;
            this.lb_Totalmoney_orders.Location = new System.Drawing.Point(491, 15);
            this.lb_Totalmoney_orders.Name = "lb_Totalmoney_orders";
            this.lb_Totalmoney_orders.Size = new System.Drawing.Size(9, 13);
            this.lb_Totalmoney_orders.TabIndex = 3;
            this.lb_Totalmoney_orders.Text = "l";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "مجموع الفواتير المستحقة";
            // 
            // lb_customerID
            // 
            this.lb_customerID.AutoSize = true;
            this.lb_customerID.Location = new System.Drawing.Point(460, 19);
            this.lb_customerID.Name = "lb_customerID";
            this.lb_customerID.Size = new System.Drawing.Size(9, 13);
            this.lb_customerID.TabIndex = 22;
            this.lb_customerID.Text = "l";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tomato;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lb_moneytaken);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 544);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 31);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "l";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "المبلغ المتبقي";
            // 
            // lb_moneytaken
            // 
            this.lb_moneytaken.AutoSize = true;
            this.lb_moneytaken.Location = new System.Drawing.Point(491, 15);
            this.lb_moneytaken.Name = "lb_moneytaken";
            this.lb_moneytaken.Size = new System.Drawing.Size(9, 13);
            this.lb_moneytaken.TabIndex = 3;
            this.lb_moneytaken.Text = "l";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "مجموع المقبوضات من العميل";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 291);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(724, 247);
            this.dataGridView2.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tomato;
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Location = new System.Drawing.Point(3, 572);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(724, 70);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Tomato;
            this.groupBox4.Controls.Add(this.btn_show);
            this.groupBox4.Controls.Add(this.btn_searchcustomerNAme);
            this.groupBox4.Controls.Add(this.lb_customerID);
            this.groupBox4.Controls.Add(this.tb_Customername);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(3, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(724, 51);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // FRM_ShowAllpayedmoney_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 638);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ShowAllpayedmoney_customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كشف حساب عميل";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Customername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_show;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_searchcustomerNAme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Totalmoney_orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_customerID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_moneytaken;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}