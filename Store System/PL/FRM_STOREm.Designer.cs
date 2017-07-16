namespace Store_System.PL
{
    partial class FRM_STOREm
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
            this.tb_IDSTORE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addcategories = new System.Windows.Forms.Button();
            this.tbnew_STORE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tb_IDSTORE
            // 
            this.tb_IDSTORE.Location = new System.Drawing.Point(125, 26);
            this.tb_IDSTORE.Name = "tb_IDSTORE";
            this.tb_IDSTORE.ReadOnly = true;
            this.tb_IDSTORE.Size = new System.Drawing.Size(159, 20);
            this.tb_IDSTORE.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "كود المخزن";
            // 
            // btn_addcategories
            // 
            this.btn_addcategories.BackColor = System.Drawing.Color.Linen;
            this.btn_addcategories.Location = new System.Drawing.Point(92, 89);
            this.btn_addcategories.Name = "btn_addcategories";
            this.btn_addcategories.Size = new System.Drawing.Size(75, 23);
            this.btn_addcategories.TabIndex = 7;
            this.btn_addcategories.Text = "اضافة";
            this.btn_addcategories.UseVisualStyleBackColor = false;
            this.btn_addcategories.Click += new System.EventHandler(this.btn_addcategories_Click);
            // 
            // tbnew_STORE
            // 
            this.tbnew_STORE.Location = new System.Drawing.Point(125, 52);
            this.tbnew_STORE.Name = "tbnew_STORE";
            this.tbnew_STORE.Size = new System.Drawing.Size(159, 20);
            this.tbnew_STORE.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المخزن";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Linen;
            this.btn_delete.Location = new System.Drawing.Point(252, 89);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "مسح";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Linen;
            this.btn_update.Location = new System.Drawing.Point(171, 89);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Location = new System.Drawing.Point(92, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = ">|";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Linen;
            this.button5.Location = new System.Drawing.Point(64, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = ">";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Linen;
            this.button6.Location = new System.Drawing.Point(1, 134);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "<|";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Linen;
            this.button7.Location = new System.Drawing.Point(38, 134);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(20, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "<";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(252, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "اضافة جديد";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // FRM_STOREm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(339, 169);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tb_IDSTORE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addcategories);
            this.Controls.Add(this.tbnew_STORE);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_STOREm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مخزن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_IDSTORE;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_addcategories;
        public System.Windows.Forms.TextBox tbnew_STORE;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}