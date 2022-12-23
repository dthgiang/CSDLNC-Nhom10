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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cbbDSDonHang = new System.Windows.Forms.ComboBox();
            this.btnChonDonHang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsdonhangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsdonhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdonhangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdonhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(671, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 367);
            this.vScrollBar1.TabIndex = 3;
            // 
            // cbbDSDonHang
            // 
            this.cbbDSDonHang.FormattingEnabled = true;
            this.cbbDSDonHang.Location = new System.Drawing.Point(25, 132);
            this.cbbDSDonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDSDonHang.Name = "cbbDSDonHang";
            this.cbbDSDonHang.Size = new System.Drawing.Size(501, 21);
            this.cbbDSDonHang.TabIndex = 5;
            // 
            // btnChonDonHang
            // 
            this.btnChonDonHang.Location = new System.Drawing.Point(541, 129);
            this.btnChonDonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChonDonHang.Name = "btnChonDonHang";
            this.btnChonDonHang.Size = new System.Drawing.Size(117, 24);
            this.btnChonDonHang.TabIndex = 6;
            this.btnChonDonHang.Text = "CHỌN ĐƠN HÀNG";
            this.btnChonDonHang.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dsdonhangBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(25, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(633, 154);
            this.dataGridView1.TabIndex = 7;
            // 
            // dsdonhangBindingSource1
            // 
            this.dsdonhangBindingSource1.DataMember = "dsdonhang";
            // 
            // dsdonhangBindingSource
            // 
            this.dsdonhangBindingSource.DataMember = "dsdonhang";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(304, 345);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 37);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "LỊCH SỬ ĐƠN HÀNG";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChonDonHang);
            this.Controls.Add(this.cbbDSDonHang);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form8";
            this.Text = "DANH SÁCH ĐƠN HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdonhangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdonhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private VScrollBar vScrollBar1;
        private ComboBox cbbDSDonHang;
        private Button btnChonDonHang;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iddonhangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhThucThanhToanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phiVanChuyenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongDonHangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinhTrangDonHangDataGridViewTextBoxColumn;
        private BindingSource dsdonhangBindingSource;
       
        private DataGridViewButtonColumn chọn;
        private Button btnThoat;
        private BindingSource dsdonhangBindingSource1;
        
        private Button button1;
    }
}