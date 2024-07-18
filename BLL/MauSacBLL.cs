using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MauSacBLL
    {
        MauSacDAL mauSacDAL = new MauSacDAL();

        public MauSac? GetMauSacById(string maMauSac)
        {
            return mauSacDAL.GetMauSacById(maMauSac);
        }
    }
}
