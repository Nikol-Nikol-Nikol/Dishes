using Dishes11d.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes11d.Controllers
{
    public class LogicDishes
    {
        private DishContext _dishesDbContext = new DishContext(); // Database
        public List<Dish> GetAll()
        {
            using (_dishesDbContext = new DishContext ())
            {
                List<Dish> listDishes = _dishesDbContext.Dish.ToList();
                return listDishes;
            }
        }

        public Dish Get(int id)
        {
            using (_dishesDbContext = new DishContext())
            {
                Dish findedDishes = _dishesDbContext.Dish.Find(id);
                if (findedDishes!=null)
                {
                    _dishesDbContext.Entry(findedDishes).Reference(x => x.Name).Load();

                }
                return findedDishes;
            }
        }
        public void Update (int id, Dish dishes)
        {
            using( _dishesDbContext = new DishContext ())
            {
                Dish findedDishes= _dishesDbContext .Dish.Find(id);
                if (findedDishes == null)
                {
                    return;
                }
                
            }
        }
           public void Delete(int id)
        {
            using(_dishesDbContext= new DishContext ())
            {
                Dish findedDish = _dishesDbContext.Dish.Find(id);
                _dishesDbContext.Dish.Remove(findedDish);
                _dishesDbContext.SaveChanges();
            }
        }
    }
}
