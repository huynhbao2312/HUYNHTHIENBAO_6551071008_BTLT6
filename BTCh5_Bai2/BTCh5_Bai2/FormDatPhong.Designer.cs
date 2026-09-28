namespace BTCh5_Bai2_
{
    partial class FormDatPhong
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
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 11);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 78);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Số CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 150);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày nhận phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 217);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày trả phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 284);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Số người lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 349);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Số trẻ em";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(89, 34);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(304, 27);
            txtHoTen.TabIndex = 6;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(89, 101);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(304, 27);
            txtCCCD.TabIndex = 7;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(89, 173);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(232, 27);
            txtNgayNhan.TabIndex = 8;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(89, 240);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(232, 27);
            txtNgayTra.TabIndex = 9;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(89, 307);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(94, 27);
            txtSoNguoiLon.TabIndex = 10;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(89, 372);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(94, 27);
            txtSoTreEm.TabIndex = 11;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.RoyalBlue;
            btnDatPhong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(313, 385);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(297, 53);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDatPhong";
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox txtSoTreEm;
        private TextBox txtSoNguoiLon;
        private TextBox txtNgayTra;
        private TextBox txtNgayNhan;
        private TextBox txtCCCD;
        private TextBox txtHoTen;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDatPhong;
    }
}
