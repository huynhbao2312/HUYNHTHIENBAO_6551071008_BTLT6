using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BTCh5_Bai6
{
    public partial class FormGhiChu : Form
    {
        private Color defaultButtonColor;

        public FormGhiChu()
        {
            InitializeComponent();
        }

        private void FormGhiChu_Load(object sender, EventArgs e)
        {
            cboMucDoUuTien.Items.AddRange(new string[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.SelectedIndex = 0;

            defaultButtonColor = btnLuuGhiChu.BackColor;
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnLuuGhiChu.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (txtNoiDung.Text.Length >= 500)
            {
                e.Handled = true;
            }
        }

        private void lbTieude_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = defaultButtonColor;
        }

        private void FormGhiChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNoiDung.Text) || !string.IsNullOrEmpty(txtTieuDe.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Nội dung đã được thay đổi. Bạn có chắc chắn muốn đóng không?",
                    "Xác nhận đóng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string strTieuDe = txtTieuDe.Text.Trim();

            if (string.IsNullOrEmpty(strTieuDe))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (strTieuDe.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được vượt quá 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, "");
            txtTieuDe.BackColor = Color.White;
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.Text = txtTieuDe.Text.Trim();
                MessageBox.Show("Đã lưu ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}