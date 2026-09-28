namespace BTCh5_Bai3
{
    partial class Form1
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
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstDanhSach = new ListBox();
            SuspendLayout();
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(10, 62);
            txtMaHS.Margin = new Padding(2, 2, 2, 2);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(102, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(144, 62);
            txtHoTen.Margin = new Padding(2, 2, 2, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(102, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(278, 62);
            txtToan.Margin = new Padding(2, 2, 2, 2);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(102, 27);
            txtToan.TabIndex = 2;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(401, 62);
            txtVan.Margin = new Padding(2, 2, 2, 2);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(102, 27);
            txtVan.TabIndex = 3;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(529, 62);
            txtAnh.Margin = new Padding(2, 2, 2, 2);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(102, 27);
            txtAnh.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.OliveDrab;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Location = new Point(10, 91);
            btnLuu.Margin = new Padding(2, 2, 2, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(102, 27);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(116, 91);
            btnXoaTrang.Margin = new Padding(2, 2, 2, 2);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(118, 27);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xoá Trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 39);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 9;
            label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 39);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 10;
            label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(529, 39);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 11;
            label5.Text = "Điểm Anh";
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(10, 123);
            lstDanhSach.Margin = new Padding(2, 2, 2, 2);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(622, 224);
            lstDanhSach.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(640, 360);
            Controls.Add(lstDanhSach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form Nhập Điểm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstDanhSach;
    }
}