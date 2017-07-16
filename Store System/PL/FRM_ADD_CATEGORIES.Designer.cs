namespace Store_System.PL
{
    partial class FRM_ADD_CATEGORIES
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
            this.tbnew_cat = new System.Windows.Forms.TextBox();
            this.btn_addcategories = new System.Windows.Forms.Button();
            this.tb_IDcat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // tbnew_cat
            // 
            this.tbnew_cat.Location = new System.Drawing.Point(105, 51);
            this.tbnew_cat.Name = "tbnew_cat";
            this.tbnew_cat.Size = new System.Drawing.Size(100, 20);
            this.tbnew_cat.TabIndex = 1;
            this.tbnew_cat.Validated += new System.EventHandler(this.tbnew_cat_Validated);
            // 
            // btn_addcategories
            // 
            this.btn_addcategories.BackColor = System.Drawing.Color.Linen;
            this.btn_addcategories.Location = new System.Drawing.Point(77, 77);
            this.btn_addcategories.Name = "btn_addcategories";
            this.btn_addcategories.Size = new System.Drawing.Size(88, 42);
            this.btn_addcategories.TabIndex = 2;
            this.btn_addcategories.Text = "اضافة";
            this.btn_addcategories.UseVisualStyleBackColor = false;
            this.btn_addcategories.Click += new System.EventHandler(this.btn_addcategories_Click);
            // 
            // tb_IDcat
            // 
            this.tb_IDcat.Location = new System.Drawing.Point(105, 25);
            this.tb_IDcat.Name = "tb_IDcat";
            this.tb_IDcat.ReadOnly = true;
            this.tb_IDcat.Size = new System.Drawing.Size(100, 20);
            this.tb_IDcat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "كود الصنف";
            // 
            // FRM_ADD_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(257, 131);
            this.Controls.Add(this.tb_IDcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addcategories);
            this.Controls.Add(this.tbnew_cat);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_CATEGORIES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صنف جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbnew_cat;
        public System.Windows.Forms.Button btn_addcategories;
        public System.Windows.Forms.TextBox tb_IDcat;
        private System.Windows.Forms.Label label2;
    }
}