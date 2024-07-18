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
    public class ChucVuBLL
    {
        ChucVuDAL chucVuDAL = new ChucVuDAL();

        public ChucVu? GetChucVuById(string maChucVu)
        {
            return chucVuDAL.GetChucVuById(maChucVu);
        }
    }
}
