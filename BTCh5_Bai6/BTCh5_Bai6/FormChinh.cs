using System;
using System.Windows.Forms;

namespace BTCh5_Bai6
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void menuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();
            frm.MdiParent = this;
            frm.FormClosed += FormGhiChu_FormClosed;
            frm.Show();
            CapNhatSoLuongGhiChu();
        }

        private void FormGhiChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatSoLuongGhiChu();
        }

        public void CapNhatSoLuongGhiChu()
        {
            lblSoGhiChu.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
        }

        private void menuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }
    }
}