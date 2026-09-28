namespace BanVeXemPhim
{
    partial class FormChonGhe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstGhe = new ListBox();
            lblGheDaChon = new Label();
            btnXacNhan = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lstGhe
            // 
            lstGhe.ColumnWidth = 55;
            lstGhe.Font = new Font("Segoe UI", 12F);
            lstGhe.FormattingEnabled = true;
            lstGhe.Location = new Point(17, 20);
            lstGhe.Margin = new Padding(3, 4, 3, 4);
            lstGhe.MultiColumn = true;
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(331, 116);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(17, 157);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(166, 20);
            lblGheDaChon.TabIndex = 1;
            lblGheDaChon.Text = "Đang chọn: (chưa chọn)";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(137, 200);
            btnXacNhan.Margin = new Padding(3, 4, 3, 4);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(97, 40);
            btnXacNhan.TabIndex = 1;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(246, 200);
            btnBoQua.Margin = new Padding(3, 4, 3, 4);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(97, 40);
            btnBoQua.TabIndex = 2;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormChonGhe
            // 
            AcceptButton = btnXacNhan;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBoQua;
            ClientSize = new Size(366, 267);
            Controls.Add(lstGhe);
            Controls.Add(lblGheDaChon);
            Controls.Add(btnXacNhan);
            Controls.Add(btnBoQua);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChonGhe";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn ghế";
            Load += FormChonGhe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListBox lstGhe;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnBoQua;
    }
}
