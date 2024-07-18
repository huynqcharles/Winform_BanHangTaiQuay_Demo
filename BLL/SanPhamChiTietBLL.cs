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
    public class SanPhamChiTietBLL
    {
        SanPhamChiTietDAL sanPhamChiTietDAL = new SanPhamChiTietDAL();

        public List<SanPhamChiTiet> GetAllSanPhamChiTiets()
        {
            return sanPhamChiTietDAL.GetAllSanPhamChiTiets();
        }

        public SanPhamChiTiet GetAllSanPhamChiTietById(string maSPCT)
        {
            return sanPhamChiTietDAL.GetAllSanPhamChiTietById(maSPCT);
        }

        public void UpdateSoLuong(SanPhamChiTiet spctNew)
        {
            sanPhamChiTietDAL.UpdateSoLuong(spctNew);
        }
    }
}
