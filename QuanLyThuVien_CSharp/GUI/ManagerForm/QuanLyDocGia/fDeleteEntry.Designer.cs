﻿
namespace QuanLyThuVien_CSharp.GUI.ManagerForm.QLDocGia
{
    partial class fDeleteEntry
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
            this.btnDeleteAndSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbChooseDate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày muốn xóa:";
            // 
            // btnDeleteAndSave
            // 
            this.btnDeleteAndSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteAndSave.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAndSave.ForeColor = System.Drawing.Color.Blue;
            this.btnDeleteAndSave.Image = global::QuanLyThuVien_CSharp.Properties.Resources.save;
            this.btnDeleteAndSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAndSave.Location = new System.Drawing.Point(56, 110);
            this.btnDeleteAndSave.Name = "btnDeleteAndSave";
            this.btnDeleteAndSave.Size = new System.Drawing.Size(185, 54);
            this.btnDeleteAndSave.TabIndex = 1;
            this.btnDeleteAndSave.Text = "Lưu";
            this.btnDeleteAndSave.UseVisualStyleBackColor = false;
            this.btnDeleteAndSave.Click += new System.EventHandler(this.btnDeleteAndSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = global::QuanLyThuVien_CSharp.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(273, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 54);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbChooseDate
            // 
            this.cbbChooseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChooseDate.FormattingEnabled = true;
            this.cbbChooseDate.Items.AddRange(new object[] {
            "3 ngày trước",
            "7 ngày trước",
            "30 ngày trước",
            "Tất cả (trừ hôm nay)"});
            this.cbbChooseDate.Location = new System.Drawing.Point(200, 32);
            this.cbbChooseDate.Name = "cbbChooseDate";
            this.cbbChooseDate.Size = new System.Drawing.Size(244, 28);
            this.cbbChooseDate.TabIndex = 3;
            // 
            // fDeleteEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(518, 200);
            this.Controls.Add(this.cbbChooseDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteAndSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fDeleteEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDeleteEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAndSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbChooseDate;
    }
}