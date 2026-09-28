namespace BTCh5_Bai6
{
    partial class FormChinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuTep = new ToolStripMenuItem();
            menuMoGhiChuMoi = new ToolStripMenuItem();
            menuSapXep = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            menuCuaSo = new ToolStripMenuItem();
            menuXepTang = new ToolStripMenuItem();
            menuXepNgang = new ToolStripMenuItem();
            menuXepDoc = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSoGhiChu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuTep, menuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuTep
            // 
            menuTep.DropDownItems.AddRange(new ToolStripItem[] { menuMoGhiChuMoi, menuSapXep, menuThoat });
            menuTep.Name = "menuTep";
            menuTep.Size = new Size(48, 24);
            menuTep.Text = "Tệp";
            // 
            // menuMoGhiChuMoi
            // 
            menuMoGhiChuMoi.Name = "menuMoGhiChuMoi";
            menuMoGhiChuMoi.Size = new Size(196, 26);
            menuMoGhiChuMoi.Text = "Mở ghi chú mới";
            menuMoGhiChuMoi.Click += menuMoGhiChuMoi_Click;
            // 
            // menuSapXep
            // 
            menuSapXep.Name = "menuSapXep";
            menuSapXep.Size = new Size(196, 26);
            menuSapXep.Text = "Sắp xếp cửa sổ";
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(196, 26);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // menuCuaSo
            // 
            menuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { menuXepTang, menuXepNgang, menuXepDoc });
            menuCuaSo.Name = "menuCuaSo";
            menuCuaSo.Size = new Size(68, 24);
            menuCuaSo.Text = "Cửa sổ";
            // 
            // menuXepTang
            // 
            menuXepTang.Name = "menuXepTang";
            menuXepTang.Size = new Size(164, 26);
            menuXepTang.Text = "Xếp tầng";
            menuXepTang.Click += menuXepTang_Click;
            // 
            // menuXepNgang
            // 
            menuXepNgang.Name = "menuXepNgang";
            menuXepNgang.Size = new Size(164, 26);
            menuXepNgang.Text = "Xếp ngang";
            menuXepNgang.Click += menuXepNgang_Click;
            // 
            // menuXepDoc
            // 
            menuXepDoc.Name = "menuXepDoc";
            menuXepDoc.Size = new Size(164, 26);
            menuXepDoc.Text = "Xếp dọc";
            menuXepDoc.Click += menuXepDoc_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoGhiChu });
            statusStrip1.Location = new Point(0, 526);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSoGhiChu
            // 
            lblSoGhiChu.Name = "lblSoGhiChu";
            lblSoGhiChu.Size = new Size(157, 20);
            lblSoGhiChu.Text = "Số ghi chú đang mở: 0";
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 552);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Ghi chú (MDI)";
            Load += FormChinh_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTep;
        private System.Windows.Forms.ToolStripMenuItem menuMoGhiChuMoi;
        private System.Windows.Forms.ToolStripMenuItem menuSapXep;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem menuXepTang;
        private System.Windows.Forms.ToolStripMenuItem menuXepNgang;
        private System.Windows.Forms.ToolStripMenuItem menuXepDoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoGhiChu;
    }
}