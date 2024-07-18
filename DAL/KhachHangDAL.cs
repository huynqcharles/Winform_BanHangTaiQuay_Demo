using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public KhachHang? GetKhachHangBySDT(string sdt)
        {
            return dbContext.KhachHangs.FirstOrDefault(kh => kh.Sdtkh == sdt);
        }
    }
}
