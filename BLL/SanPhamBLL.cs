using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL sanPhamDAL = new SanPhamDAL();

        public List<SanPham> GetAllSanPhams()
        {
            return sanPhamDAL.GetAllSanPhams();
        }

        public SanPham? GetSanPhamById(string maSanPham)
        {
            return sanPhamDAL.GetSanPhamById(maSanPham);
        }
    }
}
