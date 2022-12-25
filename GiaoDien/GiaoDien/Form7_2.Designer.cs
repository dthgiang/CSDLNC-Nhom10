using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form7_2
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dONHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTroVe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1071, 2);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 748);
            this.vScrollBar1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(128, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(808, 362);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(462, 596);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(147, 42);
            this.btnTroVe.TabIndex = 8;
            this.btnTroVe.Text = "TRỞ VỀ";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox1.Location = new System.Drawing.Point(453, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Form7_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1104, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vScrollBar1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form7_2";
            this.Text = "LỊCH SỬ ĐƠN ĐẶT HÀNG";
            this.Load += new System.EventHandler(this.Form7_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private VScrollBar vScrollBar1;
        private DataGridView dataGridView1;

        private BindingSource dONHANGBindingSource;

        private DataGridViewTextBoxColumn iddonhangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhThucThanhToanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phiVanChuyenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongDonHangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinhTrangDonHangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private Button btnTroVe;
        private PictureBox pictureBox1;
        private DataGridViewButtonColumn Column1;
    }
}