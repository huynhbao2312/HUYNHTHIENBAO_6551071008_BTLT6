namespace BTCh5_Bai6
{
    partial class FormGhiChu
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
            components = new System.ComponentModel.Container();
            lbTieude = new Label();
            lbNoiDung = new Label();
            lbPriority = new Label();
            btnLuuGhiChu = new Button();
            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();
            cboMucDoUuTien = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbTieude
            // 
            lbTieude.AutoSize = true;
            lbTieude.Location = new Point(12, 9);
            lbTieude.Name = "lbTieude";
            lbTieude.Size = new Size(58, 20);
            lbTieude.TabIndex = 0;
            lbTieude.Text = "Tiêu đề";
            lbTieude.MouseDoubleClick += lbTieude_MouseDoubleClick;
            // 
            // lbNoiDung
            // 
            lbNoiDung.AutoSize = true;
            lbNoiDung.Location = new Point(12, 74);
            lbNoiDung.Name = "lbNoiDung";
            lbNoiDung.Size = new Size(71, 20);
            lbNoiDung.TabIndex = 1;
            lbNoiDung.Text = "Nội dung";
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(12, 356);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(59, 20);
            lbPriority.TabIndex = 2;
            lbPriority.Text = "Priority:";
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.FlatStyle = FlatStyle.Popup;
            btnLuuGhiChu.Location = new Point(676, 389);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(94, 29);
            btnLuuGhiChu.TabIndex = 3;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(94, 9);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(606, 27);
            txtTieuDe.TabIndex = 4;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(12, 106);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(776, 247);
            txtNoiDung.TabIndex = 5;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Location = new Point(12, 389);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(168, 28);
            cboMucDoUuTien.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(lbPriority);
            Controls.Add(lbNoiDung);
            Controls.Add(lbTieude);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "Ghi chú mới";
            FormClosing += FormGhiChu_FormClosing;
            Load += FormGhiChu_Load;
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Button btnLuuGhiChu;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cboMucDoUuTien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}