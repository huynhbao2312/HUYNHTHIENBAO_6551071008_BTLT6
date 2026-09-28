using System;
using System.Windows.Forms;

namespace BTCh5_Bai3
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();

            txtMaHS.TabIndex = 0;
            txtHoTen.TabIndex = 1;
            txtToan.TabIndex = 2;
            txtVan.TabIndex = 3;
            txtAnh.TabIndex = 4;
            btnLuu.TabIndex = 5;
            btnXoaTrang.TabIndex = 6;

            DangKyEnterChuyenField();

            txtToan.Enter += txtDiem_Enter;
            txtVan.Enter += txtDiem_Enter;
            txtAnh.Enter += txtDiem_Enter;
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox txt)
                {
                    txt.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }

        private void txtDiem_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            decimal toan;
            decimal van;
            decimal anh;

            bool hopLe = true;

            if (!decimal.TryParse(txtToan.Text, out toan) ||
                toan < 0 || toan > 10)
            {
                errorProvider.SetError(
                    txtToan,
                    "Diem Toan phai tu 0.0 den 10.0"
                );

                hopLe = false;
            }

            if (!decimal.TryParse(txtVan.Text, out van) ||
                van < 0 || van > 10)
            {
                errorProvider.SetError(
                    txtVan,
                    "Diem Van phai tu 0.0 den 10.0"
                );

                hopLe = false;
            }

            if (!decimal.TryParse(txtAnh.Text, out anh) ||
                anh < 0 || anh > 10)
            {
                errorProvider.SetError(
                    txtAnh,
                    "Diem Anh phai tu 0.0 den 10.0"
                );

                hopLe = false;
            }

            if (!hopLe)
                return;

            string dong =
                txtMaHS.Text + " | " +
                txtHoTen.Text + " | " +
                "Toan: " + toan + " | " +
                "Van: " + van + " | " +
                "Anh: " + anh;

            lstDanhSach.Items.Add(dong);

            XoaTrang();

            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
            txtMaHS.Focus();
        }

        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider.Clear();
        }
    }
}