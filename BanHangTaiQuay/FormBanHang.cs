using BLL;
using DTO.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BanHangTaiQuay
{
    public partial class FormBanHang : Form
    {
        NhanVien _nhanVien { get; set; }
        DataTable dataTableSPCT = new DataTable();
        DataTable dataTableHDCT = new DataTable();

        ChucVuBLL chucVuBLL = new ChucVuBLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        SanPhamChiTietBLL sanPhamChiTietBLL = new SanPhamChiTietBLL();
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        MauSacBLL mauSacBLL = new MauSacBLL();
        KichCoBLL kichCoBLL = new KichCoBLL();
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        HoaDonChiTietBLL hoaDonChiTietBLL = new HoaDonChiTietBLL();

        private bool daThanhToanDu = false; 

        public FormBanHang(NhanVien nhanVien)
        {
            _nhanVien = nhanVien;
            InitializeComponent();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            lblTenNhanVien.Text = _nhanVien.TenNhanVien;
            lblQuyenNhanVien.Text = chucVuBLL.GetChucVuById(_nhanVien.MaChucVu).TenChucVu;

            // create datatable SPCT
            dataTableSPCT.Columns.Add("MaSPCT", typeof(string));
            dataTableSPCT.Columns.Add("TenSP", typeof(string));
            dataTableSPCT.Columns.Add("MauSac", typeof(string));
            dataTableSPCT.Columns.Add("KichCo", typeof(string));
            dataTableSPCT.Columns.Add("DonGia", typeof(decimal));
            dataTableSPCT.Columns.Add("SoLuong", typeof(int));

            LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());

            LoadData_cbbHoaDonCho();

            // create datatable HDCT
            dataTableHDCT.Columns.Add("MaSPCT", typeof(string));
            dataTableHDCT.Columns.Add("MaHoaDon", typeof(string));
            dataTableHDCT.Columns.Add("DonGia", typeof(decimal));
            dataTableHDCT.Columns.Add("SoLuong", typeof(int));

            if (cbbHoaDonCho.SelectedValue != null)
            {
                LoadData_dgvHoaDonChiTiet(hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(cbbHoaDonCho.SelectedValue.ToString()));
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var khachHang = khachHangBLL.GetKhachHangBySDT(txtSDT.Text);
                if (khachHang == null)
                {
                    MessageBox.Show("SĐT khách hàng không hợp lệ!");
                }
                else
                {
                    txtTenKH.Text = khachHang.TenKhachHang;
                }
            }
        }

        private void LoadData_dgvSanPhamChiTiet(List<SanPhamChiTiet> sanPhamChiTiets)
        {
            dataTableSPCT.Rows.Clear();

            foreach (var spct in sanPhamChiTiets)
            {
                DataRow dr = dataTableSPCT.NewRow();
                dr["MaSPCT"] = spct.MaSpct;
                dr["TenSP"] = sanPhamBLL.GetSanPhamById(spct.MaSanPham).TenSanPham;
                dr["MauSac"] = mauSacBLL.GetMauSacById(spct.MaMauSac).TenMauSac;
                dr["KichCo"] = kichCoBLL.GetKichCoById(spct.MaKichCo).TenKichCo;
                dr["DonGia"] = spct.DonGia;
                dr["SoLuong"] = spct.SoLuong;
                dataTableSPCT.Rows.Add(dr);
            }
            dgvSanPhamChiTiet.DataSource = dataTableSPCT;
        }

        private void LoadData_dgvHoaDonChiTiet(List<HoaDonChiTiet> hoaDonChiTiets)
        {
            dataTableHDCT.Rows.Clear();

            foreach (var hdct in hoaDonChiTiets)
            {
                DataRow dr = dataTableHDCT.NewRow();
                dr["MaSPCT"] = hdct.MaSpct;
                dr["MaHoaDon"] = hdct.MaHoaDon;
                dr["DonGia"] = hdct.DonGia;
                dr["SoLuong"] = hdct.SoLuong;
                dataTableHDCT.Rows.Add(dr);
            }
            dgvHoaDonChiTiet.DataSource = dataTableHDCT;
            if (cbbHoaDonCho.SelectedValue != null)
            {
                lblTongTien.Text = TinhTongTienHoaDon(cbbHoaDonCho.SelectedValue.ToString()).ToString("#,##0.00 'VND'");
            }
        }

        private void LoadData_cbbHoaDonCho()
        {
            cbbHoaDonCho.DataSource = null;
            cbbHoaDonCho.Items.Clear();

            // Load dữ liệu lên combobox
            var listHoaDonCho = hoaDonBLL.GetAllHoaDonChos();
            cbbHoaDonCho.DataSource = listHoaDonCho; // nguồn dữ liệu combobox
            cbbHoaDonCho.DisplayMember = "MaHoaDon"; // mỗi item hiển thị mã hóa đơn
            cbbHoaDonCho.ValueMember = "MaHoaDon"; // mỗi item có giá trị là mã hóa đơn
            cbbHoaDonCho.SelectedItem = listHoaDonCho.FirstOrDefault();

            if (listHoaDonCho.Count == 0)
            {
                cbbHoaDonCho.SelectedIndex = -1; // Không chọn mục nào cả
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var listSPTimKiem = sanPhamBLL.GetAllSanPhams()
                .Where(sp => sp.TenSanPham.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();

            var listSPCTTimKiem = sanPhamChiTietBLL.GetAllSanPhamChiTiets()
                .Where(spct => listSPTimKiem.Contains(sanPhamBLL.GetSanPhamById(spct.MaSanPham))).ToList();

            LoadData_dgvSanPhamChiTiet(listSPCTTimKiem);
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            var khachHang = khachHangBLL.GetKhachHangBySDT(txtSDT.Text);
            if (khachHang == null)
            {
                MessageBox.Show("SĐT khách hàng không hợp lệ!");
            }
            else
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = "HD" + (hoaDonBLL.GetAllHoaDons().Count + 1);
                hoaDon.MaNhanVien = _nhanVien.MaNhanVien;
                hoaDon.Sdtkh = txtSDT.Text;
                hoaDon.NgayTao = DateTime.Now;
                hoaDon.TrangThai = 0; // 0: hóa đơn chờ, 1: đã thanh toán, 2: đã hủy (tự quy định)

                hoaDonBLL.TaoHoaDonCho(hoaDon);

                MessageBox.Show("Tạo hóa đơn chờ thành công!");

                LoadData_cbbHoaDonCho();
            }
        }

        private void cbbHoaDonCho_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hoaDonDangChon = cbbHoaDonCho.SelectedItem as HoaDon;

            if (hoaDonDangChon != null)
            {
                txtSDT.Text = hoaDonDangChon.Sdtkh;
                txtTenKH.Text = khachHangBLL.GetKhachHangBySDT(hoaDonDangChon.Sdtkh).TenKhachHang;
                LoadData_dgvHoaDonChiTiet(hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(hoaDonDangChon.MaHoaDon));
            }
        }

        private void dgvSanPhamChiTiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowHienTai = dgvSanPhamChiTiet.Rows[e.RowIndex];
            var maSPCTDangTao = rowHienTai.Cells[0].Value.ToString();
            var spctDangTao = sanPhamChiTietBLL.GetAllSanPhamChiTietById(maSPCTDangTao);

            var hoaDonDangChon = cbbHoaDonCho.SelectedItem as HoaDon;

            FormSoLuongMua formSoLuongMua = new FormSoLuongMua();
            formSoLuongMua.ShowDialog();

            var hoaDonChiTietTonTai = hoaDonChiTietBLL.GetHDCTById(hoaDonDangChon.MaHoaDon, maSPCTDangTao);

            // chưa tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> thêm mới
            if (hoaDonChiTietTonTai == null)
            {
                HoaDonChiTiet hoaDonChiTietDangTao = new HoaDonChiTiet();
                hoaDonChiTietDangTao.MaSpct = maSPCTDangTao;
                hoaDonChiTietDangTao.MaHoaDon = hoaDonDangChon.MaHoaDon;
                hoaDonChiTietDangTao.DonGia = spctDangTao.DonGia;
                hoaDonChiTietDangTao.SoLuong = formSoLuongMua.SoLuongMua;

                hoaDonChiTietBLL.ThemMoiHDCT(hoaDonChiTietDangTao);
            }
            // nếu đã tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> cập nhật số lượng
            else
            {
                HoaDonChiTiet hoaDonChiTietDangUpdate = new HoaDonChiTiet();
                hoaDonChiTietDangUpdate.MaSpct = maSPCTDangTao;
                hoaDonChiTietDangUpdate.MaHoaDon = hoaDonDangChon.MaHoaDon;
                hoaDonChiTietDangUpdate.DonGia = spctDangTao.DonGia;
                hoaDonChiTietDangUpdate.SoLuong = hoaDonChiTietTonTai.SoLuong + formSoLuongMua.SoLuongMua;

                hoaDonChiTietBLL.UpdateSoLuong(hoaDonChiTietDangUpdate);
            }

            spctDangTao.SoLuong -= formSoLuongMua.SoLuongMua;
            sanPhamChiTietBLL.UpdateSoLuong(spctDangTao);

            // load lại dữ liệu trên 2 data grid view
            txtTimKiem.Text = string.Empty;
            LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
            LoadData_dgvHoaDonChiTiet(hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(cbbHoaDonCho.SelectedValue.ToString()));
        }

        private decimal TinhTongTienHoaDon(string maHoaDon)
        {
            var listHDCT = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal tongTien = 0;

            foreach (var hdct in listHDCT)
            {
                tongTien += hdct.DonGia * hdct.SoLuong;
            }

            return tongTien;
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            decimal tienKhachDua = 0;
            var tongSoTien = TinhTongTienHoaDon(cbbHoaDonCho.SelectedValue.ToString());

            if (decimal.TryParse(txtTienKhachDua.Text, out tienKhachDua))
            {
                lblTienThua.Text = (tienKhachDua - tongSoTien).ToString("#,##0.00 'VND'");
                if (tienKhachDua >= tongSoTien)
                {
                    daThanhToanDu = true;
                }
                else
                {
                    daThanhToanDu = false;
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng số tiền!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            var listHDCT = hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(cbbHoaDonCho.SelectedValue.ToString());
            foreach (var hdct in listHDCT)
            {
                var spct = sanPhamChiTietBLL.GetAllSanPhamChiTietById(hdct.MaSpct);
                // hoàn lại số lượng sản phẩm đã chọn trong hóa đơn vào lại danh sách sản phẩm
                spct.SoLuong += hdct.SoLuong;

                sanPhamChiTietBLL.UpdateSoLuong(spct);
            }

            hoaDonBLL.SuaTrangThai(cbbHoaDonCho.SelectedValue.ToString(), 2);
            MessageBox.Show("Đã hủy hóa đơn!");
            RefreshToanBoForm();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (TinhTongTienHoaDon(cbbHoaDonCho.SelectedValue.ToString()) > 0)
            {
                if (daThanhToanDu)
                {
                    hoaDonBLL.SuaTrangThai(cbbHoaDonCho.SelectedValue.ToString(), 1);
                    MessageBox.Show("Đã thanh toán hóa đơn!");
                    RefreshToanBoForm();
                }
                else
                {
                    MessageBox.Show("Tiền khách đưa chưa đủ!");
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn trống!");
            }
        }

        private void RefreshToanBoForm()
        {
            txtSDT.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            txtTienKhachDua.Text = "0";
            lblTienThua.Text = "Tiền thừa";
            lblTongTien.Text = "Tổng tiền";

            LoadData_cbbHoaDonCho();
            LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
            if (cbbHoaDonCho.SelectedValue != null)
            {
                LoadData_dgvHoaDonChiTiet(hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(cbbHoaDonCho.SelectedValue.ToString()));
            }
            else
            {
                LoadData_dgvHoaDonChiTiet(new List<HoaDonChiTiet>());
            }
        }
    }
}
