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
    public class KhachHangBLL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();

        public KhachHang? GetKhachHangBySDT(string sdt)
        {
            return khachHangDAL.GetKhachHangBySDT(sdt);
        }
    }
}
