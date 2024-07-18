using System;
using System.Collections.Generic;

namespace DTO.Models
{
    public partial class KichCo
    {
        public KichCo()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public string MaKichCo { get; set; } = null!;
        public string? TenKichCo { get; set; }

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
