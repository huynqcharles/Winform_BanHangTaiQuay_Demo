using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KichCoDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public KichCo? GetKichCoById(string maKichCo)
        {
            return dbContext.KichCos.FirstOrDefault(kc => kc.MaKichCo == maKichCo);
        }
    }
}
