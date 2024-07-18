using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KichCoBLL
    {
        KichCoDAL kichCoDAL = new KichCoDAL();

        public KichCo? GetKichCoById(string maKichCo)
        {
            return kichCoDAL.GetKichCoById(maKichCo);
        }
    }
}
