using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public NhanVien? DangNhap(string username, string password)
        {
            return nhanVienDAL.DangNhap(username, password);
        }
    }
}
