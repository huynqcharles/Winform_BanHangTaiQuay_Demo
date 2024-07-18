using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class MauSac
    {
        public MauSac()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public string MaMauSac { get; set; } = null!;
        public string? TenMauSac { get; set; }

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
