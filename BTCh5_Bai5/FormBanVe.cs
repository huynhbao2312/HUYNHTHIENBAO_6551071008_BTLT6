namespace BanVeXemPhim
{
    public partial class FormBanVe : Form
    {
        private const int GiaVe = 75000;

        public FormBanVe()
        {
            InitializeComponent();
        }

        private void FormBanVe_Load(object sender, EventArgs e)
        {
            cboPhim.Items.AddRange(new object[]
            {
                "Chiến binh cuối cùng",
                "Hành tinh bí ẩn",
                "Tình yêu và thời gian",
                "Đêm không ngủ"
            });
            cboSuatChieu.Items.AddRange(new object[]
            {
                "09:00", "13:00", "16:00", "19:00", "21:30"
            });
            cboPhim.SelectedIndex = 0;
            cboSuatChieu.SelectedIndex = 0;
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            // Mở dialog dạng modal (blocking), truyền ghế hiện tại để tô sáng sẵn
            using (var dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }
            if (cboPhim.SelectedItem == null || cboSuatChieu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và suất chiếu!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng chọn ghế!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonGhe.Focus();
                return;
            }

            string noiDung =
                $"Khách hàng: {txtTenKhach.Text.Trim()}\n" +
                $"Phim: {cboPhim.SelectedItem}\n" +
                $"Suất chiếu: {cboSuatChieu.SelectedItem}\n" +
                $"Ghế: {txtGheDaChon.Text}\n" +
                $"Giá vé: {GiaVe:N0}đ/vé";

            MessageBox.Show(noiDung, "Xác nhận đặt vé",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtGheDaChon.Clear();
            cboPhim.SelectedIndex = 0;
            cboSuatChieu.SelectedIndex = 0;
            txtTenKhach.Focus();
        }
    }
}
