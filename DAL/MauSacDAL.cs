using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MauSacDAL
    {
        BanHangTaiQuayContext dbContext = new BanHangTaiQuayContext();

        public MauSac? GetMauSacById(string maMauSac)
        {
            return dbContext.MauSacs.FirstOrDefault(ms => ms.MaMauSac == maMauSac);
        }
    }
}
