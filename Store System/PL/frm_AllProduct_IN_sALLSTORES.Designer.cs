namespace Store_System.PL
{
    partial class frm_AllProduct_IN_sALLSTORES
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCAT_Name = new System.Windows.Forms.ComboBox();
            this.lb_NUM_PRODUCT = new System.Windows.Forms.Label();
            this.cmbstore_NAME = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_ADD_Customer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(929, 498);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 54);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل ";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(99, 6);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Linen;
            this.btn_search.Location = new System.Drawing.Point(448, 46);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "اسم المخزن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم الصنف";
            // 
            // cmbCAT_Name
            // 
            this.cmbCAT_Name.BackColor = System.Drawing.Color.Linen;
            this.cmbCAT_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCAT_Name.FormattingEnabled = true;
            this.cmbCAT_Name.Location = new System.Drawing.Point(529, 48);
            this.cmbCAT_Name.Name = "cmbCAT_Name";
            this.cmbCAT_Name.Size = new System.Drawing.Size(121, 21);
            this.cmbCAT_Name.TabIndex = 6;
            this.cmbCAT_Name.TextChanged += new System.EventHandler(this.cmbCAT_Name_TextChanged);
            // 
            // lb_NUM_PRODUCT
            // 
            this.lb_NUM_PRODUCT.AutoSize = true;
            this.lb_NUM_PRODUCT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NUM_PRODUCT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_NUM_PRODUCT.Location = new System.Drawing.Point(77, 33);
            this.lb_NUM_PRODUCT.Name = "lb_NUM_PRODUCT";
            this.lb_NUM_PRODUCT.Size = new System.Drawing.Size(0, 19);
            this.lb_NUM_PRODUCT.TabIndex = 7;
            // 
            // cmbstore_NAME
            // 
            this.cmbstore_NAME.BackColor = System.Drawing.Color.Linen;
            this.cmbstore_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstore_NAME.FormattingEnabled = true;
            this.cmbstore_NAME.Location = new System.Drawing.Point(726, 45);
            this.cmbstore_NAME.Name = "cmbstore_NAME";
            this.cmbstore_NAME.Size = new System.Drawing.Size(121, 21);
            this.cmbstore_NAME.TabIndex = 8;
            this.cmbstore_NAME.TextChanged += new System.EventHandler(this.cmbstore_NAME_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(77, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "كل الاصناف";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tomato;
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_ADD_Customer);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lb_NUM_PRODUCT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbstore_NAME);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCAT_Name);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(929, 86);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Linen;
            this.btn_update.Location = new System.Drawing.Point(766, 3);
            this.btn_update.Margin = new System.Windows.Forms.Padding(0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(60, 25);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Linen;
            this.btn_delete.Location = new System.Drawing.Point(695, 3);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(60, 25);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_ADD_Customer
            // 
            this.btn_ADD_Customer.BackColor = System.Drawing.Color.Linen;
            this.btn_ADD_Customer.Location = new System.Drawing.Point(835, 3);
            this.btn_ADD_Customer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ADD_Customer.Name = "btn_ADD_Customer";
            this.btn_ADD_Customer.Size = new System.Drawing.Size(60, 25);
            this.btn_ADD_Customer.TabIndex = 25;
            this.btn_ADD_Customer.Text = "اضافة";
            this.btn_ADD_Customer.UseVisualStyleBackColor = false;
            this.btn_ADD_Customer.Click += new System.EventHandler(this.btn_ADD_Customer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tomato;
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Location = new System.Drawing.Point(1, 591);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(929, 56);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
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
            // frm_AllProduct_IN_sALLSTORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AllProduct_IN_sALLSTORES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة جرد كل المخازن";
            this.Load += new System.EventHandler(this.frm_AllProduct_IN_sALLSTORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCAT_Name;
        private System.Windows.Forms.Label lb_NUM_PRODUCT;
        private System.Windows.Forms.ComboBox cmbstore_NAME;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_ADD_Customer;
    }
}