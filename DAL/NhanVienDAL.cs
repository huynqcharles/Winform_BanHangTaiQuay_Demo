using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public NhanVien? DangNhap(string username, string password)
        {
            return dbContext.NhanViens.FirstOrDefault(nv => nv.Username == username
            && nv.Password == password);
        }
    }
}
