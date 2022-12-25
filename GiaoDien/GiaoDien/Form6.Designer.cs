using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace GiaoDien
{
    partial class Form6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.cbbMaDonHang = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMonAn = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(328, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDongY.Location = new System.Drawing.Point(575, 526);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(110, 40);
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(131, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblComment.Location = new System.Drawing.Point(145, 361);
            this.lblComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(114, 30);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(300, 366);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(286, 26);
            this.txtComment.TabIndex = 7;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRate.Location = new System.Drawing.Point(148, 428);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(111, 30);
            this.lblRate.TabIndex = 8;
            this.lblRate.Text = "Rate stars:";
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(300, 432);
            this.numRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numRate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(154, 26);
            this.numRate.TabIndex = 9;
            this.numRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbMaDonHang
            // 
            this.cbbMaDonHang.FormattingEnabled = true;
            this.cbbMaDonHang.Location = new System.Drawing.Point(300, 253);
            this.cbbMaDonHang.Name = "cbbMaDonHang";
            this.cbbMaDonHang.Size = new System.Drawing.Size(286, 28);
            this.cbbMaDonHang.TabIndex = 10;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(637, 250);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 33);
            this.btnChon.TabIndex = 11;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(244, 529);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(166, 40);
            this.btnTroVe.TabIndex = 12;
            this.btnTroVe.Text = "Trờ về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(164, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Món ăn";
            // 
            // cbbMonAn
            // 
            this.cbbMonAn.FormattingEnabled = true;
            this.cbbMonAn.Location = new System.Drawing.Point(300, 315);
            this.cbbMonAn.Name = "cbbMonAn";
            this.cbbMonAn.Size = new System.Drawing.Size(286, 28);
            this.cbbMonAn.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1039, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbMonAn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbMaDonHang);
            this.Controls.Add(this.numRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form6";
            this.Text = "ĐÁNH GIÁ ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnDongY;
        private Label label2;
        private Label lblComment;
        private TextBox txtComment;
        private Label lblRate;
        private NumericUpDown numRate;
        private ComboBox cbbMaDonHang;
        private Button btnChon;
        private Button btnTroVe;
        private Label label1;
        private ComboBox cbbMonAn;
        private Button button1;
    }
}