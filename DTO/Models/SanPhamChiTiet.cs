using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class SanPhamChiTiet
    {
        public SanPhamChiTiet()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public string MaSpct { get; set; } = null!;
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? MaSanPham { get; set; }
        public string? MaMauSac { get; set; }
        public string? MaKichCo { get; set; }

        public virtual KichCo? MaKichCoNavigation { get; set; }
        public virtual MauSac? MaMauSacNavigation { get; set; }
        public virtual SanPham? MaSanPhamNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
