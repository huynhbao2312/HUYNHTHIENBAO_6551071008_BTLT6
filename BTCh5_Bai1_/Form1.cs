using System.Text.RegularExpressions;

namespace BTCh5_Bai1_
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được trống và phải >= 3 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. SĐT
            if (!Regex.IsMatch(txtSDT.Text, @"^0\d{9}$"))
            {
                errorProvider1.SetError(txtSDT, "SĐT phải gồm 10 chữ số và bắt đầu bằng 0");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Mật khẩu
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải >= 6 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Xác nhận mật khẩu
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Xác nhận mật khẩu không khớp");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
                return;

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }
    }
}
