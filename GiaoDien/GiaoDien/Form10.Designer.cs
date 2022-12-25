using System.Windows.Forms;

namespace GiaoDien
{
    partial class Form10
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
            this.label1 = new System.Windows.Forms.Label();
            this.hoten_txtBox = new System.Windows.Forms.TextBox();
            this.acp_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email_txtBox = new System.Windows.Forms.TextBox();
            this.diachi_txtBox = new System.Windows.Forms.TextBox();
            this.sdt_txtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.pictureBox1.Location = new System.Drawing.Point(387, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(157, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên:";
            // 
            // hoten_txtBox
            // 
            this.hoten_txtBox.Location = new System.Drawing.Point(355, 174);
            this.hoten_txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.hoten_txtBox.Name = "hoten_txtBox";
            this.hoten_txtBox.Size = new System.Drawing.Size(317, 22);
            this.hoten_txtBox.TabIndex = 2;
            // 
            // acp_btn
            // 
            this.acp_btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.acp_btn.Location = new System.Drawing.Point(355, 347);
            this.acp_btn.Margin = new System.Windows.Forms.Padding(4);
            this.acp_btn.Name = "acp_btn";
            this.acp_btn.Size = new System.Drawing.Size(96, 36);
            this.acp_btn.TabIndex = 3;
            this.acp_btn.Text = "Đồng ý";
            this.acp_btn.UseVisualStyleBackColor = true;
            this.acp_btn.Click += new System.EventHandler(this.acp_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(156, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(157, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(157, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // email_txtBox
            // 
            this.email_txtBox.Location = new System.Drawing.Point(355, 213);
            this.email_txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.Size = new System.Drawing.Size(317, 22);
            this.email_txtBox.TabIndex = 8;
            // 
            // diachi_txtBox
            // 
            this.diachi_txtBox.Location = new System.Drawing.Point(355, 250);
            this.diachi_txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.diachi_txtBox.Name = "diachi_txtBox";
            this.diachi_txtBox.Size = new System.Drawing.Size(317, 22);
            this.diachi_txtBox.TabIndex = 9;
            // 
            // sdt_txtBox
            // 
            this.sdt_txtBox.Location = new System.Drawing.Point(355, 288);
            this.sdt_txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.sdt_txtBox.Name = "sdt_txtBox";
            this.sdt_txtBox.Size = new System.Drawing.Size(317, 22);
            this.sdt_txtBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.Location = new System.Drawing.Point(471, 347);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sdt_txtBox);
            this.Controls.Add(this.diachi_txtBox);
            this.Controls.Add(this.email_txtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acp_btn);
            this.Controls.Add(this.hoten_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form10";
            this.Text = "CHỈNH SỬA THÔNG TIN";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox hoten_txtBox;
        private Button acp_btn;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox email_txtBox;
        private TextBox diachi_txtBox;
        private TextBox sdt_txtBox;
        private Button button2;
    }
}