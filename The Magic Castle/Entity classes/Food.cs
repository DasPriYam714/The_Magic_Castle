using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Magic_Castle.Entity_classes
{
    class Food
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}
