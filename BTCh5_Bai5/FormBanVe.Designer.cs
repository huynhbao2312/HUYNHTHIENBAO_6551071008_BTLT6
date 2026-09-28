namespace BanVeXemPhim
{
    partial class FormBanVe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblPhim = new Label();
            cboPhim = new ComboBox();
            lblSuatChieu = new Label();
            cboSuatChieu = new ComboBox();
            lblGhe = new Label();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(23, 27);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(77, 20);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(23, 56);
            txtTenKhach.Margin = new Padding(3, 4, 3, 4);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(491, 27);
            txtTenKhach.TabIndex = 0;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(23, 107);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(45, 20);
            lblPhim.TabIndex = 1;
            lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.Location = new Point(23, 136);
            cboPhim.Margin = new Padding(3, 4, 3, 4);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(491, 28);
            cboPhim.TabIndex = 1;
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(23, 187);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(80, 20);
            lblSuatChieu.TabIndex = 2;
            lblSuatChieu.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.Location = new Point(23, 216);
            cboSuatChieu.Margin = new Padding(3, 4, 3, 4);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(491, 28);
            cboSuatChieu.TabIndex = 2;
            // 
            // lblGhe
            // 
            lblGhe.AutoSize = true;
            lblGhe.Location = new Point(23, 267);
            lblGhe.Name = "lblGhe";
            lblGhe.Size = new Size(95, 20);
            lblGhe.TabIndex = 3;
            lblGhe.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(23, 296);
            txtGheDaChon.Margin = new Padding(3, 4, 3, 4);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(491, 27);
            txtGheDaChon.TabIndex = 4;
            txtGheDaChon.TabStop = false;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(46, 373);
            btnChonGhe.Margin = new Padding(3, 4, 3, 4);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(137, 43);
            btnChonGhe.TabIndex = 3;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(206, 373);
            btnDatVe.Margin = new Padding(3, 4, 3, 4);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(137, 43);
            btnDatVe.TabIndex = 4;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(366, 373);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(137, 43);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(537, 453);
            Controls.Add(lblTenKhach);
            Controls.Add(txtTenKhach);
            Controls.Add(lblPhim);
            Controls.Add(cboPhim);
            Controls.Add(lblSuatChieu);
            Controls.Add(cboSuatChieu);
            Controls.Add(lblGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(btnChonGhe);
            Controls.Add(btnDatVe);
            Controls.Add(btnHuy);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            Load += FormBanVe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.Label lblGhe;
        private System.Windows.Forms.TextBox txtGheDaChon;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnHuy;
    }
}
