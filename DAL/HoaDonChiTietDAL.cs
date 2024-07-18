using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonChiTietDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public List<HoaDonChiTiet> GetAllHoaDonCTByMaHoaDon(string maHoaDon)
        {
            return dbContext.HoaDonChiTiets.Where(hdct => hdct.MaHoaDon == maHoaDon).ToList();
        }

        public HoaDonChiTiet? GetHDCTById(string maHoaDon, string maSPCT)
        {
            return dbContext.HoaDonChiTiets
                .FirstOrDefault(hdct => hdct.MaHoaDon == maHoaDon && hdct.MaSpct == maSPCT);
        }

        public void ThemMoiHDCT(HoaDonChiTiet hdct)
        {
            dbContext.HoaDonChiTiets.Add(hdct);
            dbContext.SaveChanges();
        }

        public void UpdateSoLuong(HoaDonChiTiet hdctNew)
        {
            var hdctOld = GetHDCTById(hdctNew.MaHoaDon, hdctNew.MaSpct);
            if (hdctOld != null)
            {
                hdctOld.SoLuong = hdctNew.SoLuong;
            }
            dbContext.SaveChanges();
        }
    }
}
