using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BTCh5_Bai2_
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
        }

        // 1. Kiểm tra họ tên: không để trống
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }
        }

        // 2. Kiểm tra CCCD: đúng 12 chữ số
        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^\d{12}$";
            if (!Regex.IsMatch(txtCCCD.Text.Trim(), pattern))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "Số CCCD phải đúng 12 chữ số!");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
            }
        }

        // 3. Kiểm tra ngày nhận: đúng định dạng dd/MM/yyyy và >= hôm nay
        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            bool parseOk = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            if (!parseOk)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phải theo định dạng dd/MM/yyyy!");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phòng phải lớn hơn hoặc bằng hôm nay!");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, "");
            }
        }

        // 4. Kiểm tra ngày trả: đúng định dạng dd/MM/yyyy và > ngày nhận
        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayTra;
            DateTime ngayNhan;

            bool parseNgayTra = DateTime.TryParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra
            );

            bool parseNgayNhan = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            if (!parseNgayTra)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải theo định dạng dd/MM/yyyy!");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else if (parseNgayNhan && ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải sau ngày nhận phòng!");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayTra, "");
            }
        }

        // 5. Số người lớn: nguyên từ 1 đến 4
        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4!");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
            }
        }

        // 6. Số trẻ em: nguyên từ 0 đến 3
        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3!");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
            }
        }

        // Khi field hợp lệ: chuyển nền thành xanh nhạt (Honeydew)
        private void TextBox_Validated(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (c != null)
            {
                c.BackColor = Color.Honeydew;
            }
        }

        // Sự kiện click nút Đặt phòng
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin bị lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int soDem = (ngayTra.Date - ngayNhan.Date).Days;

            string noiDung = $"Đặt phòng thành công!\n" +
                             $"Khách hàng: {txtHoTen.Text.Trim()}\n" +
                             $"Số CCCD: {txtCCCD.Text.Trim()}\n" +
                             $"Số đêm: {soDem} đêm\n" +
                             $"Số người lớn: {txtSoNguoiLon.Text.Trim()}\n" +
                             $"Số trẻ em: {txtSoTreEm.Text.Trim()}";

            MessageBox.Show(noiDung, "Thông tin đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}