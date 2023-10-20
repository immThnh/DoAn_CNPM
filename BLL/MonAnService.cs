using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonAnService
    {
        private MonAnDAL monAnDAL = new MonAnDAL();

        public List<MonAn> getAll()
        {
            return monAnDAL.getAll();
        }
        DoAnModels context = new DoAnModels();
        private List<MonAn> selectedItems;

        public List<MonAn> getALL()
        {
            return context.MonAns.ToList();
        }

        public void removeList(List<int> ids)
        {
            foreach (var i in ids)
            {
                MonAn m = context.MonAns.Find(i);
                if (m != null)
                {
                    if (m.IDMenu != null)
                    {
                        m.Menu.MonAns.Remove(m);
                    }
                    if (m.IDKhuyenMai != null)
                    {
                        m.KhuyenMai.MonAns.Remove(m);
                    }
                    if(m.ChiTietHoaDons != null)
                    {
                        context.ChiTietHoaDons.RemoveRange(m.ChiTietHoaDons);
                    }

                    context.MonAns.Remove(m);
                }
            }
            context.SaveChanges();
        }


        public void Them(MonAn monan)
        {
            context.MonAns.Add(monan);
            context.SaveChanges();
        }
        public MonAnService()
        {
            selectedItems = new List<MonAn>();
        }

        public void AddSelectedItem(string itemName)
        {
            MonAn selectedMonAn = getALL().FirstOrDefault(m => m.Ten == itemName);

            if (selectedMonAn != null)
            {
                selectedItems.Add(selectedMonAn);
            }
        }

        public List<MonAn> GetSelectedItems()
        {
            return selectedItems;
        }
        public void CapNhatHoacThem(int maMonAn, int idMenu, string tenMonAn, bool trangThai, int donGia)
        {
            var existingMonAn = context.MonAns.Find(maMonAn);
            var menu = context.Menus.Find(idMenu);
            if (existingMonAn != null)
            {
                existingMonAn.Ten = tenMonAn;
                existingMonAn.GiaGoc = donGia;
                if(existingMonAn.IDKhuyenMai != null)
                {
                    double tiLe = existingMonAn.KhuyenMai.GiamGia / 100.0;
                    existingMonAn.GiaSauGiam = (int)Math.Round(existingMonAn.GiaGoc - (existingMonAn.GiaGoc * tiLe));
                }
                existingMonAn.Menu = menu;
                existingMonAn.IDMenu = idMenu;
            }
            else
            {
                MonAn newMonAn = new MonAn
                {
                    ID = maMonAn,
                    IDMenu = idMenu,
                    Ten = tenMonAn,
                    Menu = menu,
                    GiaGoc = donGia
                };

                context.MonAns.Add(newMonAn);
            }

            context.SaveChanges();
        }

        public void CapNhatHoacThem(int maMonAn, int idMenu, string tenMonAn, bool trangThai, int donGia, string duongDanAnh)
        {
            var existingMonAn = context.MonAns.Find(maMonAn);

            if (existingMonAn != null)
            {
                existingMonAn.Ten = tenMonAn;
                existingMonAn.GiaGoc = donGia;
                if (existingMonAn.IDKhuyenMai != null)
                {
                    double tiLe = existingMonAn.KhuyenMai.GiamGia / 100.0;
                    existingMonAn.GiaGoc = Math.Round(existingMonAn.GiaGoc - (existingMonAn.GiaGoc * tiLe));
                }
                existingMonAn.Anh = duongDanAnh;
            }
            else
            {
                MonAn newMonAn = new MonAn
                {
                    ID = maMonAn,
                    IDMenu = idMenu,
                    Ten = tenMonAn,
                    GiaSauGiam = donGia,
                    GiaGoc = donGia,
                    Anh = duongDanAnh
                };

                context.MonAns.Add(newMonAn);
            }

            context.SaveChanges();
        }
        public void Xoa(int monanID)
        {
            var check = context.MonAns.Find(monanID);
            if (check != null)
            {
                context.MonAns.Remove(check);
                context.SaveChanges();
            }
        }

        public MonAn GetMonAnById(int maMonAn)
        {
            List<MonAn> danhSachMonAn = getALL();


            foreach (MonAn monAn in danhSachMonAn)
            {
                if (monAn.ID == maMonAn)
                {
                    return monAn;
                }
            }

            return null;
        }



    }
}
