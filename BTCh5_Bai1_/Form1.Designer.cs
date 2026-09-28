namespace BTCh5_Bai1_
{
    partial class FormDangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDangKy = new Button();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(246, 30);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 63);
            label2.Name = "label2";
            label2.Size = new Size(214, 20);
            label2.TabIndex = 1;
            label2.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 125);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ tên ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 164);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 207);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 251);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 298);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 6;
            label7.Text = "Xác nhận mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Blue;
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(185, 351);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click_1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(185, 125);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(189, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(185, 164);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(189, 27);
            txtSDT.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(185, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(185, 251);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(189, 27);
            txtMatKhau.TabIndex = 11;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(185, 298);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(189, 27);
            txtXacNhanMK.TabIndex = 12;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(280, 351);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(546, 450);
            Controls.Add(btnHuy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(btnDangKy);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangKy";
            Text = "Đăng ký tài khoản";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDangKy;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
