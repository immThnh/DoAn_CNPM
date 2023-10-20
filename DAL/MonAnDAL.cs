using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonAnDAL
    {
        private DoAnModels model = new DoAnModels();

        public List<MonAn> getMonAnsByMenuId(int id)
        {
            return model.MonAns.Where(m => m.IDMenu == id).ToList();
        }

        public List<MonAn> getMonAnHasGiamGia()
        {

            return model.MonAns.Where(m => m.IDKhuyenMai != null).ToList();
        }

        public MonAn getByName(string name)
        {
            return model.MonAns.FirstOrDefault(m => m.Ten == name);
        }

        public List<MonAn> getAll() { 
            return model.MonAns.AsNoTracking().ToList();
        }

        public List<MonAn> getMonAnsNotKhuyenMaiByMenuId(int id)
        {
            return model.MonAns.Where(m => m.IDKhuyenMai == null && m.IDMenu == id).ToList();

        }
        public List<MonAn> getMonAnHasNotGiamGia()
        {
            return model.MonAns.Where(m => m.IDKhuyenMai == null).ToList();
        }
    }
}
