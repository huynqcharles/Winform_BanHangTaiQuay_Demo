using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class HoaDonChiTiet
    {
        public string MaSpct { get; set; } = null!;
        public string MaHoaDon { get; set; } = null!;
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }

        public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
        public virtual SanPhamChiTiet MaSpctNavigation { get; set; } = null!;
    }
}
