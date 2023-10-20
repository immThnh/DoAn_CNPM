using DAL.DTO;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace BLL
{
    public class HoaDonService
    {
        DoAnModels context = new DoAnModels();

        public bool LuuHoaDon(DateTime thoiGian, List<MonAnInHoaDon> monAns)
        {
            using (var model = new DoAnModels())
            {
                using (var transaction = model.Database.BeginTransaction())
                {
                    //try
                    //{
                        double sum = 0;
                        HoaDon h = new HoaDon()
                        {
                            NgayThanhToan = thoiGian,
                        };
                        model.HoaDons.Add(h);

                        int id = 0; 

                        if (model.ChiTietHoaDons.Any())
                        {
                            id = model.ChiTietHoaDons.Max(x => x.ID);
                        }

                        foreach (var i in monAns)
                        {
                            id++;
                            MonAn m = model.MonAns.Find(i.MonAn.ID);
                            ChiTietHoaDon chiTiet = new ChiTietHoaDon()
                            {
                                ID = id,
                                IDMonAn = m.ID,
                                MonAn = m,
                                SoLuong = i.SoLuong,
                                TongTien = i.TongTien
                            };
                            sum += i.TongTien;
                            h.ChiTietHoaDons.Add(chiTiet);
                        }
                        h.TongTien = sum;
                        model.SaveChanges();
                        transaction.Commit();
                        return true;
                //}
                //    catch (Exception ex)
                //    {
                //    Console.WriteLine(ex.ToString());
                //    return false;
                //}
            }
            }

        }
        public List<HoaDon> getALL()
        {
            return context.HoaDons.ToList();
        }

        public void ThongTinMua(int idMonAn, string hoTen, DateTime ngayMua, int soLuong, int tongTien)
        {
            MonAn monAn = context.MonAns.Find(idMonAn);
            if (monAn == null)
            {
                return;
            }

            HoaDon hoaDon = new HoaDon
            {
                NgayThanhToan = ngayMua,
                TongTien = tongTien,
                ChiTietHoaDons = new List<ChiTietHoaDon>()
            };

            context.HoaDons.Add(hoaDon);
            context.SaveChanges();

            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon
            {
                IDHoaDon = hoaDon.ID,
                IDMonAn = idMonAn,
                SoLuong = soLuong,
                TongTien = tongTien
            };
            // cía này là code hiện tịa đúng không
            context.ChiTietHoaDons.Add(chiTietHoaDon);
            context.SaveChanges();
        }

        public void xoaListHoaDon(List<int> list)
        {
            foreach (int i in list)
            {
                HoaDon h = context.HoaDons.Find(i);
                if(h != null)
                {
                    context.ChiTietHoaDons.RemoveRange(h.ChiTietHoaDons);
                    context.HoaDons.Remove(h);
                }

            }
            context.SaveChanges();
        }
    }
}
