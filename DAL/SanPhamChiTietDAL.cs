using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamChiTietDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public List<SanPhamChiTiet> GetAllSanPhamChiTiets()
        {
            return dbContext.SanPhamChiTiets.ToList();
        }

        public SanPhamChiTiet GetAllSanPhamChiTietById(string maSPCT)
        {
            return dbContext.SanPhamChiTiets.Find(maSPCT);
        }

        public void UpdateSoLuong(SanPhamChiTiet spctNew)
        {
            var spctOld = GetAllSanPhamChiTietById(spctNew.MaSpct);
            if (spctOld != null)
            {
                spctOld.SoLuong = spctNew.SoLuong;
            }
            dbContext.SaveChanges();
        }
    }
}
