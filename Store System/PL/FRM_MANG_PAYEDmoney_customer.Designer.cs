namespace Store_System.PL
{
    partial class FRM_MANG_PAYEDmoney_customer
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
            this.components = new System.ComponentModel.Container();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lb_NUM_CUSTOMER = new System.Windows.Forms.Label();
            this.btn_search_cut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCUT_Name = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ADD_payedmoneyCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(47, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.Text = "كل مدفوعات العملاء";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // lb_NUM_CUSTOMER
            // 
            this.lb_NUM_CUSTOMER.AutoSize = true;
            this.lb_NUM_CUSTOMER.Location = new System.Drawing.Point(104, 43);
            this.lb_NUM_CUSTOMER.Name = "lb_NUM_CUSTOMER";
            this.lb_NUM_CUSTOMER.Size = new System.Drawing.Size(0, 13);
            this.lb_NUM_CUSTOMER.TabIndex = 22;
            // 
            // btn_search_cut
            // 
            this.btn_search_cut.BackColor = System.Drawing.Color.Linen;
            this.btn_search_cut.Location = new System.Drawing.Point(509, 25);
            this.btn_search_cut.Name = "btn_search_cut";
            this.btn_search_cut.Size = new System.Drawing.Size(60, 25);
            this.btn_search_cut.TabIndex = 21;
            this.btn_search_cut.Text = "بحث";
            this.btn_search_cut.UseVisualStyleBackColor = false;
            this.btn_search_cut.Click += new System.EventHandler(this.btn_search_cut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "بحث بدلالة اسم العميل";
            // 
            // cmbCUT_Name
            // 
            this.cmbCUT_Name.BackColor = System.Drawing.Color.Linen;
            this.cmbCUT_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCUT_Name.FormattingEnabled = true;
            this.cmbCUT_Name.Location = new System.Drawing.Point(592, 28);
            this.cmbCUT_Name.Name = "cmbCUT_Name";
            this.cmbCUT_Name.Size = new System.Drawing.Size(116, 21);
            this.cmbCUT_Name.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(5, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(825, 419);
            this.dataGridView1.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 54);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // btn_ADD_payedmoneyCustomer
            // 
            this.btn_ADD_payedmoneyCustomer.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_payedmoneyCustomer.Location = new System.Drawing.Point(757, 0);
            this.btn_ADD_payedmoneyCustomer.Name = "btn_ADD_payedmoneyCustomer";
            this.btn_ADD_payedmoneyCustomer.Size = new System.Drawing.Size(60, 25);
            this.btn_ADD_payedmoneyCustomer.TabIndex = 17;
            this.btn_ADD_payedmoneyCustomer.Text = "اضافة";
            this.btn_ADD_payedmoneyCustomer.UseVisualStyleBackColor = false;
            this.btn_ADD_payedmoneyCustomer.Click += new System.EventHandler(this.btn_ADD_payedmoneyCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tomato;
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Location = new System.Drawing.Point(-1, 490);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(831, 56);
            this.groupBox1.TabIndex = 24;
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
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_ADD_payedmoneyCustomer);
            this.groupBox2.Controls.Add(this.lb_NUM_CUSTOMER);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_search_cut);
            this.groupBox2.Controls.Add(this.cmbCUT_Name);
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(825, 65);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Linen;
            this.btn_update.Location = new System.Drawing.Point(683, 0);
            this.btn_update.Margin = new System.Windows.Forms.Padding(0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(60, 25);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Linen;
            this.btn_delete.Location = new System.Drawing.Point(612, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(60, 25);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // FRM_MANG_PAYEDmoney_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_MANG_PAYEDmoney_customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة مدفوعات العملاء";
            this.Load += new System.EventHandler(this.FRM_MANG_PAYEDmoney_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lb_NUM_CUSTOMER;
        private System.Windows.Forms.Button btn_search_cut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCUT_Name;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ADD_payedmoneyCustomer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}