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
            this.components = new System.ComponentModel.Container();
            this.lblTenQuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnChonChiNhanh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbbThucDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnDatDonHang = new System.Windows.Forms.Button();
            this.lblMieuTa = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.btnChonMonAn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenQuan
            // 
            this.lblTenQuan.AutoSize = true;
            this.lblTenQuan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTenQuan.Location = new System.Drawing.Point(365, 34);
            this.lblTenQuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenQuan.Name = "lblTenQuan";
            this.lblTenQuan.Size = new System.Drawing.Size(262, 32);
            this.lblTenQuan.TabIndex = 2;
            this.lblTenQuan.Text = "Cơm tấm Phúc Lộc Thọ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(205, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chi nhánh:";
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(790, 354);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(104, 32);
            this.btnDongY.TabIndex = 15;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(354, 79);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(390, 28);
            this.cbbChiNhanh.TabIndex = 28;
            // 
            // btnChonChiNhanh
            // 
            this.btnChonChiNhanh.Location = new System.Drawing.Point(832, 75);
            this.btnChonChiNhanh.Name = "btnChonChiNhanh";
            this.btnChonChiNhanh.Size = new System.Drawing.Size(75, 32);
            this.btnChonChiNhanh.TabIndex = 29;
            this.btnChonChiNhanh.Text = "Chọn";
            this.btnChonChiNhanh.UseVisualStyleBackColor = true;
            this.btnChonChiNhanh.Click += new System.EventHandler(this.btnChonChiNhanh_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbbThucDon
            // 
            this.cbbThucDon.FormattingEnabled = true;
            this.cbbThucDon.Location = new System.Drawing.Point(354, 192);
            this.cbbThucDon.Name = "cbbThucDon";
            this.cbbThucDon.Size = new System.Drawing.Size(382, 28);
            this.cbbThucDon.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Thực đơn";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(553, 326);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 26);
            this.numSoLuong.TabIndex = 35;
            // 
            // btnDatDonHang
            // 
            this.btnDatDonHang.Location = new System.Drawing.Point(141, 494);
            this.btnDatDonHang.Name = "btnDatDonHang";
            this.btnDatDonHang.Size = new System.Drawing.Size(287, 71);
            this.btnDatDonHang.TabIndex = 36;
            this.btnDatDonHang.Text = "ĐẶT ĐƠN HÀNG";
            this.btnDatDonHang.UseVisualStyleBackColor = true;
            this.btnDatDonHang.Click += new System.EventHandler(this.btnDatDonHang_Click);
            // 
            // lblMieuTa
            // 
            this.lblMieuTa.AutoSize = true;
            this.lblMieuTa.Location = new System.Drawing.Point(224, 266);
            this.lblMieuTa.Name = "lblMieuTa";
            this.lblMieuTa.Size = new System.Drawing.Size(61, 20);
            this.lblMieuTa.TabIndex = 37;
            this.lblMieuTa.Text = "Miêu tả";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(224, 332);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(34, 20);
            this.lblGia.TabIndex = 38;
            this.lblGia.Text = "Giá";
            // 
            // btnChonMonAn
            // 
            this.btnChonMonAn.Location = new System.Drawing.Point(810, 188);
            this.btnChonMonAn.Name = "btnChonMonAn";
            this.btnChonMonAn.Size = new System.Drawing.Size(132, 32);
            this.btnChonMonAn.TabIndex = 39;
            this.btnChonMonAn.Text = "Chọn món ăn";
            this.btnChonMonAn.UseVisualStyleBackColor = true;
            this.btnChonMonAn.Click += new System.EventHandler(this.btnChonMonAn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(713, 494);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 71);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(417, 438);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(116, 20);
            this.lblTong.TabIndex = 42;
            this.lblTong.Text = "Tổng đơn hàng";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(634, 494);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(125, 71);
            this.btnTroVe.TabIndex = 43;
            this.btnTroVe.Text = "TRỞ VỀ";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ghi chú";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(553, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 26);
            this.textBox1.TabIndex = 45;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1026, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChonMonAn);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblMieuTa);
            this.Controls.Add(this.btnDatDonHang);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbThucDon);
            this.Controls.Add(this.btnChonChiNhanh);
            this.Controls.Add(this.cbbChiNhanh);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenQuan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form7";
            this.Text = "THỰC ĐƠN";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTenQuan;
        private Label label3;
        private Button btnDongY;
        private ComboBox cbbChiNhanh;
        private Button btnChonChiNhanh;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cbbThucDon;
        private Label label1;
        private NumericUpDown numSoLuong;
        private Button btnDatDonHang;
        private Label lblMieuTa;
        private Label lblGia;
        private Button btnChonMonAn;
        private Button btnHuy;
        private Label lblTong;
        private Button btnTroVe;
        private Label label2;
        private TextBox textBox1;
    }
}