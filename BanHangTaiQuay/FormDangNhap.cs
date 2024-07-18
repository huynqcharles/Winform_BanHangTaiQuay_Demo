using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangTaiQuay
{
    public partial class FormDangNhap : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var nhanVien = nhanVienBLL.DangNhap(username, password);
            this.Hide();
            FormBanHang formBanHang = new FormBanHang(nhanVien);
            formBanHang.FormClosed += FormBanHang_FormClosed;
            formBanHang.Show();
        }

        private void FormBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Đóng form đăng nhập khi form bán hàng đóng
            this.Close();
        }
    }
}
