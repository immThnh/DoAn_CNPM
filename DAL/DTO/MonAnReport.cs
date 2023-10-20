using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class MonAnReport
    {
        private double tongTien = 0;
        private double tongChi = 0;
        private DateTime thoiGian;

        public double TongTien { get => tongTien; set => tongTien = value; }
        public double TongChi { get => tongChi; set => tongChi = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }

        public string GetFormattedThoiGian()
        {
            return thoiGian.ToString("dd/MM/yyyy"); // Định dạng ngày/tháng/năm
        }

        public async Task<List<MonAnReport>> getListByTime(DateTime time)
        {
            DoAnModels model = new DoAnModels();

            List<MonAn> monAns = model.MonAns.ToList();
            List<MonAnReport> list = new List<MonAnReport>();
            List<ChiTietHoaDon> chiTiets = model.ChiTietHoaDons.ToList();


            Dictionary<String, int> soLuongBan = new Dictionary<string, int>();

            for (int i = 1; i < 13; i++)
            {
                DateTime d = new DateTime(time.Year, i, 1);
                string formattedDate = d.ToString("dd/MM/yyyy");

                MonAnReport monAnReport = new MonAnReport()
                {
                    thoiGian = d,
                };
                foreach (var chiTiet in chiTiets)
                {
                    double giaGocMonAn = 0;
                    MonAn m = model.MonAns.Find(chiTiet.IDMonAn);
                    if(m != null)
                    giaGocMonAn += m.GiaGoc * chiTiet.SoLuong;
                    if (i == chiTiet.HoaDon.NgayThanhToan.Month  && chiTiet.HoaDon.NgayThanhToan.Year == time.Year)
                    {
                         monAnReport.tongTien += chiTiet.HoaDon.TongTien;
                        monAnReport.tongChi = giaGocMonAn;
                    }
                    else
                    {
                        monAnReport.tongTien += 0;
                        monAnReport.tongChi += 0;

                    }
                }
                list.Add(monAnReport);

            }
            return list;
        }
    }
}
