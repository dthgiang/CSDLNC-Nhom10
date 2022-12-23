using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form7
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
            this.blbTenQuan = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDatDonHang = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.cbbThucDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonChiNhanh = new System.Windows.Forms.Button();
            this.btnChonMonAn = new System.Windows.Forms.Button();
            this.lblMieuTa = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblTongDonHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox1.Location = new System.Drawing.Point(295, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // blbTenQuan
            // 
            this.blbTenQuan.AutoSize = true;
            this.blbTenQuan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.blbTenQuan.Location = new System.Drawing.Point(251, 116);
            this.blbTenQuan.Name = "blbTenQuan";
            this.blbTenQuan.Size = new System.Drawing.Size(171, 21);
            this.blbTenQuan.TabIndex = 2;
            this.blbTenQuan.Text = "Cơm tấm Phúc Lộc Thọ";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(671, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 390);
            this.vScrollBar1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(69, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chi nhánh:";
            // 
            // btnDatDonHang
            // 
            this.btnDatDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatDonHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDatDonHang.Location = new System.Drawing.Point(219, 414);
            this.btnDatDonHang.Name = "btnDatDonHang";
            this.btnDatDonHang.Size = new System.Drawing.Size(162, 37);
            this.btnDatDonHang.TabIndex = 7;
            this.btnDatDonHang.Text = "Xác nhận đặt hàng";
            this.btnDatDonHang.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDongY.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDongY.Location = new System.Drawing.Point(396, 276);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(81, 30);
            this.btnDongY.TabIndex = 8;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHuy.Location = new System.Drawing.Point(396, 414);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(81, 37);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(159, 151);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(318, 21);
            this.cbbChiNhanh.TabIndex = 10;
            // 
            // cbbThucDon
            // 
            this.cbbThucDon.FormattingEnabled = true;
            this.cbbThucDon.Location = new System.Drawing.Point(159, 199);
            this.cbbThucDon.Name = "cbbThucDon";
            this.cbbThucDon.Size = new System.Drawing.Size(318, 21);
            this.cbbThucDon.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(69, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thực đơn:";
            // 
            // btnChonChiNhanh
            // 
            this.btnChonChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChonChiNhanh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnChonChiNhanh.Location = new System.Drawing.Point(521, 143);
            this.btnChonChiNhanh.Name = "btnChonChiNhanh";
            this.btnChonChiNhanh.Size = new System.Drawing.Size(124, 33);
            this.btnChonChiNhanh.TabIndex = 13;
            this.btnChonChiNhanh.Text = "Chọn chi nhánh";
            this.btnChonChiNhanh.UseVisualStyleBackColor = true;
            // 
            // btnChonMonAn
            // 
            this.btnChonMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChonMonAn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnChonMonAn.Location = new System.Drawing.Point(521, 192);
            this.btnChonMonAn.Name = "btnChonMonAn";
            this.btnChonMonAn.Size = new System.Drawing.Size(124, 33);
            this.btnChonMonAn.TabIndex = 14;
            this.btnChonMonAn.Text = "Chọn món ăn";
            this.btnChonMonAn.UseVisualStyleBackColor = true;
            // 
            // lblMieuTa
            // 
            this.lblMieuTa.AutoSize = true;
            this.lblMieuTa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMieuTa.Location = new System.Drawing.Point(69, 241);
            this.lblMieuTa.Name = "lblMieuTa";
            this.lblMieuTa.Size = new System.Drawing.Size(65, 21);
            this.lblMieuTa.TabIndex = 15;
            this.lblMieuTa.Text = "Miêu tả:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGia.Location = new System.Drawing.Point(69, 280);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(36, 21);
            this.lblGia.TabIndex = 15;
            this.lblGia.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(220, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số lượng: ";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(303, 282);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(48, 20);
            this.numSoLuong.TabIndex = 17;
            // 
            // lblTongDonHang
            // 
            this.lblTongDonHang.AutoSize = true;
            this.lblTongDonHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTongDonHang.Location = new System.Drawing.Point(220, 337);
            this.lblTongDonHang.Name = "lblTongDonHang";
            this.lblTongDonHang.Size = new System.Drawing.Size(119, 21);
            this.lblTongDonHang.TabIndex = 18;
            this.lblTongDonHang.Text = "Tổng đơn hàng:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(686, 482);
            this.Controls.Add(this.lblTongDonHang);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblMieuTa);
            this.Controls.Add(this.btnChonMonAn);
            this.Controls.Add(this.btnChonChiNhanh);
            this.Controls.Add(this.cbbThucDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChiNhanh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnDatDonHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.blbTenQuan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form7";
            this.Text = "THỰC ĐƠN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label blbTenQuan;
        private VScrollBar vScrollBar1;
        private Label label3;
        private Button btnDatDonHang;
        private Button btnDongY;
        private Button btnHuy;
        private ComboBox cbbChiNhanh;
        private ComboBox cbbThucDon;
        private Label label1;
        private Button btnChonChiNhanh;
        private Button btnChonMonAn;
        private Label lblMieuTa;
        private Label lblGia;
        private Label label5;
        private NumericUpDown numSoLuong;
        private Label lblTongDonHang;
    }
}