using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDAL
    {
        private DoAnModels model;

        public MenuDAL(DoAnModels model) {
            this.model = model;
        }
        public List<Menu> getAll()
        {
            return model.Menus.ToList();
        }

    }
}
