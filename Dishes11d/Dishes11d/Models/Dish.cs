using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes11d.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public int DishTypeId { get; set; }
        public DishType DishType { get; set; }
        public DateTime RegisterOn{get;set;}
       
    }
}
