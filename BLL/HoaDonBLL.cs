using DAL;
using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();

        public HoaDon? GetHoaDonbyMaHoaDon(string maHoaDon)
        {
            return hoaDonDAL.GetHoaDonbyMaHoaDon(maHoaDon);
        }

        public List<HoaDon> GetAllHoaDons()
        {
            return hoaDonDAL.GetAllHoaDons();
        }

        public List<HoaDon> GetAllHoaDonChos()
        {
            return hoaDonDAL.GetAllHoaDons().Where(hd => hd.TrangThai == 0).ToList();
        }

        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            hoaDonDAL.TaoHoaDonCho(hoaDon);
        }

        public void SuaTrangThai(string maHoaDon, int trangThai)
        {
            hoaDonDAL.SuaTrangThai(maHoaDon, trangThai);
        }
    }
}
