namespace BTCh5_Bai4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            lstLienHe = new ListBox();
            lblTen = new Label();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            lblSDT = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblTieuDe = new Label();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(446, 42);
            lstLienHe.Margin = new Padding(2, 2, 2, 2);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(498, 384);
            lstLienHe.TabIndex = 0;
            lstLienHe.SelectedIndexChanged += lstLienHe_SelectedIndexChanged;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(10, 58);
            lblTen.Margin = new Padding(2, 0, 2, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(84, 20);
            lblTen.TabIndex = 1;
            lblTen.Text = "HỌ VÀ TÊN";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(153, 58);
            txtTen.Margin = new Padding(2, 2, 2, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(195, 27);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += txtTen_TextChanged_1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(153, 112);
            txtSDT.Margin = new Padding(2, 2, 2, 2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(195, 27);
            txtSDT.TabIndex = 3;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(10, 112);
            lblSDT.Margin = new Padding(2, 0, 2, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(114, 20);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "SỐ ĐIỆN THOẠI";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(228, 179);
            btnThem.Margin = new Padding(2, 2, 2, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 27);
            btnThem.TabIndex = 5;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(228, 234);
            btnSua.Margin = new Padding(2, 2, 2, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(117, 27);
            btnSua.TabIndex = 6;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(228, 292);
            btnXoa.Margin = new Padding(2, 2, 2, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(117, 27);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(228, 342);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 27);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDe.Location = new Point(153, 12);
            lblTieuDe.Margin = new Padding(2, 0, 2, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(197, 28);
            lblTieuDe.TabIndex = 9;
            lblTieuDe.Text = "QUẢN LÝ DANH BẠ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(946, 443);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblSDT);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(lstLienHe);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh bạ";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;

        private Label lblTen;
        private TextBox txtTen;

        private Label lblSDT;
        private TextBox txtSDT;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;

        private Label lblTieuDe;
    }
}