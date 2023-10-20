using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class MonAnInHoaDon
    {
        private int soLuong = 1;
        private MonAn monAn;
        private double tongTien = 0;

        public int SoLuong { get => soLuong; set => soLuong = value; }
        public MonAn MonAn { get => monAn; set => monAn = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }

        public override string ToString()
        {
            return monAn.Ten;
        }
    }
}
