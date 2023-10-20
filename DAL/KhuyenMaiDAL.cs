using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMaiDAL
    {
        DoAnModels model;
        public KhuyenMaiDAL(DoAnModels model)
        {
            this.model = model;
        }
        public List<KhuyenMai> getAll()
        {
            return model.KhuyenMais.ToList();
        }

        public KhuyenMai findByName(string name)
        {
                return model.KhuyenMais.FirstOrDefault(k => k.Ten == name);
        }

        public void save(KhuyenMai khuyenMai)
        {
                model.SaveChanges();
        }
    }
}
