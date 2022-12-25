namespace GiaoDien
{
    partial class Form9
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.chỉnhSửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíCNoolStripMenuItem_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.madoitac_label = new System.Windows.Forms.Label();
            this.tendoitac_label = new System.Windows.Forms.Label();
            this.nasothue_label = new System.Windows.Forms.Label();
            this.tenndd_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.sdt_label = new System.Windows.Forms.Label();
            this.diachi_label = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaThôngTinToolStripMenuItem,
            this.quảnLíToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(739, 31);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // chỉnhSửaThôngTinToolStripMenuItem
            // 
            this.chỉnhSửaThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chỉnhSửaThôngTinToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.chỉnhSửaThôngTinToolStripMenuItem.Name = "chỉnhSửaThôngTinToolStripMenuItem";
            this.chỉnhSửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(182, 27);
            this.chỉnhSửaThôngTinToolStripMenuItem.Text = "Chỉnh sửa thông tin";
            this.chỉnhSửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaThôngTinToolStripMenuItem_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíDToolStripMenuItem,
            this.quảnLíCNoolStripMenuItem_Click,
            this.quảnLíThựcĐơnToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.quảnLíToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // quảnLíDToolStripMenuItem
            // 
            this.quảnLíDToolStripMenuItem.Name = "quảnLíDToolStripMenuItem";
            this.quảnLíDToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.quảnLíDToolStripMenuItem.Text = "Quản lí doanh thu";
            this.quảnLíDToolStripMenuItem.Click += new System.EventHandler(this.quảnLíDToolStripMenuItem_Click);
            // 
            // quảnLíCNoolStripMenuItem_Click
            // 
            this.quảnLíCNoolStripMenuItem_Click.Name = "quảnLíCNoolStripMenuItem_Click";
            this.quảnLíCNoolStripMenuItem_Click.Size = new System.Drawing.Size(238, 28);
            this.quảnLíCNoolStripMenuItem_Click.Text = "Quản lí chi nhánh";
            this.quảnLíCNoolStripMenuItem_Click.Click += new System.EventHandler(this.quảnLíCNoolStripMenuItem_Click_Click);
            // 
            // quảnLíThựcĐơnToolStripMenuItem
            // 
            this.quảnLíThựcĐơnToolStripMenuItem.Name = "quảnLíThựcĐơnToolStripMenuItem";
            this.quảnLíThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.quảnLíThựcĐơnToolStripMenuItem.Text = "Quản lí thực đơn";
            this.quảnLíThựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíThựcĐơnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(717, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 404);
            this.vScrollBar1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(253, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.avatardefault_to;
            this.pictureBox1.Location = new System.Drawing.Point(623, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.diachi_label);
            this.panel1.Controls.Add(this.sdt_label);
            this.panel1.Controls.Add(this.email_label);
            this.panel1.Controls.Add(this.tenndd_label);
            this.panel1.Controls.Add(this.nasothue_label);
            this.panel1.Controls.Add(this.tendoitac_label);
            this.panel1.Controls.Add(this.madoitac_label);
            this.panel1.Location = new System.Drawing.Point(43, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 278);
            this.panel1.TabIndex = 12;
            // 
            // madoitac_label
            // 
            this.madoitac_label.AutoSize = true;
            this.madoitac_label.Location = new System.Drawing.Point(18, 18);
            this.madoitac_label.Name = "madoitac_label";
            this.madoitac_label.Size = new System.Drawing.Size(81, 17);
            this.madoitac_label.TabIndex = 0;
            this.madoitac_label.Text = "Mã đối tác: ";
            // 
            // tendoitac_label
            // 
            this.tendoitac_label.AutoSize = true;
            this.tendoitac_label.Location = new System.Drawing.Point(18, 60);
            this.tendoitac_label.Name = "tendoitac_label";
            this.tendoitac_label.Size = new System.Drawing.Size(87, 17);
            this.tendoitac_label.TabIndex = 1;
            this.tendoitac_label.Text = "Tên đối tác: ";
            // 
            // nasothue_label
            // 
            this.nasothue_label.AutoSize = true;
            this.nasothue_label.Location = new System.Drawing.Point(19, 101);
            this.nasothue_label.Name = "nasothue_label";
            this.nasothue_label.Size = new System.Drawing.Size(82, 17);
            this.nasothue_label.TabIndex = 2;
            this.nasothue_label.Text = "Mã số thuế:";
            // 
            // tenndd_label
            // 
            this.tenndd_label.AutoSize = true;
            this.tenndd_label.Location = new System.Drawing.Point(18, 140);
            this.tenndd_label.Name = "tenndd_label";
            this.tenndd_label.Size = new System.Drawing.Size(134, 17);
            this.tenndd_label.TabIndex = 3;
            this.tenndd_label.Text = "Tên người đại diện: ";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(18, 175);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(50, 17);
            this.email_label.TabIndex = 4;
            this.email_label.Text = "Email: ";
            // 
            // sdt_label
            // 
            this.sdt_label.AutoSize = true;
            this.sdt_label.Location = new System.Drawing.Point(18, 213);
            this.sdt_label.Name = "sdt_label";
            this.sdt_label.Size = new System.Drawing.Size(99, 17);
            this.sdt_label.TabIndex = 5;
            this.sdt_label.Text = "Số điện thoại: ";
            // 
            // diachi_label
            // 
            this.diachi_label.AutoSize = true;
            this.diachi_label.Location = new System.Drawing.Point(18, 246);
            this.diachi_label.Name = "diachi_label";
            this.diachi_label.Size = new System.Drawing.Size(59, 17);
            this.diachi_label.TabIndex = 6;
            this.diachi_label.Text = "Địa chỉ: ";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 436);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form9";
            this.Text = "ĐỐI TÁC";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíCNoolStripMenuItem_Click;
        private System.Windows.Forms.ToolStripMenuItem quảnLíThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label diachi_label;
        private System.Windows.Forms.Label sdt_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label tenndd_label;
        private System.Windows.Forms.Label nasothue_label;
        private System.Windows.Forms.Label tendoitac_label;
        private System.Windows.Forms.Label madoitac_label;
    }
}