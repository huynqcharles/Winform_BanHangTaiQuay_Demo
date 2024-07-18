using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonChiTietBLL
    {
        HoaDonChiTietDAL hoaDonChiTietDAL = new HoaDonChiTietDAL();

        public List<HoaDonChiTiet> GetAllHoaDonCTByMaHoaDon(string maHoaDon)
        {
            return hoaDonChiTietDAL.GetAllHoaDonCTByMaHoaDon(maHoaDon);
        }

        public HoaDonChiTiet? GetHDCTById(string maHoaDon, string maSPCT)
        {
            return hoaDonChiTietDAL.GetHDCTById(maHoaDon, maSPCT);
        }

        public void ThemMoiHDCT(HoaDonChiTiet hdct)
        {
            hoaDonChiTietDAL.ThemMoiHDCT(hdct);
        }

        public void UpdateSoLuong(HoaDonChiTiet hdctNew)
        {
            hoaDonChiTietDAL.UpdateSoLuong(hdctNew);
        }
    }
}
