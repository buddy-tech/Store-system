namespace Store_System.PL
{
    partial class Frm_ADDNewProudct
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
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.cmb_storename = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbproductname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSellSprice = new System.Windows.Forms.TextBox();
            this.tbbuyprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbminiqty = new System.Windows.Forms.TextBox();
            this.tbselPprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbqty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbminiprice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_categories = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Ptype = new System.Windows.Forms.ComboBox();
            this.lb_sentence = new System.Windows.Forms.Label();
            this.lb_sector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(154, 39);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.ReadOnly = true;
            this.TB_ID.Size = new System.Drawing.Size(100, 20);
            this.TB_ID.TabIndex = 0;
            // 
            // cmb_storename
            // 
            this.cmb_storename.BackColor = System.Drawing.Color.Linen;
            this.cmb_storename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_storename.FormattingEnabled = true;
            this.cmb_storename.Location = new System.Drawing.Point(151, 141);
            this.cmb_storename.Name = "cmb_storename";
            this.cmb_storename.Size = new System.Drawing.Size(121, 21);
            this.cmb_storename.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "كود المنتج";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(304, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 21);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = "....";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم المنتج";
            // 
            // tbproductname
            // 
            this.tbproductname.Location = new System.Drawing.Point(152, 103);
            this.tbproductname.Name = "tbproductname";
            this.tbproductname.Size = new System.Drawing.Size(100, 20);
            this.tbproductname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "سعر البيع جملة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "سعر الشراء";
            // 
            // tbSellSprice
            // 
            this.tbSellSprice.Location = new System.Drawing.Point(151, 254);
            this.tbSellSprice.Name = "tbSellSprice";
            this.tbSellSprice.Size = new System.Drawing.Size(100, 20);
            this.tbSellSprice.TabIndex = 5;
            this.tbSellSprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSellSprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSellSprice_KeyPress);
            // 
            // tbbuyprice
            // 
            this.tbbuyprice.Location = new System.Drawing.Point(151, 218);
            this.tbbuyprice.Name = "tbbuyprice";
            this.tbbuyprice.Size = new System.Drawing.Size(100, 20);
            this.tbbuyprice.TabIndex = 4;
            this.tbbuyprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbbuyprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbuyprice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "اسم المخزن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "حد الطلب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "سعر البيع قطاعي";
            // 
            // tbminiqty
            // 
            this.tbminiqty.Location = new System.Drawing.Point(152, 363);
            this.tbminiqty.Name = "tbminiqty";
            this.tbminiqty.Size = new System.Drawing.Size(100, 20);
            this.tbminiqty.TabIndex = 8;
            this.tbminiqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbminiqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbminiqty_KeyPress);
            // 
            // tbselPprice
            // 
            this.tbselPprice.Location = new System.Drawing.Point(151, 289);
            this.tbselPprice.Name = "tbselPprice";
            this.tbselPprice.Size = new System.Drawing.Size(100, 20);
            this.tbselPprice.TabIndex = 6;
            this.tbselPprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbselPprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbselPprice_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "رصيد سابق";
            // 
            // tbqty
            // 
            this.tbqty.Location = new System.Drawing.Point(152, 397);
            this.tbqty.Name = "tbqty";
            this.tbqty.Size = new System.Drawing.Size(100, 20);
            this.tbqty.TabIndex = 9;
            this.tbqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbqty_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "سعر حد ادني البيع";
            // 
            // tbminiprice
            // 
            this.tbminiprice.Location = new System.Drawing.Point(154, 327);
            this.tbminiprice.Name = "tbminiprice";
            this.tbminiprice.Size = new System.Drawing.Size(100, 20);
            this.tbminiprice.TabIndex = 7;
            this.tbminiprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbminiprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbminiprice_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "الصنف";
            // 
            // cmb_categories
            // 
            this.cmb_categories.BackColor = System.Drawing.Color.Linen;
            this.cmb_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categories.FormattingEnabled = true;
            this.cmb_categories.Location = new System.Drawing.Point(154, 68);
            this.cmb_categories.Name = "cmb_categories";
            this.cmb_categories.Size = new System.Drawing.Size(121, 21);
            this.cmb_categories.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Linen;
            this.btn_add.Location = new System.Drawing.Point(199, 449);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 21);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "اضافة ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(278, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 21);
            this.button2.TabIndex = 20;
            this.button2.TabStop = false;
            this.button2.Text = "....";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Location = new System.Drawing.Point(295, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 21);
            this.button3.TabIndex = 21;
            this.button3.TabStop = false;
            this.button3.Text = "....";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "الوحدة";
            // 
            // cmb_Ptype
            // 
            this.cmb_Ptype.BackColor = System.Drawing.Color.Linen;
            this.cmb_Ptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ptype.FormattingEnabled = true;
            this.cmb_Ptype.Location = new System.Drawing.Point(152, 184);
            this.cmb_Ptype.Name = "cmb_Ptype";
            this.cmb_Ptype.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ptype.TabIndex = 22;
            this.cmb_Ptype.Leave += new System.EventHandler(this.cmb_Ptype_Leave);
            // 
            // lb_sentence
            // 
            this.lb_sentence.AutoSize = true;
            this.lb_sentence.Location = new System.Drawing.Point(88, 258);
            this.lb_sentence.Name = "lb_sentence";
            this.lb_sentence.Size = new System.Drawing.Size(0, 13);
            this.lb_sentence.TabIndex = 24;
            // 
            // lb_sector
            // 
            this.lb_sector.AutoSize = true;
            this.lb_sector.Location = new System.Drawing.Point(99, 293);
            this.lb_sector.Name = "lb_sector";
            this.lb_sector.Size = new System.Drawing.Size(0, 13);
            this.lb_sector.TabIndex = 25;
            // 
            // Frm_ADDNewProudct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(346, 480);
            this.Controls.Add(this.lb_sector);
            this.Controls.Add(this.lb_sentence);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_Ptype);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_categories);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbminiprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbqty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbminiqty);
            this.Controls.Add(this.tbselPprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSellSprice);
            this.Controls.Add(this.tbbuyprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_storename);
            this.Controls.Add(this.tbproductname);
            this.Controls.Add(this.TB_ID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ADDNewProudct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة منتج جديد";
            this.Load += new System.EventHandler(this.Frm_ADDNewProudct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TB_ID;
        public System.Windows.Forms.ComboBox cmb_storename;
        public System.Windows.Forms.TextBox tbproductname;
        public System.Windows.Forms.TextBox tbSellSprice;
        public System.Windows.Forms.TextBox tbbuyprice;
        public System.Windows.Forms.TextBox tbminiqty;
        public System.Windows.Forms.TextBox tbselPprice;
        public System.Windows.Forms.TextBox tbqty;
        public System.Windows.Forms.TextBox tbminiprice;
        public System.Windows.Forms.ComboBox cmb_categories;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmb_Ptype;
        private System.Windows.Forms.Label lb_sentence;
        private System.Windows.Forms.Label lb_sector;
    }
}