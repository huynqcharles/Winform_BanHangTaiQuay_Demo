using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public string MaChucVu { get; set; } = null!;
        public string? TenChucVu { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
