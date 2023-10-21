using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class KhuyenMaiService
    {
        private DoAnModels model;
        private readonly KhuyenMaiDAL khuyenMaiDAL;
        private readonly MenuDAL menuDAL;
        private readonly MonAnDAL monAnDAL = new MonAnDAL();

        public KhuyenMaiService(DoAnModels model)
        {
            this.model = model;
            khuyenMaiDAL = new KhuyenMaiDAL(model);
            menuDAL = new MenuDAL(model);

        }
        public List<MonAn> getListMonAn()
        {
            return monAnDAL.getMonAnHasGiamGia();
        }

        public List<Menu> getMenus()
        {
            return menuDAL.getAll();
        }

        public List<KhuyenMai> getAll()
        {
            using (var mode1 = new DoAnModels())
                return mode1.KhuyenMais.ToList();
        }


        public void addOrUpdate(int id, string ten, int giamGia,string noiDung, List<MonAn> monAns)
        {
            DoAnModels dbContext = new DoAnModels();
            var khuyenMai = dbContext.KhuyenMais.Include(km => km.MonAns).FirstOrDefault(k => k.ID == id);

            if (khuyenMai == null)
            {
                khuyenMai = new KhuyenMai();
                khuyenMai.ID = id;
                dbContext.KhuyenMais.Add(khuyenMai);
            }
            khuyenMai.Ten = ten;
            khuyenMai.GiamGia = giamGia;
            khuyenMai.NoiDung = noiDung;

            if (khuyenMai.MonAns == null)
                khuyenMai.MonAns = new List<MonAn>();
            else
            {
                foreach (var monAn in khuyenMai.MonAns.ToList())
                {
                    if (!monAns.Contains(monAn))
                    {
                        monAn.IDKhuyenMai = null;
                        monAn.KhuyenMai = null;
                        khuyenMai.MonAns.Remove(monAn);
                    }
                }
            }

            foreach (var monAn in monAns)
            {
                var existingMonAn = dbContext.MonAns.FirstOrDefault(ma => ma.Ten == monAn.Ten);
                double tiLe = (khuyenMai.GiamGia / 100.0);
                existingMonAn.GiaSauGiam = Math.Round(existingMonAn.GiaGoc - (existingMonAn.GiaGoc * tiLe), 3);
                khuyenMai.MonAns.Add(existingMonAn);
                existingMonAn.IDKhuyenMai = khuyenMai.ID;
                existingMonAn.KhuyenMai = khuyenMai;
            }

            dbContext.SaveChanges();
        }
        public List<MonAn> getMonAnsByMenuId(int ID)
        {
            using (var model = new DoAnModels())
             return monAnDAL.getMonAnsByMenuId(ID);
        }
        public List<MonAn> getMonAnsNotKhuyenMaiByMenuId(int ID)
        {
            using (var model = new DoAnModels())
                return monAnDAL.getMonAnsNotKhuyenMaiByMenuId(ID);
        }
        public List<MonAn> getMonAnsNotKhuyenMai()
        {
            using (var model = new DoAnModels())
            {
                return monAnDAL.getMonAnHasNotGiamGia();
            }
        }

        public void remove(List<KhuyenMai> list)
        {
            using (var model = new DoAnModels())
            {

                foreach (var i in list)
                {
                    KhuyenMai k = model.KhuyenMais.FirstOrDefault(m => m.ID == i.ID);
                    if (k != null)
                    {
                        foreach (var m in k.MonAns)
                        {
                            m.IDKhuyenMai = null;
                        }
                        model.KhuyenMais.Remove(k);
                    }
                }
                model.SaveChanges();
            }
        }

    }
}
