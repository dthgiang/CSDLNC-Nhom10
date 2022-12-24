using GiaoDien.Properties;
using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongTinChiTiet = new System.Windows.Forms.Button();
            this.btnLichSuDonHang = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDanhGia = new System.Windows.Forms.Button();
            this.btnTheoDoiDonHang = new System.Windows.Forms.Button();
            this.btnTatCaCuaHang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTiemKiemMonAn = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button6 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.btnThongTinChiTiet);
            this.panel1.Controls.Add(this.btnLichSuDonHang);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnDanhGia);
            this.panel1.Controls.Add(this.btnTheoDoiDonHang);
            this.panel1.Controls.Add(this.btnTatCaCuaHang);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 453);
            this.panel1.TabIndex = 0;
            // 
            // btnThongTinChiTiet
            // 
            this.btnThongTinChiTiet.Location = new System.Drawing.Point(19, 357);
            this.btnThongTinChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongTinChiTiet.Name = "btnThongTinChiTiet";
            this.btnThongTinChiTiet.Size = new System.Drawing.Size(160, 28);
            this.btnThongTinChiTiet.TabIndex = 8;
            this.btnThongTinChiTiet.Text = "Thông tin chi tiết";
            this.btnThongTinChiTiet.UseVisualStyleBackColor = true;
            this.btnThongTinChiTiet.Click += new System.EventHandler(this.btnThongTinChiTiet_Click);
            // 
            // btnLichSuDonHang
            // 
            this.btnLichSuDonHang.Location = new System.Drawing.Point(35, 184);
            this.btnLichSuDonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLichSuDonHang.Name = "btnLichSuDonHang";
            this.btnLichSuDonHang.Size = new System.Drawing.Size(122, 45);
            this.btnLichSuDonHang.TabIndex = 7;
            this.btnLichSuDonHang.Text = "Lịch sử đơn hàng";
            this.btnLichSuDonHang.UseVisualStyleBackColor = true;
            this.btnLichSuDonHang.Click += new System.EventHandler(this.btnLichSuDonHang_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox3.Location = new System.Drawing.Point(47, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(56, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phiên bản 5.26.0";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightCyan;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDangXuat.Location = new System.Drawing.Point(26, 390);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(143, 34);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.BackColor = System.Drawing.Color.LightCyan;
            this.btnDanhGia.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhGia.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDanhGia.Location = new System.Drawing.Point(26, 300);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(153, 34);
            this.btnDanhGia.TabIndex = 3;
            this.btnDanhGia.Text = "Đánh giá đơn hàng";
            this.btnDanhGia.UseVisualStyleBackColor = false;
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // btnTheoDoiDonHang
            // 
            this.btnTheoDoiDonHang.BackColor = System.Drawing.Color.LightCyan;
            this.btnTheoDoiDonHang.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnTheoDoiDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheoDoiDonHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheoDoiDonHang.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTheoDoiDonHang.Location = new System.Drawing.Point(26, 246);
            this.btnTheoDoiDonHang.Name = "btnTheoDoiDonHang";
            this.btnTheoDoiDonHang.Size = new System.Drawing.Size(153, 34);
            this.btnTheoDoiDonHang.TabIndex = 2;
            this.btnTheoDoiDonHang.Text = "Theo dõi đơn hàng";
            this.btnTheoDoiDonHang.UseVisualStyleBackColor = false;
            this.btnTheoDoiDonHang.Click += new System.EventHandler(this.btnTheoDoiDonHang_Click);
            // 
            // btnTatCaCuaHang
            // 
            this.btnTatCaCuaHang.BackColor = System.Drawing.Color.LightCyan;
            this.btnTatCaCuaHang.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnTatCaCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCaCuaHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCaCuaHang.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTatCaCuaHang.Location = new System.Drawing.Point(26, 133);
            this.btnTatCaCuaHang.Name = "btnTatCaCuaHang";
            this.btnTatCaCuaHang.Size = new System.Drawing.Size(143, 34);
            this.btnTatCaCuaHang.TabIndex = 0;
            this.btnTatCaCuaHang.Text = "Tất cả cửa hàng";
            this.btnTatCaCuaHang.UseVisualStyleBackColor = false;
            this.btnTatCaCuaHang.Click += new System.EventHandler(this.btnTatCaCuaHang_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(221, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giao hàng đến:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(217, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bạn ăn gì chưa?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(320, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtTiemKiemMonAn
            // 
            this.txtTiemKiemMonAn.Location = new System.Drawing.Point(347, 98);
            this.txtTiemKiemMonAn.Name = "txtTiemKiemMonAn";
            this.txtTiemKiemMonAn.Size = new System.Drawing.Size(291, 20);
            this.txtTiemKiemMonAn.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::GiaoDien.Properties.Resources.cá_viên;
            this.pictureBox4.Location = new System.Drawing.Point(218, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(177, 162);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GiaoDien.Properties.Resources.heeckaa;
            this.pictureBox5.Location = new System.Drawing.Point(218, 355);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(177, 188);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GiaoDien.Properties.Resources.bún_đậu;
            this.pictureBox6.Location = new System.Drawing.Point(624, 157);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(177, 162);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GiaoDien.Properties.Resources.xôi_xéo;
            this.pictureBox7.Location = new System.Drawing.Point(421, 157);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(177, 162);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::GiaoDien.Properties.Resources.gà_ủ_muối;
            this.pictureBox8.Location = new System.Drawing.Point(421, 355);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(177, 162);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::GiaoDien.Properties.Resources.mì;
            this.pictureBox9.Location = new System.Drawing.Point(624, 355);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(177, 162);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(810, -2);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 453);
            this.vScrollBar1.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Location = new System.Drawing.Point(238, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "[Nhấn chọn địa chỉ giao hàng]";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(663, 96);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(58, 20);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtTiemKiemMonAn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "KHÁCH HÀNG";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTheoDoiDonHang;
        private System.Windows.Forms.Button btnTatCaCuaHang;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTiemKiemMonAn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLichSuDonHang;
        private System.Windows.Forms.Button btnDanhGia;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThongTinChiTiet;
    }
}
