using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public HoaDon? GetHoaDonbyMaHoaDon(string maHoaDon)
        {
            return dbContext.HoaDons.Find(maHoaDon);
        }

        public List<HoaDon> GetAllHoaDons()
        {
            return dbContext.HoaDons.ToList();
        }

        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            dbContext.HoaDons.Add(hoaDon);
            dbContext.SaveChanges();
        }

        public void SuaTrangThai(string maHoaDon, int trangThai)
        {
            var hoaDonSua = dbContext.HoaDons.Find(maHoaDon);
            if (hoaDonSua != null)
            {
                hoaDonSua.TrangThai = trangThai;
            }
            dbContext.SaveChanges();
        }
    }
}
