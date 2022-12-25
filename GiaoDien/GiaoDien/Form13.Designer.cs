namespace GiaoDien
{
    partial class Form13
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
            this.CN_cbb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.XemThucDon_btn = new System.Windows.Forms.Button();
            this.DSTD_Grid = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.DSTD_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // CN_cbb
            // 
            this.CN_cbb.FormattingEnabled = true;
            this.CN_cbb.Items.AddRange(new object[] {
            "Chi nhánh 1",
            "Chi nhánh 2",
            "Chi nhánh 3"});
            this.CN_cbb.Location = new System.Drawing.Point(187, 37);
            this.CN_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CN_cbb.Name = "CN_cbb";
            this.CN_cbb.Size = new System.Drawing.Size(132, 24);
            this.CN_cbb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn chi nhánh";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tùy chỉnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tủy chỉnh thực đơn";
            // 
            // XemThucDon_btn
            // 
            this.XemThucDon_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemThucDon_btn.Location = new System.Drawing.Point(341, 33);
            this.XemThucDon_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XemThucDon_btn.Name = "XemThucDon_btn";
            this.XemThucDon_btn.Size = new System.Drawing.Size(171, 30);
            this.XemThucDon_btn.TabIndex = 6;
            this.XemThucDon_btn.Text = "Xem thực đơn";
            this.XemThucDon_btn.UseVisualStyleBackColor = true;
            this.XemThucDon_btn.Click += new System.EventHandler(this.XemThucDon_btn_Click);
            // 
            // DSTD_Grid
            // 
            this.DSTD_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSTD_Grid.Location = new System.Drawing.Point(17, 144);
            this.DSTD_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.DSTD_Grid.Name = "DSTD_Grid";
            this.DSTD_Grid.RowHeadersWidth = 51;
            this.DSTD_Grid.Size = new System.Drawing.Size(964, 379);
            this.DSTD_Grid.TabIndex = 7;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1009, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 645);
            this.vScrollBar1.TabIndex = 8;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1032, 538);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.DSTD_Grid);
            this.Controls.Add(this.XemThucDon_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CN_cbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form13";
            this.Text = "QUẢN LÍ THỰC ĐƠN";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSTD_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CN_cbb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button XemThucDon_btn;
        private System.Windows.Forms.DataGridView DSTD_Grid;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}