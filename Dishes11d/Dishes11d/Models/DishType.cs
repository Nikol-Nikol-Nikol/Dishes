using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes11d.Models
{
    public class DishType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        DateTime RegisterOn{get;set;}
     ICollection<DishType> Dishes {  get; set; }
    }
}
