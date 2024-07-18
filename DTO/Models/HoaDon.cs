using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public string MaHoaDon { get; set; } = null!;
        public DateTime? NgayTao { get; set; }
        public string? GhiChu { get; set; }
        public int? TrangThai { get; set; }
        public string? Sdtkh { get; set; }
        public string? MaNhanVien { get; set; }

        public virtual NhanVien? MaNhanVienNavigation { get; set; }
        public virtual KhachHang? SdtkhNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
