namespace BTCh5_Bai4
{
    public partial class Form1 : Form
    {
        // -1: không sửa
        // >= 0: đang sửa liên hệ tại vị trí đó
        private int _indexDangSua = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // =========================
        // NÚT THÊM / LƯU
        // =========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(ten) ||
                string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên và số điện thoại.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string lienHe = ten + " - " + sdt;

            // Đang sửa
            if (_indexDangSua >= 0)
            {
                lstLienHe.Items[_indexDangSua] = lienHe;

                _indexDangSua = -1;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                // Thêm mới
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        // =========================
        // NÚT SỬA
        // =========================
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Chưa chọn liên hệ
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lưu vị trí đang sửa
            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe = lstLienHe.SelectedItem!.ToString()!;

            // Tách Tên và SĐT
            string[] thongTin = lienHe.Split(
                new string[] { " - " },
                2,
                StringSplitOptions.None
            );

            if (thongTin.Length == 2)
            {
                txtTen.Text = thongTin[0];
                txtSDT.Text = thongTin[1];
            }

            txtTen.Focus();
        }

        // =========================
        // NÚT XÓA
        // =========================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Chưa chọn liên hệ
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string lienHe = lstLienHe.SelectedItem!.ToString()!;

            string[] thongTin = lienHe.Split(
                new string[] { " - " },
                2,
                StringSplitOptions.None
            );

            string ten = thongTin[0];

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa liên hệ {ten}? " +
                "Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Người dùng chọn Yes
            if (ketQua == DialogResult.Yes)
            {
                int indexXoa = lstLienHe.SelectedIndex;

                lstLienHe.Items.RemoveAt(indexXoa);

                // Nếu đang sửa liên hệ vừa xóa
                if (_indexDangSua == indexXoa)
                {
                    _indexDangSua = -1;

                    txtTen.Clear();
                    txtSDT.Clear();
                }
                // Nếu xóa item nằm trước item đang sửa
                else if (_indexDangSua > indexXoa)
                {
                    _indexDangSua--;
                }

                MessageBox.Show(
                    "Xóa liên hệ thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // =========================
        // NÚT THOÁT
        // =========================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =========================
        // KHI ĐÓNG FORM
        // =========================
        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            // Nếu TextBox còn dữ liệu chưa lưu
            if (!string.IsNullOrWhiteSpace(txtTen.Text) ||
                !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                // Yes: thoát luôn
                if (ketQua == DialogResult.Yes)
                {
                    e.Cancel = false;
                }

                // No: xóa dữ liệu rồi thoát
                else if (ketQua == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();

                    _indexDangSua = -1;

                    e.Cancel = false;
                }

                // Cancel: không thoát
                else if (ketQua == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void lstLienHe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}