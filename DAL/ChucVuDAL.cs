using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public ChucVu? GetChucVuById(string maChucVu)
        {
            return dbContext.ChucVus.FirstOrDefault(cv => cv.MaChucVu == maChucVu);
        }
    }
}
