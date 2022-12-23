using System.Windows.Forms;

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
            this.label3 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.cbbMaDonHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox1.Location = new System.Drawing.Point(219, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDongY.Location = new System.Drawing.Point(191, 290);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(73, 26);
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(74, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(74, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(180, 189);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(192, 20);
            this.txtComment.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(74, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rate stars:";
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(180, 230);
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
            this.numRate.Size = new System.Drawing.Size(103, 20);
            this.numRate.TabIndex = 9;
            this.numRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTroVe.Location = new System.Drawing.Point(270, 290);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(73, 26);
            this.btnTroVe.TabIndex = 10;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(394, 150);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(66, 26);
            this.btnChon.TabIndex = 11;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // cbbMaDonHang
            // 
            this.cbbMaDonHang.FormattingEnabled = true;
            this.cbbMaDonHang.Location = new System.Drawing.Point(180, 153);
            this.cbbMaDonHang.Name = "cbbMaDonHang";
            this.cbbMaDonHang.Size = new System.Drawing.Size(192, 21);
            this.cbbMaDonHang.TabIndex = 12;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(518, 337);
            this.Controls.Add(this.cbbMaDonHang);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.numRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form6";
            this.Text = "ĐÁNH GIÁ ĐƠN HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnDongY;
        private Label label2;
        private Label label3;
        private TextBox txtComment;
        private Label label4;
        private NumericUpDown numRate;
        private Button btnTroVe;
        private Button btnChon;
        private ComboBox cbbMaDonHang;
    }
}