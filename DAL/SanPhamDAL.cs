using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public List<SanPham> GetAllSanPhams()
        {
            return dbContext.SanPhams.ToList();
        }

        public SanPham? GetSanPhamById(string maSanPham)
        {
            return dbContext.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
        }
    }
}
