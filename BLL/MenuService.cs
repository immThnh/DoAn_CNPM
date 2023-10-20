using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MenuService
    {
        DoAnModels context = new DoAnModels();
        public List<Menu> GetALL()
        {
            return context.Menus.ToList();
        }
        public List<MonAn> GetFoodItemsByMenuId(int menuId)
        {

            var foodItems = context.MonAns.Where(m => m.IDMenu == menuId).ToList();

            return foodItems;
        }
    }
}
