using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string Sdtkh { get; set; } = null!;
        public string? TenKhachHang { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
