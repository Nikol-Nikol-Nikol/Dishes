using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes11d.Models
{
    public class DishContext:DbContext
    {
        public DishContext() : base("DishesContext")
        {

        }
        public DbSet<Dish> Dish { get; set; }
            public DbSet<DishType> DishTypes { get; set; }
    }
}
