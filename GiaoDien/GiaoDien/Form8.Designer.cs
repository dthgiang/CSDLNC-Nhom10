using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form8
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cbbDSDonHang = new System.Windows.Forms.ComboBox();
            this.btnChonDonHang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iddonhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phiVanChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDonHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox1.Location = new System.Drawing.Point(436, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1006, 37);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 565);
            this.vScrollBar1.TabIndex = 3;
            // 
            // cbbDSDonHang
            // 
            this.cbbDSDonHang.FormattingEnabled = true;
            this.cbbDSDonHang.Location = new System.Drawing.Point(73, 113);
            this.cbbDSDonHang.Name = "cbbDSDonHang";
            this.cbbDSDonHang.Size = new System.Drawing.Size(750, 28);
            this.cbbDSDonHang.TabIndex = 5;
            // 
            // btnChonDonHang
            // 
            this.btnChonDonHang.Location = new System.Drawing.Point(841, 108);
            this.btnChonDonHang.Name = "btnChonDonHang";
            this.btnChonDonHang.Size = new System.Drawing.Size(176, 37);
            this.btnChonDonHang.TabIndex = 6;
            this.btnChonDonHang.Text = "CHỌN ĐƠN HÀNG";
            this.btnChonDonHang.UseVisualStyleBackColor = true;
            this.btnChonDonHang.Click += new System.EventHandler(this.btnChonDonHang_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(26, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(977, 324);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(630, 528);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 42);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "LỊCH SỬ ĐƠN HÀNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iddonhangDataGridViewTextBoxColumn
            // 
            this.iddonhangDataGridViewTextBoxColumn.DataPropertyName = "id_donhang";
            this.iddonhangDataGridViewTextBoxColumn.HeaderText = "id_donhang";
            this.iddonhangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iddonhangDataGridViewTextBoxColumn.Name = "iddonhangDataGridViewTextBoxColumn";
            this.iddonhangDataGridViewTextBoxColumn.Width = 150;
            // 
            // phiVanChuyenDataGridViewTextBoxColumn
            // 
            this.phiVanChuyenDataGridViewTextBoxColumn.DataPropertyName = "Phi van chuyen";
            this.phiVanChuyenDataGridViewTextBoxColumn.HeaderText = "Phi van chuyen";
            this.phiVanChuyenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phiVanChuyenDataGridViewTextBoxColumn.Name = "phiVanChuyenDataGridViewTextBoxColumn";
            this.phiVanChuyenDataGridViewTextBoxColumn.Width = 150;
            // 
            // tongDonHangDataGridViewTextBoxColumn
            // 
            this.tongDonHangDataGridViewTextBoxColumn.DataPropertyName = "Tong don hang";
            this.tongDonHangDataGridViewTextBoxColumn.HeaderText = "Tong don hang";
            this.tongDonHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tongDonHangDataGridViewTextBoxColumn.Name = "tongDonHangDataGridViewTextBoxColumn";
            this.tongDonHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // tinhTrangDonHangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDonHangDataGridViewTextBoxColumn.DataPropertyName = "Tinh trang don hang";
            this.tinhTrangDonHangDataGridViewTextBoxColumn.HeaderText = "Tinh trang don hang";
            this.tinhTrangDonHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tinhTrangDonHangDataGridViewTextBoxColumn.Name = "tinhTrangDonHangDataGridViewTextBoxColumn";
            this.tinhTrangDonHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_donhang";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1043, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChonDonHang);
            this.Controls.Add(this.cbbDSDonHang);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8";
            this.Text = "DANH SÁCH ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private VScrollBar vScrollBar1;
        private ComboBox cbbDSDonHang;
        private Button btnChonDonHang;
        private DataGridView dataGridView1;

        private Button btnThoat;

        private Button button1;
        private DataGridViewTextBoxColumn iddonhangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phiVanChuyenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongDonHangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinhTrangDonHangDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Column2;
    }
}