using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public string MaSanPham { get; set; } = null!;
        public string? TenSanPham { get; set; }
        public string? MoTa { get; set; }

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
