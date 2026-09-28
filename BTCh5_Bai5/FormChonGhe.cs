namespace BanVeXemPhim
{
    public partial class FormChonGhe : Form
    {
        // Ghế được chọn, chỉ set từ bên trong form
        public string GheChon { get; private set; }

        public FormChonGhe(string gheHienTai = "")
        {
            InitializeComponent();
            NapDanhSachGhe();

            // Chọn sẵn ghế cũ (nếu có)
            if (!string.IsNullOrEmpty(gheHienTai))
            {
                int idx = lstGhe.Items.IndexOf(gheHienTai);
                if (idx >= 0) lstGhe.SelectedIndex = idx;
            }
        }

        // Thứ tự A1-A5, B1-B5, C1-C5 (MultiColumn điền theo cột nên ta
        // đặt ColumnWidth/Size để mỗi hàng hiển thị 5 ghế như ảnh mẫu)
        private void NapDanhSachGhe()
        {
            foreach (char hang in new[] { 'A', 'B', 'C' })
                for (int so = 1; so <= 5; so++)
                    lstGhe.Items.Add($"{hang}{so}");
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
                lblGheDaChon.Text = $"Đang chọn: {lstGhe.SelectedItem}";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // không đóng dialog
            }
            GheChon = lstGhe.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormChonGhe_Load(object sender, EventArgs e)
        {

        }
    }
}
