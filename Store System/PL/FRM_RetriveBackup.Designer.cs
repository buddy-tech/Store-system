﻿namespace Store_System.PL
{
    partial class FRM_RetriveBackup
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addBackup = new System.Windows.Forms.Button();
            this.btn_selectpath = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Linen;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(345, 106);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_addBackup
            // 
            this.btn_addBackup.BackColor = System.Drawing.Color.Linen;
            this.btn_addBackup.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBackup.Location = new System.Drawing.Point(207, 106);
            this.btn_addBackup.Name = "btn_addBackup";
            this.btn_addBackup.Size = new System.Drawing.Size(132, 23);
            this.btn_addBackup.TabIndex = 8;
            this.btn_addBackup.Text = "انشاء نسخة احتياطية";
            this.btn_addBackup.UseVisualStyleBackColor = false;
            this.btn_addBackup.Click += new System.EventHandler(this.btn_addBackup_Click);
            // 
            // btn_selectpath
            // 
            this.btn_selectpath.BackColor = System.Drawing.Color.Linen;
            this.btn_selectpath.Location = new System.Drawing.Point(372, 55);
            this.btn_selectpath.Name = "btn_selectpath";
            this.btn_selectpath.Size = new System.Drawing.Size(31, 23);
            this.btn_selectpath.TabIndex = 7;
            this.btn_selectpath.Text = "....";
            this.btn_selectpath.UseVisualStyleBackColor = false;
            this.btn_selectpath.Click += new System.EventHandler(this.btn_selectpath_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(12, 55);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(342, 23);
            this.tb_path.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "رجاءا قم بتحديد مسار تواجد النسخة الاحتياطية";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FRM_RetriveBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(435, 167);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addBackup);
            this.Controls.Add(this.btn_selectpath);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_RetriveBackup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استعادة النسخ الاحتياطية المحفوظة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_addBackup;
        private System.Windows.Forms.Button btn_selectpath;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}