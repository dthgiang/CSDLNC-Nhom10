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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDanhGiaDonHang = new System.Windows.Forms.Button();
            this.btnTheoDoiDonHang = new System.Windows.Forms.Button();
            this.btnLichSuDonHang = new System.Windows.Forms.Button();
            this.btnTatCaCuaHang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.txtTiemKiemMonAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnThongTinChiTiet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.btnThongTinChiTiet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnDanhGiaDonHang);
            this.panel1.Controls.Add(this.btnTheoDoiDonHang);
            this.panel1.Controls.Add(this.btnLichSuDonHang);
            this.panel1.Controls.Add(this.btnTatCaCuaHang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 391);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(45, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phiên bản 5.26.0";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnDangXuat.Location = new System.Drawing.Point(43, 333);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(96, 29);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnDanhGiaDonHang
            // 
            this.btnDanhGiaDonHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDanhGiaDonHang.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnDanhGiaDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhGiaDonHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDanhGiaDonHang.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnDanhGiaDonHang.Location = new System.Drawing.Point(20, 248);
            this.btnDanhGiaDonHang.Name = "btnDanhGiaDonHang";
            this.btnDanhGiaDonHang.Size = new System.Drawing.Size(151, 37);
            this.btnDanhGiaDonHang.TabIndex = 8;
            this.btnDanhGiaDonHang.Text = "Đánh giá đơn hàng";
            this.btnDanhGiaDonHang.UseVisualStyleBackColor = true;
            // 
            // btnTheoDoiDonHang
            // 
            this.btnTheoDoiDonHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTheoDoiDonHang.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnTheoDoiDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheoDoiDonHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTheoDoiDonHang.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnTheoDoiDonHang.Location = new System.Drawing.Point(17, 204);
            this.btnTheoDoiDonHang.Name = "btnTheoDoiDonHang";
            this.btnTheoDoiDonHang.Size = new System.Drawing.Size(154, 38);
            this.btnTheoDoiDonHang.TabIndex = 7;
            this.btnTheoDoiDonHang.Text = "Theo dõi đơn hàng";
            this.btnTheoDoiDonHang.UseVisualStyleBackColor = true;
            // 
            // btnLichSuDonHang
            // 
            this.btnLichSuDonHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLichSuDonHang.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnLichSuDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuDonHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLichSuDonHang.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnLichSuDonHang.Location = new System.Drawing.Point(3, 160);
            this.btnLichSuDonHang.Name = "btnLichSuDonHang";
            this.btnLichSuDonHang.Size = new System.Drawing.Size(174, 38);
            this.btnLichSuDonHang.TabIndex = 6;
            this.btnLichSuDonHang.Text = "Lịch sử đơn hàng";
            this.btnLichSuDonHang.UseVisualStyleBackColor = true;
            // 
            // btnTatCaCuaHang
            // 
            this.btnTatCaCuaHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTatCaCuaHang.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnTatCaCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCaCuaHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTatCaCuaHang.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnTatCaCuaHang.Location = new System.Drawing.Point(29, 123);
            this.btnTatCaCuaHang.Name = "btnTatCaCuaHang";
            this.btnTatCaCuaHang.Size = new System.Drawing.Size(131, 31);
            this.btnTatCaCuaHang.TabIndex = 1;
            this.btnTatCaCuaHang.Text = "Tất cả cửa hàng";
            this.btnTatCaCuaHang.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox1.Location = new System.Drawing.Point(51, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(689, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 391);
            this.vScrollBar1.TabIndex = 5;
            // 
            // txtTiemKiemMonAn
            // 
            this.txtTiemKiemMonAn.AllowDrop = true;
            this.txtTiemKiemMonAn.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTiemKiemMonAn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTiemKiemMonAn.ForeColor = System.Drawing.Color.DimGray;
            this.txtTiemKiemMonAn.Location = new System.Drawing.Point(365, 72);
            this.txtTiemKiemMonAn.Name = "txtTiemKiemMonAn";
            this.txtTiemKiemMonAn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTiemKiemMonAn.Size = new System.Drawing.Size(286, 25);
            this.txtTiemKiemMonAn.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(216, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bạn ăn gì chưa?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(218, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giao hàng đến:";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(246, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(286, 22);
            this.textBox2.TabIndex = 20;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::GiaoDien.Properties.Resources.bún_đậu;
            this.pictureBox9.Location = new System.Drawing.Point(538, 288);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(141, 146);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::GiaoDien.Properties.Resources.heeckaa;
            this.pictureBox8.Location = new System.Drawing.Point(374, 288);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(141, 146);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GiaoDien.Properties.Resources.mì;
            this.pictureBox7.Location = new System.Drawing.Point(374, 121);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(141, 146);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GiaoDien.Properties.Resources.cá_viên;
            this.pictureBox6.Location = new System.Drawing.Point(538, 121);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(141, 146);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GiaoDien.Properties.Resources.gà_ủ_muối;
            this.pictureBox5.Location = new System.Drawing.Point(211, 288);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(141, 146);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GiaoDien.Properties.Resources.xôi_xéo;
            this.pictureBox4.Location = new System.Drawing.Point(211, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 146);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GiaoDien.Properties.Resources.search_icon;
            this.pictureBox2.Location = new System.Drawing.Point(341, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GiaoDien.Properties.Resources.location_icon;
            this.pictureBox3.Location = new System.Drawing.Point(215, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // btnThongTinChiTiet
            // 
            this.btnThongTinChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThongTinChiTiet.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btnThongTinChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinChiTiet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThongTinChiTiet.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnThongTinChiTiet.Location = new System.Drawing.Point(20, 291);
            this.btnThongTinChiTiet.Name = "btnThongTinChiTiet";
            this.btnThongTinChiTiet.Size = new System.Drawing.Size(151, 37);
            this.btnThongTinChiTiet.TabIndex = 11;
            this.btnThongTinChiTiet.Text = "Thông tin chi tiết";
            this.btnThongTinChiTiet.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(706, 390);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiemKiemMonAn);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form2";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private VScrollBar vScrollBar1;
        private TextBox txtTiemKiemMonAn;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnTatCaCuaHang;
        private Button btnDangXuat;
        private Button btnDanhGiaDonHang;
        private Button btnTheoDoiDonHang;
        private Button btnLichSuDonHang;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private TextBox textBox2;
        private Button btnThongTinChiTiet;
    }
}