using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaNhanVien { get; set; } = null!;
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? TenNhanVien { get; set; }
        public string? Sdt { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? MaChucVu { get; set; }

        public virtual ChucVu? MaChucVuNavigation { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
