using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form3
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTimKiemCuaHang = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.cbbTimKiemCuaHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(154, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox2.Location = new System.Drawing.Point(295, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnTimKiemCuaHang
            // 
            this.btnTimKiemCuaHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTimKiemCuaHang.Location = new System.Drawing.Point(261, 143);
            this.btnTimKiemCuaHang.Name = "btnTimKiemCuaHang";
            this.btnTimKiemCuaHang.Size = new System.Drawing.Size(149, 29);
            this.btnTimKiemCuaHang.TabIndex = 3;
            this.btnTimKiemCuaHang.Text = "Tìm kiếm cửa hàng";
            this.btnTimKiemCuaHang.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(672, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 346);
            this.vScrollBar1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTroVe.Location = new System.Drawing.Point(282, 352);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(100, 29);
            this.btnTroVe.TabIndex = 6;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // cbbTimKiemCuaHang
            // 
            this.cbbTimKiemCuaHang.FormattingEnabled = true;
            this.cbbTimKiemCuaHang.Location = new System.Drawing.Point(180, 109);
            this.cbbTimKiemCuaHang.Name = "cbbTimKiemCuaHang";
            this.cbbTimKiemCuaHang.Size = new System.Drawing.Size(347, 21);
            this.cbbTimKiemCuaHang.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(689, 392);
            this.Controls.Add(this.cbbTimKiemCuaHang);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnTimKiemCuaHang);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "CỬA HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnTimKiemCuaHang;
        private VScrollBar vScrollBar1;
        private DataGridView dataGridView1;
        private Button btnTroVe;
        private ComboBox cbbTimKiemCuaHang;
    }
}